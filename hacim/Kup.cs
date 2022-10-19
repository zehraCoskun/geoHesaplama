namespace geoHesaplama
{
    public class Kup
    {
        public double KupHesaplama()
        {
            Console.WriteLine("Bir kenarın uzunlluğunu giriniz");
            double kenar = Convert.ToDouble(Console.ReadLine());
            return Math.Pow(kenar, 3);
        }
    }
}