using System;

namespace ZooWeb.Data
{
    public class Skupina
    {
        public int ID_skupine { get; set; }
        public string naziv { get; set; }
        public int ID_vrste { get; set; }
        public int ID_nastambe { get; set; }
        public int? prosjecan_broj { get; set; }
        public string opis { get; set; }
        public DateTime? datum_nabavke { get; set; }
        public decimal? trosak { get; set; }
        public string tip_troska { get; set; }
    }
}

