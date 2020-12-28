namespace Holzlager.DataClasses
{
    public class Package
    {
        public string Holztyp { get; set; }
        public int PacketNr { get; set; }
        public string Holzherkunft { get; set; }
        public int Jahr { get; set; }
        public int Holzlaenge { get; set; }
        public int Holzdicke { get; set; }
        public double Breitenmeter { get; set; }
        public double Kubikmeter { get; set; }
    }
}