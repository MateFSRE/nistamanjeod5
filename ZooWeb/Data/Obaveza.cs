using System;

namespace ZooWeb.Data
{
    public class Obaveza
    {
        public int ID_obaveze { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public string status { get; set; }
        public DateTime? datum { get; set; }
        public string periodicnost { get; set; }
        public int? ID_radnika { get; set; }
        public int? ID_jedinke { get; set; }
        public int? ID_skupine { get; set; }
    }
}
