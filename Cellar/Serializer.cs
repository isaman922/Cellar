using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
            //Setup memory string to hold the object in memory format and transform process.
            MemoryStream myStream = new MemoryStream();

            //Set up the binary formater for serialization.
            BinaryFormatter myFormater = new BinaryFormatter();

            myFormater.Serialize(myStream, cellar);
            //Convert to 64 bit data
            string data = Convert.ToBase64String(myStream.ToArray());

            myStream.Close();

            return data;
        }

        public static string SerializePhoto(System.Drawing.Image img)
        {
            //Setup memory string to hold the object in memory format and transform process.
            MemoryStream myStream = new MemoryStream();

            //Set up the binary formater for serialization.
            BinaryFormatter myFormater = new BinaryFormatter();

            myFormater.Serialize(myStream, img);
            //Convert to 64 bit data
            string data = Convert.ToBase64String(myStream.ToArray());

            myStream.Close();

            return data;
        }

        public static Models.Collection DeserializeCollection(string data)
        {
            Models.Collection cellar = null;

            //Set up the binary formater for serialization.
            BinaryFormatter bf = new BinaryFormatter();

            //Convert the base64 string to an array of bytes to pass to the memory stream
            byte[] b = Convert.FromBase64String(data);

            //Setup memory string to hold the object in memory format and transform process.
            MemoryStream ms = new MemoryStream(b);

            //Deserialize
            try
            {
                cellar = (Models.Collection)bf.Deserialize(ms);
            }
            finally
            {
                ms.Close();
            }

            return cellar;
        }

        public static System.Drawing.Image DeserializePhoto(string data)
        {
            System.Drawing.Image img = null;

            //Set up the binary formater for serialization.
            BinaryFormatter bf = new BinaryFormatter();

            //Convert the base64 string to an array of bytes to pass to the memory stream
            byte[] b = Convert.FromBase64String(data);

            //Setup memory string to hold the object in memory format and transform process.
            MemoryStream ms = new MemoryStream(b);

            //Deserialize
            try
            {
                img = (System.Drawing.Image)bf.Deserialize(ms);
            }
            finally
            {
                ms.Close();
            }

            return img;
        }
    }
}
