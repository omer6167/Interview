using Interview.Business.Abstract;
using Interview.DataAccess;
using Interview.DataAccess.Abstract;
using Interview.Entity;

namespace Interview.Business
{
    public class SepetUrunManager : ISepetUrunService
    {
        //private EfSepetUrunDal _efSepetUrunDal;
        private ISepetUrunDal _sepetUrunDal;

        public SepetUrunManager(ISepetUrunDal sepetUrunDal)
        {
            _sepetUrunDal = sepetUrunDal;
        }

        public List<SepetUrun> GetAll()
        {
            return _sepetUrunDal.GetAll();
        }

        public SepetUrun GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(SepetUrun entity)
        {
            _sepetUrunDal.Add(entity);
        }

        public void Update(SepetUrun entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SepetUrun entity)
        {
            throw new NotImplementedException();
        }

        public List<ReportByTotalAmountDto> GetToplamSatis()
        {
            return _sepetUrunDal.GetToplamSatis();
        }
    }
}
