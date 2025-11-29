namespace ZooWeb.Data
{
    public class Radnik
    {
        public int ID_radnika { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string kontakt_broj { get; set; }
        public int? ID_obrazovanja { get; set; }
        public string tip_radnika { get; set; }
        public int ID_zoo { get; set; }
    }
}
