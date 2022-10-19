namespace geoHesaplama
{
    public static class Daire
    {
        public static void DaireHesaplama()
        {
            Console.WriteLine("Dairenin yarıçapını giriniz");
            int yaricap = Convert.ToInt16(Console.ReadLine());
        beginDaire:
            Console.WriteLine("Daireinin alanı için 1'e, çrevresi için 2'ye basınız");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Dairenin alanı : "+Math.PI * Math.Pow(yaricap,2));
                    break;
                case 2:
                    Console.WriteLine("Dairenin çevresi : "+2 * Math.PI * yaricap);
                    break;
                default:
                    Console.WriteLine("hatalı tuşlama yaptınız");
                    goto beginDaire;


            }

        }


    }
}