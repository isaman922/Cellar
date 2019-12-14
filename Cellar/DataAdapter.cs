using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Cellar
{
    public static class DataAdapter
    {
        static string textPath = Path.GetDirectoryName(Application.ExecutablePath).ToString() + @"\..\..\StoredData.txt";

        public static List<string> GetRecords()
        {
            //Retrieve each item from the database
            List<string> records = new List<string>();

            //Open the streamreader
            StreamReader sr = new StreamReader(textPath);
            string line = sr.ReadLine();

            //Add a string item for as many lines as there are in the document.
            while (line != null)
            {
                try
                {
                    records.Add(line);
                    line = sr.ReadLine();
                }
                catch (Exception e)
                {
                    //Indicating what line the error occured at when reading the file
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Close the streamreader
            sr.Close();

            return records;
        }

        public static void StoreRecords(List<string> records)
        {
            //Store each item in the database

            //Open the FileStream and writer
            StreamWriter sw = new StreamWriter(textPath, false);

            foreach (string record in records)
            {
                //Write to memory
                sw.WriteLine(record);
            }

            //Close the streamwriter
            sw.Close();
        }
    }
}
