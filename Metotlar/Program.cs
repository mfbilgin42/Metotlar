using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1,product2};
            //type-safe (tip güvenli)
            foreach (var product in products)
            {
                //Console.WritLine / Print / Println gibi ekrana/konsola yazdırma kodlarını sadece programcı kendi komutlarını hızlıca ekrana çıktı almak için kullanır. 
                Console.WriteLine("Ürün Adı : "+product.Name);
                Console.WriteLine("Ürün Fiyatı : "+product.Price);
                Console.WriteLine("Ürün Açıklaması : " + product.Explanation);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("------------Metotlar------------");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);

            //Hatalı işlemi uygulayalım.
            sepetManager.Add2("Elma", "Amasya Elması", 15);
        }
    }
}

//Dont repeat yourself(DRY - Kenidi tekrar etme) - Clean Code(Temiz Kod) - Best Practice(En iyi uygulama biçimi)
