/*C# Console uygulaması oluşturarak aşağıdaki gereksinimleri karşılayan uygulamayı yazınız.

İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı (Daire, Üçgen, Kare, Dikdörtgen vb..)
Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
Hesaplanmak istenen boyutu kullanıcıdan alınmalı (Çevre, Alan, Hacim vb..)
Hesap sonucunu anlaşılır şekilde geri döndürmeli.*/
namespace geoHesaplama
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("kaç boyutlu geometrik şekil ile işlem yapacaksınız?");
            int select= Convert.ToInt16(Console.ReadLine());
            switch(select)
            {
                case 2:
                AlanHesaplama.AlanHesaplamalari();
                break;

                case 3:
                HacimHesaplama.HacimHesaplamalari();
                break;

            }

        }
    }
}