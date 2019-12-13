using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellar
{
    static class Serializer
    {

        public static List<Models.Collection> GetCollections()
        {
            List<Models.Collection> records = new List<Models.Collection>();
            List<string> data = DataAdapter.GetRecords();

            foreach (string item in data)
            {
                Models.Collection newCollection = DeserializeCollection(item);
                records.Add(newCollection);
            }

            return records;
        }

        public static void StoreCollections(List<Models.Collection> records)
        {
            List<string> data = new List<string>();

            foreach (Models.Collection item in records)
            {
                string serializedData = SerializeCollection(item);
                data.Add(serializedData);
            }

            DataAdapter.StoreRecords(data);
        }

        public static string SerializeCollection(Models.Collection cellar)
        {
            string data = "";

            //TO DO

            return data;
        }

        public static string SerializePhoto(System.Drawing.Image img)
        {
            string data = "";

            //TO DO

            return data;
        }

        public static Models.Collection DeserializeCollection(string data)
        {
            Models.Collection cellar = null;

            //TO DO

            return cellar;
        }

        public static System.Drawing.Image DeserializePhoto(string data)
        {
            System.Drawing.Image img = null;

            //TO DO

            return img;
        }
    }
}
