using Interview.Business.Abstract;
using Interview.DataAccess.Abstract;

namespace Interview.Business
{
    public class TestVeriManager :ITestVeriService
    {
        private ITestVerisiDal _testVerisiDal;

        public TestVeriManager(ITestVerisiDal testVerisiDal)
        {
            _testVerisiDal = testVerisiDal;
        }

        public void TestVerisiOlustur(int musteriAdet, int sepetAdet)
        {
            _testVerisiDal.TestVerisiOlustur(musteriAdet,sepetAdet);
        }
    }
}
