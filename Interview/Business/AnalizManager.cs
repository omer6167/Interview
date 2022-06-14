using Interview.Business.Abstract;
using Interview.DataAccess.Abstract;
using Interview.Entity;

namespace Interview.Business
{
    public class AnalizManager : IAnalizService
    {
        private IAnalizDal _analizDal;

        public AnalizManager(IAnalizDal analizService)
        {
            _analizDal = analizService;
        }

        public List<DtoSehirAnaliz> SehirBazliAnalizYap()
        {
          return _analizDal.SehirBazliAnalizYap();
        }
    }
}
