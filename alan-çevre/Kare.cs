namespace geoHesaplama
{
    public class Kare
    {
        public static void KareHesaplama()
        {
            Console.WriteLine("Karenin bir kenarının uzunluğunu giriniz");
            int kenar = Convert.ToInt16(Console.ReadLine());
        beginUcgen:
            Console.WriteLine("Karenin alanı için 1'e, çrevresi için 2'ye basınız");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Karenin alanı : " + Math.Pow(kenar, 2));
                    break;
                case 2:
                    Console.WriteLine("Karenin çevresi : " + 4 * kenar);
                    break;
                default:
                    Console.WriteLine("hatalı tuşlama yaptınız");
                    goto beginUcgen;

            }
        }


    }
}