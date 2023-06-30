//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace OpenProtocolInterpreter.Sample
//{
//    public class WriteToTable
//    {

//        public void DisplayParametersInTable(List<string> parameters)
//        {
//            // Jeśli tabela DataGridView nie istnieje na formularzu, dodaj ją i skonfiguruj
//            if (dataGridView1 == null)
//            {

//                // Dodaj kolumny do tabeli
//                for (int i = 0; i < parameters.Count; i++)
//                {
//                    dataGridView1.Columns.Add($"Column{i}", $"Column{i}");
//                }
//            }

//            // Usuń istniejące wiersze z tabeli
//            dataGridView1.Rows.Clear();

//            // Dodaj nowy wiersz do tabeli
//            dataGridView1.Rows.Add(parameters.ToArray());
//        }
//    }
//}
