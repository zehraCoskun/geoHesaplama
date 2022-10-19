namespace geoHesaplama
{
    public class Prizma
    {
        public double PrizmaHesaplama()
        {
            Console.WriteLine("Taban alanını giriniz");
            double alan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("prizmanın yüksekliğini giriniz");
            double yukseklik = Convert.ToDouble(Console.ReadLine());
            return alan*yukseklik;
        }
    }
}