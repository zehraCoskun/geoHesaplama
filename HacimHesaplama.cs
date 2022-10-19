namespace geoHesaplama
{
    public class HacimHesaplama
    {
        public static void HacimHesaplamalari()
        {
            begin:
            Console.WriteLine("");
            Console.WriteLine("Hangi geometrik şeklin hacmini hesaplamak istersiniz?");
            Console.WriteLine("     1* Küre");
            Console.WriteLine("     2* Prizma");
            Console.WriteLine("     3* Küp");
            Console.WriteLine("     ***");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Kure kure = new Kure();
                    Console.WriteLine(kure.KureHesaplama());
                    break;

                case "2":
                    Prizma prizma = new Prizma();
                    Console.WriteLine(prizma.PrizmaHesaplama());
                    break;

                case "3":
                    Kup kup = new Kup();
                    Console.WriteLine(kup.KupHesaplama());
                    break;

                default:
                    Console.WriteLine("hatalı tuşlama yaptınız,tekrar deneyiniz");
                    goto begin;

            }
            goto begin;
        
        }
    }
}