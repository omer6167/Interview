using Interview.Business.Abstract;
using Interview.DataAccess;
using Interview.DataAccess.Abstract;
using Interview.Entity;

namespace Interview.Business
{
    public class MusteriManager : IMusteriService
    {
        //private EfMusteriDal _efMusteriDal;
        private IMusteriDal _musteriDal;

       public MusteriManager(IMusteriDal musteriDal)
       {
           _musteriDal = musteriDal;
       }

       public List<Musteri> GetAll()
        {
          return _musteriDal.GetAll();
        }

        public Musteri GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Musteri entity)
        {
            _musteriDal.Add(entity);
        }

        public void Update(Musteri entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Musteri entity)
        {
            throw new NotImplementedException();
        }
    }
}
