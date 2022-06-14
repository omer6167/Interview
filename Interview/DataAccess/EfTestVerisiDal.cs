using Interview.DataAccess.Abstract;
using Interview.Entity;

namespace Interview.DataAccess
{
    public class EfTestVerisiDal :ITestVerisiDal
    {
        private readonly string[] _sehirler = { "Ankara", "İstanbul", "İzmir", "Bursa", "Edirne", "Konya", "Antalya", "Diyarbakır", "Van", "Rize" };
        private readonly ISepetDal _sepetDal;
        private readonly IMusteriDal _musteriDal;
        private readonly ISepetUrunDal _sepetUrunDal;

        public EfTestVerisiDal(ISepetDal sepetDal, IMusteriDal musteriDal, ISepetUrunDal sepetUrunDal)
        {
            _sepetDal = sepetDal;
            _musteriDal = musteriDal;
            _sepetUrunDal = sepetUrunDal;
        }
        public void TestVerisiOlustur(int musteriAdet, int sepetAdet)
        {
            int musteriSonId = _musteriDal.GetAll().Max(m => m.Id);
            int sepetSonId= _sepetDal.GetAll().Max(s => s.Id);
            Random rand = new();
            for (int i = 0; i < musteriAdet; i++)
            {
                int rnd = rand.Next(_sehirler.Length);
                _musteriDal.Add(new Musteri
                {
                    Ad = GenerateName(),
                    Soyad = GenerateName(),
                    Sehir = _sehirler[rnd],
                });
            }
            Random rn = new();
            for (int i = 0; i < sepetAdet; i++)
            {
                _sepetDal.Add(new Sepet
                { 
                    MusteriId =  rn.Next(musteriSonId, musteriSonId+ musteriAdet)
                });
            }
            Random rn2 = new();
            for (int i = sepetSonId; i < sepetSonId + sepetAdet; i++)
            {
                for (int j = 0; j < rn2.Next(1,5); j++)
                {
                    _sepetUrunDal.Add(new SepetUrun
                    {
                        SepetId = i,
                        Aciklama = GenerateName(),
                        Tutar = rn2.Next(100, 1000)
                    });
                }
            }
        }
        private static string GenerateName()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[5];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return  new string(stringChars);
        }
    }
}
