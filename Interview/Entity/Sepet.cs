using System.ComponentModel.DataAnnotations;

namespace Interview.Entity
{
    public class Sepet
    {
        [Key]
        public int Id { get; set; }
        public int MusteriId { get; set; }
    }
}
