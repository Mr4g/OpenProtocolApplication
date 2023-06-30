using OpenProtocolInterpreter.Communication;
using OpenProtocolInterpreter.Job;
using OpenProtocolInterpreter.KeepAlive;
using OpenProtocolInterpreter.Sample.Driver;
using OpenProtocolInterpreter.Sample.Driver.Commands;
using OpenProtocolInterpreter.Sample.Driver.Events;
using OpenProtocolInterpreter.Sample.Driver.Helpers;
using OpenProtocolInterpreter.Tightening;
using OpenProtocolInterpreter.Vin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenProtocolInterpreter;

namespace OpenProtocolInterpreter.Sample
{
    public partial class DriverForm : Form
    {
        private readonly Timer _keepAliveTimer;
        private OpenProtocolDriver driver;

        CsvWriter csvWriter = new CsvWriter("log.txt");
        

        public DriverForm()
        {
            InitializeComponent();
            _keepAliveTimer = new Timer();
            _keepAliveTimer.Tick += KeepAliveTimer_Tick;
            _keepAliveTimer.Interval = 1000;
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            // Added list of mids i want to use in my interpreter, every another will be desconsidered
            driver = new OpenProtocolDriver(new Type[]
            {
        typeof(Mid0002),
        typeof(Mid0005),
        typeof(Mid0004),
        typeof(Mid0003),
        typeof(ParameterSet.Mid0011),
        typeof(ParameterSet.Mid0013),
        typeof(Mid0035),
        typeof(Mid0031),
        typeof(Alarm.Mid0071),
        typeof(Alarm.Mid0074),
        typeof(Alarm.Mid0076),
        typeof(Vin.Mid0052),
        typeof(Mid0061),
        typeof(Mid0065),
        typeof(Time.Mid0081),
        typeof(Mid9999)
            });

            var client = new Ethernet.SimpleTcpClient().Connect("192.168.0.2", 4545);
            if (driver.BeginCommunication(client))
            {
                _keepAliveTimer.Start();
                connectionStatus.Text = "Connected!";
                connectionStatus.BackColor = Color.Green;

                // Subskrypcja Job Info
                Console.WriteLine($"Sending Job Info Subscribe...");
                var packJobInfo = driver.SendAndWaitForResponse(new Mid0034().Pack(), TimeSpan.FromSeconds(10));
                if (packJobInfo != null)
                {
                    if (packJobInfo.Header.Mid == Mid0004.MID)
                    {
                        var mid04 = packJobInfo as Mid0004;
                        Console.WriteLine($@"Error while subscribing (MID 0004):
                                     Error Code: <{mid04.ErrorCode}>
                                     Failed MID: <{mid04.FailedMid}>");
                    }
                    else
                        Console.WriteLine($"Job Info Subscribe accepted!");
                }
                driver.AddUpdateOnReceivedCommand(typeof(Mid0035), OnJobInfoReceived);

                // Subskrypcja Tightening
                Console.WriteLine($"Sending Tightening Subscribe...");
                var packTightening = driver.SendAndWaitForResponse(new Mid0060().Pack(), TimeSpan.FromSeconds(10));
                if (packTightening != null)
                {
                    if (packTightening.Header.Mid == Mid0004.MID)
                    {
                        var mid04 = packTightening as Mid0004;
                        Console.WriteLine($@"Error while subscribing (MID 0004):
                                     Error Code: <{mid04.ErrorCode}>
                                     Failed MID: <{mid04.FailedMid}>");
                    }
                    else
                        Console.WriteLine($"Tightening Subscribe accepted!");
                }
                driver.AddUpdateOnReceivedCommand(typeof(Mid0061), OnTighteningReceived);
            }
            else
            {
                driver = null;
                connectionStatus.Text = "Disconnected!";
                connectionStatus.BackColor = Color.Red;
            }
        }

        private void KeepAliveTimer_Tick(object sender, EventArgs e)
        {
            if (driver.KeepAlive.ElapsedMilliseconds > 10000) //10 sec
            {
                Console.WriteLine($"Sending Keep Alive...");
                var pack = driver.SendAndWaitForResponse(new Mid9999().Pack(), TimeSpan.FromSeconds(10));
                if (pack != null && pack.Header.Mid == Mid9999.MID)
                {
                    lastMessageArrived.Text = Mid9999.MID.ToString();
                    Console.WriteLine($"Keep Alive Received");
                }
                else
                    Console.WriteLine($"Keep Alive Not Received");
            }
        }

        ///// <summary>
        ///// job info subscribe
        /////</summary>
        ///// <param name = "sender" ></ param >
        ///// < param name="e"></param>
        //private void btnjobinfosubscribe_click(object sender, eventargs e)
        //{
        //    console.writeline($"sending job info subscribe...");
        //    var pack = driver.sendandwaitforresponse(new mid0034().pack(), timespan.fromseconds(10));

        //    if (pack != null)
        //    {
        //        if (pack.header.mid == mid0004.mid)
        //        {
        //            var mid04 = pack as mid0004;
        //            console.writeline($@"error while subscribing (mid 0004):
        //                                 error code: <{mid04.errorcode}>
        //                                 failed mid: <{mid04.failedmid}>");
        //        }
        //        else
        //            console.writeline($"job info subscribe accepted!");
        //    }

        //    driver.addupdateonreceivedcommand(typeof(mid0035), onjobinforeceived);
        //}

        ///// <summary>
        ///// tightening subscribe
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btntighteningsubscribe_click(object sender, eventargs e)
        //{

        //    console.writeline($"sending tightening subscribe...");
        //    var pack = driver.sendandwaitforresponse(new mid0060().pack(), timespan.fromseconds(10));

        //    if (pack != null)
        //    {
        //        if (pack.header.mid == mid0004.mid)
        //        {
        //            var mid04 = pack as mid0004;
        //            console.writeline($@"error while subscribing (mid 0004):
        //                                 error code: <{mid04.errorcode}>
        //                                 failed mid: <{mid04.failedmid}>");
        //        }
        //        else
        //            console.writeline($"tightening subscribe accepted!");
        //    }

        //    //register command
        //    driver.addupdateonreceivedcommand(typeof(mid0061), ontighteningreceived);
        //}


        private void BtnSendJob_Click(object sender, EventArgs e)
        {
            new SendJobCommand(driver).Execute((int)numericJob.Value);
        }

        /// <summary>
        /// Async method from controller, MID 0035 (Job Info)
        /// </summary>
        /// <param name="e"></param>
        private void OnJobInfoReceived(MIDIncome e)
        {
            driver.SendMessage(e.Mid.BuildAckPackage());

            var jobInfo = e.Mid as Mid0035;
            lastMessageArrived.Text = Mid0035.MID.ToString();
            Console.WriteLine($@"JOB INFO RECEIVED (MID 0035): 
                                 Job ID: <{jobInfo.JobId}>
                                 Job Status: <{(int)jobInfo.JobStatus}> ({jobInfo.JobStatus.ToString()})
                                 Job Batch Mode: <{(int)jobInfo.JobBatchMode}> ({jobInfo.JobBatchMode.ToString()})
                                 Job Batch Size: <{jobInfo.JobBatchSize}>
                                 Job Batch Counter: <{jobInfo.JobBatchCounter}>
                                 TimeStamp: <{jobInfo.TimeStamp.ToString("yyyy-MM-dd:HH:mm:ss")}>");
        }

        /// <summary>
        /// Async method from controller, MID 0061 (Last Tightening)
        /// Basically, on every tightening this method will be called!
        /// </summary>
        /// <param name="e"></param>
        private void OnTighteningReceived(MIDIncome e)
        {
            driver.SendMessage(e.Mid.BuildAckPackage());

            var tighteningMid = e.Mid as Mid0061;
            lastMessageArrived.Text = Mid0061.MID.ToString();
            List<string> parameters = new List<string>
                    {
                        $"TimeStamp: {tighteningMid.Timestamp.ToString("yyyy-MM-dd:HH:mm:ss")}",
                        $"VIN Number: {tighteningMid.VinNumber}",
                        $"Cell ID: {tighteningMid.CellId}",
                        $"Channel ID: {tighteningMid.ChannelId}",
                        $"Torque Controller Name: {tighteningMid.TorqueControllerName}",
                        $"Job ID: {tighteningMid.JobId}",
                        $"Parameter Set ID: {tighteningMid.ParameterSetId}",
                        $"Batch Size: {tighteningMid.BatchSize}",
                        $"Batch Counter: {tighteningMid.BatchCounter}",
                        $"Tightening Status: {tighteningMid.TighteningStatus}",
                        $"Torque Status: {(int)tighteningMid.TorqueStatus} ({tighteningMid.TorqueStatus.ToString()})",
                        $"Angle Status: {(int)tighteningMid.AngleStatus} ({tighteningMid.AngleStatus.ToString()})",
                        $"Torque Min Limit: {tighteningMid.TorqueMinLimit}",
                        $"Torque Max Limit: {tighteningMid.TorqueMaxLimit}",
                        $"Torque Final Target: {tighteningMid.TorqueFinalTarget}",
                        $"Torque: {tighteningMid.Torque}",
                        $"Angle Min Limit: {tighteningMid.AngleMinLimit}",
                        $"Angle Max Limit: {tighteningMid.AngleMaxLimit}",
                        $"Final Angle Target: {tighteningMid.AngleFinalTarget}",
                        $"Angle: {tighteningMid.Angle}",
                        $"Last Change In Parameter Set: {tighteningMid.LastChangeInParameterSet.ToString("yyyy-MM-dd:HH:mm:ss")}",
                        $"Batch Status: {(int)tighteningMid.BatchStatus} ({tighteningMid.BatchStatus})",
                        $"TighteningID: {tighteningMid.TighteningId}"
                    };

            List<object> parametersCsv = new List<object>
                    {
                        tighteningMid.Timestamp.ToString("yyyy-MM-dd:HH:mm:ss"),
                        tighteningMid.VinNumber,
                        tighteningMid.CellId,
                        tighteningMid.TorqueControllerName,
                        tighteningMid.JobId,
                        tighteningMid.ParameterSetId,
                        tighteningMid.BatchSize,
                        tighteningMid.BatchCounter,
                        tighteningMid.TighteningStatus,
                        (int)tighteningMid.TorqueStatus,
                        tighteningMid.AngleStatus,
                        tighteningMid.TorqueMinLimit,
                        tighteningMid.TorqueMaxLimit,
                        tighteningMid.TorqueFinalTarget,
                        tighteningMid.Torque,
                        tighteningMid.AngleMinLimit,
                        tighteningMid.AngleMaxLimit,
                        tighteningMid.AngleFinalTarget,
                        tighteningMid.Angle,
                        tighteningMid.LastChangeInParameterSet.ToString("yyyy-MM-dd:HH:mm:ss"),
                        (int)tighteningMid.BatchStatus,
                        tighteningMid.TighteningId
                    };
            List<object> parametersDataGridView1 = new List<object>
                    {
                        tighteningMid.Timestamp.ToString("yyyy-MM-dd:HH:mm:ss"),
                        tighteningMid.VinNumber.ToString(),
                        tighteningMid.CellId.ToString(),
                        tighteningMid.Torque.ToString(),
                        tighteningMid.TorqueMaxLimit.ToString(),
                        tighteningMid.TorqueMinLimit.ToString(),
                        tighteningMid.Angle.ToString(),
                        tighteningMid.AngleMaxLimit.ToString(),
                        tighteningMid.AngleMinLimit.ToString(),
                        tighteningMid.BatchStatus.ToString(),
                    };

            AddRowToDataGridView(parametersDataGridView1);
            csvWriter.ManualGenerateDataFile(parametersCsv);

            // Słownik mapujący kontrolki tekstowe na właściwości
            var controlsMap = new Dictionary<Control, Func<string>>
            {
                { vin, () => $"VIN Number: {tighteningMid.VinNumber}" },
                { timeStamp, () => $"TimeStamp: {tighteningMid.Timestamp.ToString("yyyy-MM-dd:HH:mm:ss")}" },
                { torqueMinLimit, () => $"Torque Min Limit: {tighteningMid.TorqueMinLimit}" },
                { torqueMaxLimit, () => $"Torque Max Limit: {tighteningMid.TorqueMaxLimit}" },
                { torque, () => $"Torque: {tighteningMid.Torque}" },
                { torqueFinalTarget, () => $"Torque Final Target: {tighteningMid.TorqueFinalTarget}" },
                { angleFinalTarget, () => $"Final Angle Target: {tighteningMid.AngleFinalTarget}" },
                { angleMinLimit, () => $"Angle Min Limit: {tighteningMid.AngleMinLimit}" },
                { angleMaxLimit, () => $"Angle Max Limit: {tighteningMid.AngleMaxLimit}" },
                { angleLabel, () => $"Angle: {tighteningMid.Angle}" }
            };

            // Aktualizacja kontrolek tekstowych
            foreach (var kvp in controlsMap)
            {
                var control = kvp.Key;
                var updateText = kvp.Value;

                control.Invoke((MethodInvoker)(() =>
                {
                    control.Text = updateText();
                }));
            }

            // Definiowanie mapowania wartości na kolory i widoczność obrazków
            var statusMap = new Dictionary<string, (Color, bool)>
                      {
                         { "Ok", (Color.LightGreen, false) },    //LimeGreen
                         { "Nok", (Color.IndianRed, true) },
                         { "Low", (Color.IndianRed, true) },
                         { "High", (Color.IndianRed, true) }
                       };

            // Funkcja aktualizująca formanty UI na podstawie danych
            void UpdateUI(string status, Panel panel, PictureBox pictureBoxOk, PictureBox pictureBoxNok)
            {
                if (statusMap.TryGetValue(status, out var values))
                {
                    var (color, isVisible) = values;

                    panel.Invoke((MethodInvoker)(() =>
                    {
                        panel.BackColor = color;
                    }));

                    pictureBoxOk.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxOk.Visible = !isVisible;
                    }));

                    pictureBoxNok.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxNok.Visible = isVisible;
                    }));
                }
            }

            // Wywołanie funkcji dla poszczególnych danych
            UpdateUI(tighteningMid.AngleStatus.ToString(), panelAngle, pictureBoxCheckOkAngle, pictureBoxCheckNokAngle);
            UpdateUI(tighteningMid.TorqueStatus.ToString(), panelTorque, pictureBoxCheckOkTorque, pictureBoxCheckNokTorque);
            UpdateUI(tighteningMid.BatchStatus.ToString(), panelCheck, pictureBoxNextStepOk, pictureBoxNextStepNok);

            void BackToStartValueAfterDelay()
            {
                // Słownik mapujący kontrolki tekstowe na właściwości
                var controlsMapStart = new Dictionary<Control, Func<string>>
                {
                    { vin, () => $"VIN Number: " },
                    { timeStamp, () => $"TimeStamp: " },
                    { torqueMinLimit, () => $"Torque Min Limit: " },
                    { torqueMaxLimit, () => $"Torque Max Limit: " },
                    { torque, () => $"Torque: " },
                    { torqueFinalTarget, () => $"Torque Final Target: " },
                    { angleFinalTarget, () => $"Final Angle Target: " },
                    { angleMinLimit, () => $"Angle Min Limit: " },
                    { angleMaxLimit, () => $"Angle Max Limit: " },
                    { angleLabel, () => $"Angle: " }
                };

                // Aktualizacja kontrolek tekstowych
                foreach (var kvp in controlsMapStart)
                {
                    var control = kvp.Key;
                    var updateText = kvp.Value;

                    control.Invoke((MethodInvoker)(() =>
                    {
                        control.Text = updateText();
                    }));    
                }

                var isVinNumber = controlsMapStart[vin]() == "VIN Number: ";

                // Aktualizacja kolorów paneli
                panelAngle.BackColor = isVinNumber ? Color.Gainsboro : panelAngle.BackColor;
                panelTorque.BackColor = isVinNumber ? Color.Gainsboro : panelTorque.BackColor;
                panelCheck.BackColor = isVinNumber ? Color.Gainsboro : panelCheck.BackColor;

                // Ukrywanie obrazków
                if (isVinNumber)
                {
                    pictureBoxCheckOkAngle.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxCheckOkAngle.Visible = false;
                    }));

                    pictureBoxCheckNokAngle.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxCheckNokAngle.Visible = false;
                    }));

                    pictureBoxCheckOkTorque.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxCheckOkTorque.Visible = false;
                    }));

                    pictureBoxCheckNokTorque.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxCheckNokTorque.Visible = false;
                    }));

                    pictureBoxNextStepOk.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxNextStepOk.Visible = false;
                    }));

                    pictureBoxNextStepNok.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxNextStepNok.Visible = false;
                    }));
                }
            }
            void AddRowToDataGridView(List<object> parametersDataGridView)
            {
                if (dataGridView1.InvokeRequired)
                {
                    dataGridView1.Invoke((MethodInvoker)delegate {
                        dataGridView1.Rows.Add(parametersDataGridView.ToArray());
                    });
                }
                else
                {
                    dataGridView1.Rows.Add(parametersDataGridView.ToArray());
                }
            }
            // Wywołanie funkcji po 10 sekundach
            if (tighteningMid.BatchStatus == BatchStatus.Ok)
            {
                Task.Delay(TimeSpan.FromSeconds(10)).ContinueWith((task) => BackToStartValueAfterDelay());
            }
        }

        private void BtnSendProduct_Click(object sender, EventArgs e)
        {
            new DownloadProductCommand(driver).Execute(txtProduct.Text);
        }

        private void BtnAbortJob_Click(object sender, EventArgs e)
        {
            new AbortJobCommand(driver).Execute();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            switch (clickedButton.Name)
            {
                case "settingButton":

                    tabControl1.SelectedTab = tabPage1;

                    break;
                case "workspaceButton":
                    tabControl1.SelectedTab = tabPage2;

                    break;
                case "buttonDataGridView1":
                    tabControl1.SelectedTab = tabPage5;
                    break; 
                default:
                    // Jeśli nazwa przycisku nie pasuje do żadnego przypadku, możesz tutaj obsłużyć odpowiednie działanie lub zostawić puste.
                    break;
            }
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {

        }

        public class TransparentPictureBox : PictureBox
        {
            public TransparentPictureBox()
            {
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                BackColor = Color.Transparent;
                Image = GenerateTransparentImage(Color.Green);
            }

            private Bitmap GenerateTransparentImage(Color color)
            {
                Bitmap bitmap = new Bitmap(Width, Height);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Brush brush = new SolidBrush(color))
                    {
                        graphics.FillRectangle(brush, ClientRectangle);
                    }
                }
                return bitmap;
            }
        }

    }


}