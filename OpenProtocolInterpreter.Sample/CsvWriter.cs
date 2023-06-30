using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpenProtocolInterpreter.Sample
{
    public class CsvWriter
    {
        public CsvWriter(string fileName)
        {
            this.FileName = fileName;
        }
        public string FileName { get; private set; }



        public void ManualGenerateDataFile(List<object> parametersCsv)
        {
            string line = string.Join(",", parametersCsv.Select(x => x.ToString()));

            if (File.Exists(FileName))
            {
                using (var writer = File.AppendText(FileName))
                {
                    writer.WriteLine(line);
                }
            }
            else
            {
                using (var writer = File.AppendText(FileName))
                {
                    writer.WriteLine("TimeStamp,VINNumber,CellID,TorqueController Name,JobID,ParameterSetID,BatchSize,BatchCounter,TighteningStatus,TorqueStatus,AngleStatus,TorqueMinLimit,TorqueMaxLimit,TorqueFinalTarget,Torque,AngleMinLimit,AngleMaxLimit,FinalAngleTarget,Angle,LastChangeInParameterSet,BatchStatus,TighteningID");
                    writer.WriteLine(line);
                }
            }
        }
    }
}
