using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Araba.Classes;

namespace Araba
{
    class Araba
    {
        //int _Id;
        //public string Id
        //{
        //    get
        //    {
                
        //    }
        //    set
        //    {
        //        _Id = value;
        //    }


        //}
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KapıSayısı { get; set; }
        public string BeygirGücü { get; set; }
        public ArabaTürüEnum ArabaTürü { get; set; }
        public int MaxHız { get; set; }
        public string Çekiş { get; set; }
        public int SıfırYüz { get; set; }
        public int Agırlık { get; set; }
        public int MotorHacmi { get; set; }

    }
}
