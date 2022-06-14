using Interview.Business.Abstract;
using Interview.DataAccess;
using Interview.DataAccess.Abstract;
using Interview.Entity;

namespace Interview.Business
{
    public class SepetManager : ISepetService
    {
        //private EfSepetDal _efSepetDal;
        private ISepetDal _sepetDal;

        public SepetManager(ISepetDal sepetDal)
        {
            _sepetDal = sepetDal;
        }

        public List<Sepet> GetAll()
        {
            return _sepetDal.GetAll();
        }

     

        public Sepet GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Sepet entity)
        {
            _sepetDal.Add(entity);
        }

        public void Update(Sepet entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sepet entity)
        {
            throw new NotImplementedException();
        }
    }
}
