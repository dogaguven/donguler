using System;

namespace ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Kategori = "Kazak";
            product1.UrunAdi = "Mavi Yün Kazak";
            product1.UrunBedeni = "M";
            product1.StokAdedi = 24;

            Product product2 = new Product();
            product2.Kategori = "Sweatshirt";
            product2.UrunAdi = "Baskılı Siyah Sweatshirt";
            product2.UrunBedeni = "L";
            product2.StokAdedi = 15;

            Product product3 = new Product();
            product3.Kategori = "Hırka";
            product3.UrunAdi = "Peluş Hırka";
            product3.UrunBedeni = "S";
            product3.StokAdedi = 9;

            Product product4 = new Product();
            product4.Kategori = "Kazak";
            product4.UrunAdi = "Baskılı Beyaz Kazak";
            product4.UrunBedeni = "S";
            product4.StokAdedi = 13;

            Product[] product = new Product[] { product1, product2, product3, product4 };

            Console.WriteLine("For Döngüsü");
            for (int i = 0; i < product.Length; i++)
            { 
                Console.WriteLine("Kategori:" + product[i].Kategori + "Ürün:" + product[i].UrunAdi + "Bedeni" + product[i].UrunBedeni);

            }

            Console.WriteLine("Foreach döngüsü:");
            foreach (var Urun in product)
            {
                Console.WriteLine(Urun.Kategori + ":" + Urun.UrunAdi + ":" + Urun.UrunBedeni);
            }
            Console.WriteLine("While Döngüsü");
            int urun = 0;
            while (urun < product.Length)
            {
                Console.WriteLine("Kategori:" + product[urun].Kategori + "Ürün:" + product[urun].UrunAdi + "Bedeni" + product[urun].UrunBedeni);
                urun++;
            }

        }
    }
}
