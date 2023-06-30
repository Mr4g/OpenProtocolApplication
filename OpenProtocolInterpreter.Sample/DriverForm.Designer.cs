using System.Drawing;
using System.Windows.Forms;
using OpenProtocolInterpreter;

namespace OpenProtocolInterpreter.Sample
{
    partial class DriverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox20Nm = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTorque = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.torqueFinalTarget = new System.Windows.Forms.Label();
            this.torque = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.torqueMaxLimit = new System.Windows.Forms.Label();
            this.torqueMinLimit = new System.Windows.Forms.Label();
            this.panelCheck = new System.Windows.Forms.Panel();
            this.pictureBoxNextStepNok = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckNokTorque = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckNokAngle = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckOkTorque = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckOkAngle = new System.Windows.Forms.PictureBox();
            this.pictureBoxNextStepOk = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelAngle = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.angleFinalTarget = new System.Windows.Forms.Label();
            this.angleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.angleMaxLimit = new System.Windows.Forms.Label();
            this.angleMinLimit = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.timeStamp = new System.Windows.Forms.Label();
            this.vin = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.textIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAbortJob = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnSendProduct = new System.Windows.Forms.Button();
            this.btnSendJob = new System.Windows.Forms.Button();
            this.numericJob = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTighteningSubscribe = new System.Windows.Forms.Button();
            this.btnJobInfoSubscribe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericPort = new System.Windows.Forms.NumericUpDown();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeStampTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinNumberTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellIdTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.torqueTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.torqueMaxTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.torqueMinTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleMaxTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleMinTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchStatusTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolstripLast = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastMessageArrived = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.topGrupBox = new System.Windows.Forms.GroupBox();
            this.buttonDataGridView1 = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.workspaceButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.csvWriterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20Nm)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelTorque.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextStepNok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckNokTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckNokAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckOkTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckOkAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextStepOk)).BeginInit();
            this.panelAngle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericJob)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.topGrupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvWriterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(3, 812);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1588, 67);
            this.bottomPanel.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 19);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1580, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox20Nm);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Size = new System.Drawing.Size(1574, 648);
            this.splitContainer1.SplitterDistance = 533;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox20Nm
            // 
            this.pictureBox20Nm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox20Nm.Image = global::OpenProtocolInterpreter.Sample.Properties.Resources._20NM;
            this.pictureBox20Nm.Location = new System.Drawing.Point(-7, 3);
            this.pictureBox20Nm.Name = "pictureBox20Nm";
            this.pictureBox20Nm.Size = new System.Drawing.Size(529, 648);
            this.pictureBox20Nm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox20Nm.TabIndex = 0;
            this.pictureBox20Nm.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.Controls.Add(this.panelTorque, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelCheck, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelAngle, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 209);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.545455F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.545455F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 436);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panelTorque
            // 
            this.panelTorque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTorque.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTorque.Controls.Add(this.panel18);
            this.panelTorque.Controls.Add(this.panel8);
            this.panelTorque.Controls.Add(this.panel9);
            this.panelTorque.Controls.Add(this.label4);
            this.panelTorque.Controls.Add(this.panel10);
            this.panelTorque.Location = new System.Drawing.Point(350, 22);
            this.panelTorque.Name = "panelTorque";
            this.panelTorque.Size = new System.Drawing.Size(310, 390);
            this.panelTorque.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.AutoSize = true;
            this.panel18.BackColor = System.Drawing.Color.OrangeRed;
            this.panel18.Location = new System.Drawing.Point(11, 196);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(237, 4);
            this.panel18.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.torqueFinalTarget);
            this.panel8.Controls.Add(this.torque);
            this.panel8.Location = new System.Drawing.Point(3, 228);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(294, 99);
            this.panel8.TabIndex = 2;
            // 
            // torqueFinalTarget
            // 
            this.torqueFinalTarget.AutoSize = true;
            this.torqueFinalTarget.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torqueFinalTarget.Location = new System.Drawing.Point(3, 58);
            this.torqueFinalTarget.Name = "torqueFinalTarget";
            this.torqueFinalTarget.Size = new System.Drawing.Size(237, 28);
            this.torqueFinalTarget.TabIndex = 5;
            this.torqueFinalTarget.Text = "Torque  Final Target";
            // 
            // torque
            // 
            this.torque.AutoSize = true;
            this.torque.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torque.Location = new System.Drawing.Point(3, 14);
            this.torque.Name = "torque";
            this.torque.Size = new System.Drawing.Size(97, 28);
            this.torque.TabIndex = 4;
            this.torque.Text = "Torque ";
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.BackColor = System.Drawing.Color.OrangeRed;
            this.panel9.Location = new System.Drawing.Point(11, 31);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(237, 4);
            this.panel9.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Torque";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.torqueMaxLimit);
            this.panel10.Controls.Add(this.torqueMinLimit);
            this.panel10.Location = new System.Drawing.Point(11, 56);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(294, 107);
            this.panel10.TabIndex = 0;
            // 
            // torqueMaxLimit
            // 
            this.torqueMaxLimit.AutoSize = true;
            this.torqueMaxLimit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torqueMaxLimit.Location = new System.Drawing.Point(3, 63);
            this.torqueMaxLimit.Name = "torqueMaxLimit";
            this.torqueMaxLimit.Size = new System.Drawing.Size(222, 28);
            this.torqueMaxLimit.TabIndex = 4;
            this.torqueMaxLimit.Text = "Torque  Max Limit ";
            // 
            // torqueMinLimit
            // 
            this.torqueMinLimit.AutoSize = true;
            this.torqueMinLimit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torqueMinLimit.Location = new System.Drawing.Point(3, 16);
            this.torqueMinLimit.Name = "torqueMinLimit";
            this.torqueMinLimit.Size = new System.Drawing.Size(206, 28);
            this.torqueMinLimit.TabIndex = 3;
            this.torqueMinLimit.Text = "Torque  Min Limit";
            // 
            // panelCheck
            // 
            this.panelCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCheck.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCheck.Controls.Add(this.pictureBoxNextStepNok);
            this.panelCheck.Controls.Add(this.pictureBoxCheckNokTorque);
            this.panelCheck.Controls.Add(this.pictureBoxCheckNokAngle);
            this.panelCheck.Controls.Add(this.pictureBoxCheckOkTorque);
            this.panelCheck.Controls.Add(this.pictureBoxCheckOkAngle);
            this.panelCheck.Controls.Add(this.pictureBoxNextStepOk);
            this.panelCheck.Controls.Add(this.label12);
            this.panelCheck.Controls.Add(this.label9);
            this.panelCheck.Controls.Add(this.label5);
            this.panelCheck.Controls.Add(this.panel14);
            this.panelCheck.Controls.Add(this.label10);
            this.panelCheck.Location = new System.Drawing.Point(697, 22);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(312, 390);
            this.panelCheck.TabIndex = 5;
            // 
            // pictureBoxNextStepNok
            // 
            this.pictureBoxNextStepNok.Image = global::OpenProtocolInterpreter.Sample.Properties.Resources.checkNOK;
            this.pictureBoxNextStepNok.Location = new System.Drawing.Point(248, 247);
            this.pictureBoxNextStepNok.Name = "pictureBoxNextStepNok";
            this.pictureBoxNextStepNok.Size = new System.Drawing.Size(52, 54);
            this.pictureBoxNextStepNok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNextStepNok.TabIndex = 9;
            this.pictureBoxNextStepNok.TabStop = false;
            // 
            // pictureBoxCheckNokTorque
            // 
            this.pictureBoxCheckNokTorque.Image = global::OpenProtocolInterpreter.Sample.Properties.Resources.checkNOK;
            this.pictureBoxCheckNokTorque.Location = new System.Drawing.Point(248, 163);
            this.pictureBoxCheckNokTorque.Name = "pictureBoxCheckNokTorque";
            this.pictureBoxCheckNokTorque.Size = new System.Drawing.Size(52, 54);
            this.pictureBoxCheckNokTorque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckNokTorque.TabIndex = 8;
            this.pictureBoxCheckNokTorque.TabStop = false;
            // 
            // pictureBoxCheckNokAngle
            // 
            this.pictureBoxCheckNokAngle.Image = global::OpenProtocolInterpreter.Sample.Properties.Resources.checkNOK;
            this.pictureBoxCheckNokAngle.Location = new System.Drawing.Point(248, 79);
            this.pictureBoxCheckNokAngle.Name = "pictureBoxCheckNokAngle";
            this.pictureBoxCheckNokAngle.Size = new System.Drawing.Size(52, 54);
            this.pictureBoxCheckNokAngle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckNokAngle.TabIndex = 7;
            this.pictureBoxCheckNokAngle.TabStop = false;
            // 
            // pictureBoxCheckOkTorque
            // 
            this.pictureBoxCheckOkTorque.Image = global::OpenProtocolInterpreter.Sample.Properties.Resources.checkOK;
            this.pictureBoxCheckOkTorque.Location = new System.Drawing.Point(248, 163);
            this.pictureBoxCheckOkTorque.Name = "pictureBoxCheckOkTorque";
            this.pictureBoxCheckOkTorque.Size = new System.Drawing.Size(52, 54);
            this.pictureBoxCheckOkTorque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckOkTorque.TabIndex = 6;
            this.pictureBoxCheckOkTorque.TabStop = false;
            // 
            // pictureBoxCheckOkAngle
            // 
            this.pictureBoxCheckOkAngle.Image = global::OpenProtocolInterpreter.Sample.Properties.Resources.checkOK;
            this.pictureBoxCheckOkAngle.Location = new System.Drawing.Point(248, 79);
            this.pictureBoxCheckOkAngle.Name = "pictureBoxCheckOkAngle";
            this.pictureBoxCheckOkAngle.Size = new System.Drawing.Size(52, 54);
            this.pictureBoxCheckOkAngle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckOkAngle.TabIndex = 5;
            this.pictureBoxCheckOkAngle.TabStop = false;
            // 
            // pictureBoxNextStepOk
            // 
            this.pictureBoxNextStepOk.Image = global::OpenProtocolInterpreter.Sample.Properties.Resources.checkOK;
            this.pictureBoxNextStepOk.Location = new System.Drawing.Point(248, 247);
            this.pictureBoxNextStepOk.Name = "pictureBoxNextStepOk";
            this.pictureBoxNextStepOk.Size = new System.Drawing.Size(52, 54);
            this.pictureBoxNextStepOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNextStepOk.TabIndex = 5;
            this.pictureBoxNextStepOk.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(22, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 44);
            this.label12.TabIndex = 4;
            this.label12.Text = "Next Step";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(22, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 44);
            this.label9.TabIndex = 3;
            this.label9.Text = "Torque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(22, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 44);
            this.label5.TabIndex = 2;
            this.label5.Text = "Angle";
            // 
            // panel14
            // 
            this.panel14.AutoSize = true;
            this.panel14.BackColor = System.Drawing.Color.OrangeRed;
            this.panel14.Location = new System.Drawing.Point(13, 31);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(237, 4);
            this.panel14.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(9, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Check List";
            // 
            // panelAngle
            // 
            this.panelAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAngle.AutoSize = true;
            this.panelAngle.BackColor = System.Drawing.Color.Gainsboro;
            this.panelAngle.Controls.Add(this.panel17);
            this.panelAngle.Controls.Add(this.panel4);
            this.panelAngle.Controls.Add(this.panel3);
            this.panelAngle.Controls.Add(this.label3);
            this.panelAngle.Controls.Add(this.panel2);
            this.panelAngle.Location = new System.Drawing.Point(3, 22);
            this.panelAngle.Name = "panelAngle";
            this.panelAngle.Size = new System.Drawing.Size(310, 390);
            this.panelAngle.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.AutoSize = true;
            this.panel17.BackColor = System.Drawing.Color.OrangeRed;
            this.panel17.Location = new System.Drawing.Point(11, 196);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(237, 4);
            this.panel17.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.angleFinalTarget);
            this.panel4.Controls.Add(this.angleLabel);
            this.panel4.Location = new System.Drawing.Point(3, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 99);
            this.panel4.TabIndex = 2;
            // 
            // angleFinalTarget
            // 
            this.angleFinalTarget.AutoSize = true;
            this.angleFinalTarget.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angleFinalTarget.Location = new System.Drawing.Point(3, 58);
            this.angleFinalTarget.Name = "angleFinalTarget";
            this.angleFinalTarget.Size = new System.Drawing.Size(221, 28);
            this.angleFinalTarget.TabIndex = 4;
            this.angleFinalTarget.Text = "Angle Final Target";
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angleLabel.Location = new System.Drawing.Point(3, 14);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(81, 28);
            this.angleLabel.TabIndex = 3;
            this.angleLabel.Text = "Angle";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(11, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 4);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Angle";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.angleMaxLimit);
            this.panel2.Controls.Add(this.angleMinLimit);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 107);
            this.panel2.TabIndex = 0;
            // 
            // angleMaxLimit
            // 
            this.angleMaxLimit.AutoSize = true;
            this.angleMaxLimit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angleMaxLimit.Location = new System.Drawing.Point(3, 63);
            this.angleMaxLimit.Name = "angleMaxLimit";
            this.angleMaxLimit.Size = new System.Drawing.Size(206, 28);
            this.angleMaxLimit.TabIndex = 3;
            this.angleMaxLimit.Text = "Angle Max Limit ";
            // 
            // angleMinLimit
            // 
            this.angleMinLimit.AutoSize = true;
            this.angleMinLimit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angleMinLimit.Location = new System.Drawing.Point(3, 16);
            this.angleMinLimit.Name = "angleMinLimit";
            this.angleMinLimit.Size = new System.Drawing.Size(190, 28);
            this.angleMinLimit.TabIndex = 2;
            this.angleMinLimit.Text = "Angle Min Limit";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel16);
            this.panel5.Location = new System.Drawing.Point(14, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1012, 183);
            this.panel5.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Information ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.timeStamp);
            this.panel7.Controls.Add(this.vin);
            this.panel7.Location = new System.Drawing.Point(16, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(772, 124);
            this.panel7.TabIndex = 2;
            // 
            // timeStamp
            // 
            this.timeStamp.AutoSize = true;
            this.timeStamp.BackColor = System.Drawing.Color.Gainsboro;
            this.timeStamp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeStamp.Location = new System.Drawing.Point(53, 78);
            this.timeStamp.Name = "timeStamp";
            this.timeStamp.Size = new System.Drawing.Size(124, 25);
            this.timeStamp.TabIndex = 8;
            this.timeStamp.Text = "TimeStamp";
            // 
            // vin
            // 
            this.vin.AutoSize = true;
            this.vin.BackColor = System.Drawing.Color.Gainsboro;
            this.vin.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vin.Location = new System.Drawing.Point(38, 22);
            this.vin.Name = "vin";
            this.vin.Size = new System.Drawing.Size(107, 56);
            this.vin.TabIndex = 6;
            this.vin.Text = "VIN";
            // 
            // panel16
            // 
            this.panel16.AutoSize = true;
            this.panel16.BackColor = System.Drawing.Color.OrangeRed;
            this.panel16.Location = new System.Drawing.Point(16, 31);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(772, 10);
            this.panel16.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1580, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(728, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tool 20Nm";
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.Color.LightGray;
            this.btnConnection.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.torque;
            this.btnConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(660, 206);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(246, 213);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl1.Location = new System.Drawing.Point(3, 129);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1588, 677);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 19);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1580, 654);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(1574, 648);
            this.splitContainer2.SplitterDistance = 523;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Location = new System.Drawing.Point(4, 19);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1580, 654);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Panel2.Controls.Add(this.textIp);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Panel2.Controls.Add(this.label2);
            this.splitContainer3.Panel2.Controls.Add(this.numericPort);
            this.splitContainer3.Size = new System.Drawing.Size(1574, 648);
            this.splitContainer3.SplitterDistance = 523;
            this.splitContainer3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP:";
            // 
            // textIp
            // 
            this.textIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIp.Location = new System.Drawing.Point(50, 22);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(135, 22);
            this.textIp.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAbortJob);
            this.groupBox2.Controls.Add(this.txtProduct);
            this.groupBox2.Controls.Add(this.btnSendProduct);
            this.groupBox2.Controls.Add(this.btnSendJob);
            this.groupBox2.Controls.Add(this.numericJob);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // btnAbortJob
            // 
            this.btnAbortJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbortJob.Location = new System.Drawing.Point(6, 50);
            this.btnAbortJob.Name = "btnAbortJob";
            this.btnAbortJob.Size = new System.Drawing.Size(168, 23);
            this.btnAbortJob.TabIndex = 12;
            this.btnAbortJob.Text = "Abort Job";
            this.btnAbortJob.UseVisualStyleBackColor = true;
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(189, 21);
            this.txtProduct.MaxLength = 25;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(160, 22);
            this.txtProduct.TabIndex = 10;
            // 
            // btnSendProduct
            // 
            this.btnSendProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendProduct.Location = new System.Drawing.Point(355, 20);
            this.btnSendProduct.Name = "btnSendProduct";
            this.btnSendProduct.Size = new System.Drawing.Size(100, 23);
            this.btnSendProduct.TabIndex = 11;
            this.btnSendProduct.Text = "Send Product";
            this.btnSendProduct.UseVisualStyleBackColor = true;
            // 
            // btnSendJob
            // 
            this.btnSendJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendJob.Location = new System.Drawing.Point(74, 21);
            this.btnSendJob.Name = "btnSendJob";
            this.btnSendJob.Size = new System.Drawing.Size(100, 23);
            this.btnSendJob.TabIndex = 10;
            this.btnSendJob.Text = "Send Job";
            this.btnSendJob.UseVisualStyleBackColor = true;
            // 
            // numericJob
            // 
            this.numericJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericJob.Location = new System.Drawing.Point(6, 21);
            this.numericJob.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericJob.Name = "numericJob";
            this.numericJob.Size = new System.Drawing.Size(62, 22);
            this.numericJob.TabIndex = 10;
            this.numericJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTighteningSubscribe);
            this.groupBox1.Controls.Add(this.btnJobInfoSubscribe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 85);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subscribes";
            // 
            // btnTighteningSubscribe
            // 
            this.btnTighteningSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTighteningSubscribe.Location = new System.Drawing.Point(115, 21);
            this.btnTighteningSubscribe.Name = "btnTighteningSubscribe";
            this.btnTighteningSubscribe.Size = new System.Drawing.Size(103, 51);
            this.btnTighteningSubscribe.TabIndex = 11;
            this.btnTighteningSubscribe.Text = "Tightening Subscribe";
            this.btnTighteningSubscribe.UseVisualStyleBackColor = true;
            // 
            // btnJobInfoSubscribe
            // 
            this.btnJobInfoSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobInfoSubscribe.Location = new System.Drawing.Point(6, 21);
            this.btnJobInfoSubscribe.Name = "btnJobInfoSubscribe";
            this.btnJobInfoSubscribe.Size = new System.Drawing.Size(103, 51);
            this.btnJobInfoSubscribe.TabIndex = 10;
            this.btnJobInfoSubscribe.Text = "Job Info Subscribe";
            this.btnJobInfoSubscribe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Port:";
            // 
            // numericPort
            // 
            this.numericPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPort.Location = new System.Drawing.Point(264, 23);
            this.numericPort.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericPort.Name = "numericPort";
            this.numericPort.Size = new System.Drawing.Size(95, 22);
            this.numericPort.TabIndex = 13;
            this.numericPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPort.Value = new decimal(new int[] {
            4545,
            0,
            0,
            0});
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 19);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1580, 654);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeStampTable,
            this.vinNumberTable,
            this.CellIdTable,
            this.torqueTable,
            this.torqueMaxTable,
            this.torqueMinTable,
            this.angleTable,
            this.angleMaxTable,
            this.angleMinTable,
            this.batchStatusTable});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1574, 648);
            this.dataGridView1.TabIndex = 0;
            // 
            // timeStampTable
            // 
            this.timeStampTable.FillWeight = 65.3168F;
            this.timeStampTable.HeaderText = "TimeStamp";
            this.timeStampTable.Name = "timeStampTable";
            // 
            // vinNumberTable
            // 
            this.vinNumberTable.FillWeight = 74.44603F;
            this.vinNumberTable.HeaderText = "VIN";
            this.vinNumberTable.Name = "vinNumberTable";
            // 
            // CellIdTable
            // 
            this.CellIdTable.FillWeight = 82.97898F;
            this.CellIdTable.HeaderText = "Cell ID";
            this.CellIdTable.Name = "CellIdTable";
            // 
            // torqueTable
            // 
            this.torqueTable.FillWeight = 90.95459F;
            this.torqueTable.HeaderText = "Torque";
            this.torqueTable.Name = "torqueTable";
            // 
            // torqueMaxTable
            // 
            this.torqueMaxTable.FillWeight = 98.40924F;
            this.torqueMaxTable.HeaderText = "Torque Max";
            this.torqueMaxTable.Name = "torqueMaxTable";
            // 
            // torqueMinTable
            // 
            this.torqueMinTable.FillWeight = 105.377F;
            this.torqueMinTable.HeaderText = "Torque Min";
            this.torqueMinTable.Name = "torqueMinTable";
            // 
            // angleTable
            // 
            this.angleTable.FillWeight = 111.8896F;
            this.angleTable.HeaderText = "Angle";
            this.angleTable.Name = "angleTable";
            // 
            // angleMaxTable
            // 
            this.angleMaxTable.FillWeight = 117.9769F;
            this.angleMaxTable.HeaderText = "Angle Max";
            this.angleMaxTable.Name = "angleMaxTable";
            // 
            // angleMinTable
            // 
            this.angleMinTable.FillWeight = 123.6665F;
            this.angleMinTable.HeaderText = "AngleMin";
            this.angleMinTable.Name = "angleMinTable";
            // 
            // batchStatusTable
            // 
            this.batchStatusTable.FillWeight = 128.9846F;
            this.batchStatusTable.HeaderText = "Batch Status";
            this.batchStatusTable.Name = "batchStatusTable";
            // 
            // connectionStatus
            // 
            this.connectionStatus.BackColor = System.Drawing.Color.Red;
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(79, 16);
            this.connectionStatus.Text = "Disconnected";
            // 
            // toolstripLast
            // 
            this.toolstripLast.Name = "toolstripLast";
            this.toolstripLast.Size = new System.Drawing.Size(96, 16);
            this.toolstripLast.Text = "Last Mid Arrived:";
            // 
            // lastMessageArrived
            // 
            this.lastMessageArrived.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lastMessageArrived.Name = "lastMessageArrived";
            this.lastMessageArrived.Size = new System.Drawing.Size(1404, 16);
            this.lastMessageArrived.Spring = true;
            this.lastMessageArrived.Text = "Last MID";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatus,
            this.toolstripLast,
            this.lastMessageArrived});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1594, 21);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // topGrupBox
            // 
            this.topGrupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topGrupBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.topGrupBox.Controls.Add(this.buttonDataGridView1);
            this.topGrupBox.Controls.Add(this.settingButton);
            this.topGrupBox.Controls.Add(this.workspaceButton);
            this.topGrupBox.Controls.Add(this.pictureBox1);
            this.topGrupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.topGrupBox.Location = new System.Drawing.Point(3, 24);
            this.topGrupBox.Name = "topGrupBox";
            this.topGrupBox.Size = new System.Drawing.Size(1588, 99);
            this.topGrupBox.TabIndex = 16;
            this.topGrupBox.TabStop = false;
            // 
            // buttonDataGridView1
            // 
            this.buttonDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDataGridView1.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.table;
            this.buttonDataGridView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDataGridView1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataGridView1.Location = new System.Drawing.Point(1285, 12);
            this.buttonDataGridView1.Name = "buttonDataGridView1";
            this.buttonDataGridView1.Size = new System.Drawing.Size(94, 75);
            this.buttonDataGridView1.TabIndex = 3;
            this.buttonDataGridView1.UseVisualStyleBackColor = true;
            this.buttonDataGridView1.Click += new System.EventHandler(this.button_Click);
            // 
            // settingButton
            // 
            this.settingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingButton.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.gear;
            this.settingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Location = new System.Drawing.Point(1485, 12);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(94, 75);
            this.settingButton.TabIndex = 2;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.button_Click);
            // 
            // workspaceButton
            // 
            this.workspaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.workspaceButton.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.manufacture;
            this.workspaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.workspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workspaceButton.Location = new System.Drawing.Point(1385, 12);
            this.workspaceButton.Name = "workspaceButton";
            this.workspaceButton.Size = new System.Drawing.Size(94, 75);
            this.workspaceButton.TabIndex = 1;
            this.workspaceButton.UseVisualStyleBackColor = true;
            this.workspaceButton.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.topGrupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bottomPanel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.439024F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.43764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.130081F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1594, 882);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // csvWriterBindingSource
            // 
            this.csvWriterBindingSource.DataSource = typeof(OpenProtocolInterpreter.Sample.CsvWriter);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1594, 882);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DriverForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20Nm)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelTorque.ResumeLayout(false);
            this.panelTorque.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panelCheck.ResumeLayout(false);
            this.panelCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextStepNok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckNokTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckNokAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckOkTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckOkAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextStepOk)).EndInit();
            this.panelAngle.ResumeLayout(false);
            this.panelAngle.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericJob)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.topGrupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.csvWriterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel bottomPanel;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox20Nm;
        private Panel panelCheck;
        private PictureBox pictureBoxNextStepNok;
        private PictureBox pictureBoxCheckNokTorque;
        private PictureBox pictureBoxCheckNokAngle;
        private PictureBox pictureBoxCheckOkTorque;
        private PictureBox pictureBoxCheckOkAngle;
        private PictureBox pictureBoxNextStepOk;
        private Label label12;
        private Label label9;
        private Label label5;
        private Panel panel14;
        private Label label10;
        private Panel panel5;
        private Label label8;
        private Panel panel7;
        private Label timeStamp;
        private Label vin;
        private Panel panel16;
        private Panel panelTorque;
        private Panel panel18;
        private Panel panel8;
        private Label torqueFinalTarget;
        private Label torque;
        private Panel panel9;
        private Label label4;
        private Panel panel10;
        private Label torqueMaxLimit;
        private Label torqueMinLimit;
        private Panel panelAngle;
        private Panel panel17;
        private Panel panel4;
        private Label angleFinalTarget;
        private Label angleLabel;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label angleMaxLimit;
        private Label angleMinLimit;
        private TabPage tabPage1;
        private Button btnConnection;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private SplitContainer splitContainer2;
        private TabPage tabPage4;
        private SplitContainer splitContainer3;
        private ToolStripStatusLabel connectionStatus;
        private ToolStripStatusLabel toolstripLast;
        private ToolStripStatusLabel lastMessageArrived;
        private StatusStrip statusStrip1;
        private Button workspaceButton;
        private Button settingButton;
        private GroupBox topGrupBox;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage tabPage5;
        private DataGridView dataGridView1;
        private BindingSource csvWriterBindingSource;
        private Label label1;
        private TextBox textIp;
        private GroupBox groupBox2;
        private Button btnAbortJob;
        private TextBox txtProduct;
        private Button btnSendProduct;
        private Button btnSendJob;
        private NumericUpDown numericJob;
        private GroupBox groupBox1;
        private Button btnTighteningSubscribe;
        private Button btnJobInfoSubscribe;
        private Label label2;
        private NumericUpDown numericPort;
        private Label label7;
        private DataGridViewTextBoxColumn timeStampTable;
        private DataGridViewTextBoxColumn vinNumberTable;
        private DataGridViewTextBoxColumn CellIdTable;
        private DataGridViewTextBoxColumn torqueTable;
        private DataGridViewTextBoxColumn torqueMaxTable;
        private DataGridViewTextBoxColumn torqueMinTable;
        private DataGridViewTextBoxColumn angleTable;
        private DataGridViewTextBoxColumn angleMaxTable;
        private DataGridViewTextBoxColumn angleMinTable;
        private DataGridViewTextBoxColumn batchStatusTable;
        private Button buttonDataGridView1;
    }
}

