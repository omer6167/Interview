using Interview.Entity;

namespace Interview.Business.Abstract
{
    public interface ISepetUrunService : IServiceRepository<SepetUrun>
    {
        List<ReportByTotalAmountDto> GetToplamSatis();
    }
}
