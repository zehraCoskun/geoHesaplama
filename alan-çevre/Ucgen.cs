namespace geoHesaplama
{
    public class Ucgen
    {
        public static void EskenarUcgenHesaplama()
        {
            Console.WriteLine("Eşkenar üçgenin bir kenarının uzunluğunu giriniz");
            int kenar = Convert.ToInt16(Console.ReadLine());
        beginUcgen:
            Console.WriteLine("Üçgenin alanı için 1'e, çrevresi için 2'ye basınız");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Üçgenin yaklaşık alanı : " + Math.Pow(kenar,2) * Math.PI / 4);
                    break;
                case 2:
                    Console.WriteLine("Üçgenin çevresi : " + 3 * kenar);
                    break;
                default:
                    Console.WriteLine("hatalı tuşlama yaptınız");
                    goto beginUcgen;


            }
        }
        public static void CesitkenarUcgenHesaplama()
        {

            Console.WriteLine("Üçgenin bir kenarının uzunluğunu giriniz");
            int kenar = Convert.ToInt16(Console.ReadLine());
        beginUcgen:
            Console.WriteLine("Üçgenin alanı için 1'e, çrevresi için 2'ye basınız");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Üçgenininiz yükseklik değerini giriniz");
                    int yukseklik = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Üçgenin yaklaşık alanı : " + yukseklik * kenar / 2);
                    break;
                case 2:
                    Console.WriteLine("Üçgenin çevresi : " + 3 * kenar);
                    break;
                default:
                    Console.WriteLine("hatalı tuşlama yaptınız");
                    goto beginUcgen;


            }

        }
    }

}