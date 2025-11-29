using System;

namespace ZooWeb.Data
{
    public class Raspored
    {
        public int ID_rasporeda { get; set; }
        public int ID_radnika { get; set; }
        public DateTime datum { get; set; }
        public string smjena { get; set; }
        public string status { get; set; }
    }
}

