using Interview.DataAccess.Abstract;
using Interview.DataAccess.Core;
using Interview.Entity;

namespace Interview.DataAccess
{
    public class EfSepetUrunDal : EfEntityRepositoryBase<SepetUrun, Context>, ISepetUrunDal
    {
        public List<ReportByTotalAmountDto> GetToplamSatis()
        {

            using var context = new Context();
            var result = from sepetUrun in context.SepetUruns
                         join sepet in context.Sepets
                             on sepetUrun.SepetId equals sepet.Id
                         join musteri in context.Musteris
                             on sepet.MusteriId equals musteri.Id
                         select new { musteri.Id, musteri.Ad, sepetUrun.Tutar } into x
                         group x by new { x.Id, x.Ad } into musteriGroup
                         select new ReportByTotalAmountDto
                         {
                             MusteriAdi = musteriGroup.Key.Ad,
                             SepetAdeti = musteriGroup.Count(),
                             ToplamTutar = musteriGroup.Sum(musteri => musteri.Tutar)
                         } into reportByTotalAmountDto
                         orderby reportByTotalAmountDto.ToplamTutar descending, reportByTotalAmountDto.SepetAdeti 
                         select reportByTotalAmountDto;
            return result.ToList();
        }

    }
}
