using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCSerialize.Lib.Model
{
    [Serializable]
   public class PC
    {
        public string Title { get; set; }
        public string SerialNum { get; set; }

        public string Model { get; set; }

        public string Made { get; set; }

        [NonSerialized]
        public int ID;

        public PC() { }

        public PC(string Title, string SerialNum, string Model, string Made)
        {
            this.Title = Title;
            this.SerialNum = SerialNum;
            this.Model = Model;
            this.Made = Made;
            this.ID = ID;
        }
    }
}
