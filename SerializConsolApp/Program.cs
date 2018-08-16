using PCSerialize.Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> ListPC = new List<PC>();
            ListPC.Add(new PC("mark1", Guid.NewGuid().ToString(), "uyferut94589", "Aser") { ID=1});
            ListPC.Add(new PC("mark2", Guid.NewGuid().ToString(), "ndgjd897", "Apple") { ID = 2 });
            ListPC.Add(new PC("mark3", Guid.NewGuid().ToString(), "dnhf9", "Lenovo") { ID = 3 });
            ListPC.Add(new PC("mark4", Guid.NewGuid().ToString(), "874jj", "Asus") { ID = 4 });

           
            //создадим объект binnaryFormater
            BinaryFormatter formatter = new BinaryFormatter();

            //поток, куда будем записывать объект сериализации
            using (FileStream fs = new FileStream("listSerial.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ListPC);
                Console.WriteLine("Объект сериализрован");
            }


           
        }
    }
}
