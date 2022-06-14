using Interview.DataAccess.Abstract;
using Interview.Entity;

namespace Interview.DataAccess
{
    public class EfAnalizDal :IAnalizDal
    {
        
        public List<DtoSehirAnaliz> SehirBazliAnalizYap()
        {
            using var context = new Context();
            var result =
                from sepetUrun in context.SepetUruns
                join sepet in context.Sepets
                    on sepetUrun.SepetId equals sepet.Id
                join musteri in context.Musteris
                    on sepet.MusteriId equals musteri.Id
                select new { musteri.Sehir, sepetUrun.Tutar }
                into x
                group x by new { x.Sehir }
                into sehirGroup
                select new DtoSehirAnaliz()
                {
                    SehirAdi = sehirGroup.Key.Sehir,
                    SepetAdet = sehirGroup.Count(),
                    ToplamTutar = sehirGroup.Sum(musteri => musteri.Tutar)
                }
                into sehirBazliAnalizDto
                orderby sehirBazliAnalizDto.SepetAdet descending, sehirBazliAnalizDto.ToplamTutar
                select sehirBazliAnalizDto;


            return result.ToList();
            
        }
    }
}
