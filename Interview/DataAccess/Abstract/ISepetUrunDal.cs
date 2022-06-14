using Interview.Entity;

namespace Interview.DataAccess.Abstract
{
    public interface ISepetUrunDal : IEntityRepository<SepetUrun>
    {
        List<ReportByTotalAmountDto> GetToplamSatis();
    }
}
