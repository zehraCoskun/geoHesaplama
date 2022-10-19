namespace geoHesaplama
{

    public class Kure
    {
        public double KureHesaplama()
        {
            Console.WriteLine("Kürenin yarıçapını giriniz : ");
            double yaricap = Convert.ToDouble(Console.ReadLine());
            return Math.Pow(yaricap,3)*3/4;
            
        }
    }

}