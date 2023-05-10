namespace Metotlar
{
    internal class Program
    {
           //Tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
           //Don't repeat yourself - DRY (Kendini tekrar etme).

        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip guvenli
            foreach (Urun urun in urunler )
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }

            Console.WriteLine("--------------Metotlar-----------");
            
            SepetManager sepetManager= new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);

        }
    }
}