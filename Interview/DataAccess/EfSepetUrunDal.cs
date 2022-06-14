using Interview.DataAccess.Abstract;
using Interview.DataAccess.Core;
using Interview.Entity;

namespace Interview.DataAccess
{
    public class EfSepetUrunDal : EfEntityRepositoryBase<SepetUrun, Context>, ISepetUrunDal
    {
        public List<ReportByTotalAmountDto> GetToplamSatis()
        {


            return new List<ReportByTotalAmountDto>();
        }

    }
}
