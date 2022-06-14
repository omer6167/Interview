using Interview.Entity;

namespace Interview.DataAccess.Abstract
{
    public interface IAnalizDal
    {
        List<DtoSehirAnaliz> SehirBazliAnalizYap();
    }
}
