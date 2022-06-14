using System.ComponentModel.DataAnnotations;

namespace Interview.Entity
{
    public class Musteri
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        
    }
}
