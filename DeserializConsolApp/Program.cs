using PCSerialize.Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeserializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\КимМ\Documents\Visual Studio 2015\Projects\PCSerialize\SerializConsolApp\bin\Debug\listSerial.txt", FileMode.OpenOrCreate))
            {
                var t =(List<PC>)bf.Deserialize(fs);
                Console.WriteLine("Объект десериализирован");
                foreach (PC item in t)
                {
                    Console.WriteLine(item.Title+"\t"+item.SerialNum+"\t"+item.Model+"\t"+item.Made);
                }
                
            }
        }
    }
}
