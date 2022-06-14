using System.ComponentModel.DataAnnotations;

namespace Interview.Entity
{
    public class SepetUrun
    {
        [Key]
        public int Id { get; set; }
        public int SepetId { get; set; }
        public double Tutar { get; set; }
        public string Aciklama { get; set; }
    }
}
