using Interview.DataAccess.Abstract;
using Interview.DataAccess.Core;
using Interview.Entity;

namespace Interview.DataAccess
{
    public class EfSepetDal : EfEntityRepositoryBase<Sepet, Context>, ISepetDal

    {
    }
}
