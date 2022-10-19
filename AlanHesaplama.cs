namespace geoHesaplama
{
    public class AlanHesaplama
    {
        public static void AlanHesaplamalari()
        {
        begin:
            Console.WriteLine("Hangi geometrik şekil ile işlem yapmak istersiniz?");
            Console.WriteLine("1* Daire");
            Console.WriteLine("2* Üçgen");
            Console.WriteLine("3* Kare");
            Console.WriteLine("    ***");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Daire.DaireHesaplama();
                    break;

                case "2":
                    Console.WriteLine("Hesapalama yapmak istediğiniz üçgen eşkenar üçgen mi?");
                    string ucgenSecimi = Console.ReadLine();
                    if (ucgenSecimi == "evet")
                    {
                        Ucgen.EskenarUcgenHesaplama();
                    }
                    else if (ucgenSecimi == "hayır")
                    {
                        Ucgen.CesitkenarUcgenHesaplama();
                    }
                    else
                    {
                        Console.WriteLine("hatalı tuşlama yaptınız,tekrar deneyiniz");
                        goto begin;
                    }
                    break;

                case "3":
                    Kare.KareHesaplama();
                    break;

                default:
                    Console.WriteLine("hatalı tuşlama yaptınız,tekrar deneyiniz");
                    goto begin;

            }
            goto begin;
        }
    }
}