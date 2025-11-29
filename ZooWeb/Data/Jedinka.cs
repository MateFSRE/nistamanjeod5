using System;

namespace ZooWeb.Data
{
    public class Jedinka
    {
        public int ID_jedinke { get; set; }
        public string nadimak { get; set; }
        public int ID_vrste { get; set; }
        public int ID_nastambe { get; set; }
        public string opis { get; set; }
        public DateTime? datum_nabavke { get; set; }
        public decimal? trosak { get; set; }
        public string tip_troska { get; set; }
        public bool aktivna { get; set; }
    }
}
