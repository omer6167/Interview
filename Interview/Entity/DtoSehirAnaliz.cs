using Interview.Entity.Abstract;

namespace Interview.Entity
{
    public class DtoSehirAnaliz :IDto
    {
        public string SehirAdi { get; set; }
        public int SepetAdet { get; set; }
        public int ToplamTutar { get; set; }
    }
}
