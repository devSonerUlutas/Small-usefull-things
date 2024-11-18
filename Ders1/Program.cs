namespace Sonercik
{

    public class Soner
    {

        static void Main(string[] args)
        {
            Run();

            //%40 vize, %60 final, %50 odev
            //90-100 AA
            //75-89 BA
            //65-74 BB
            //50-64 CB
            //35-49 CC
            //0-34 FF
        }

        static void Run()
        {
            Console.WriteLine("Program seçiniz!");

            Console.WriteLine("1 - Hesap Makinesi");
            Console.WriteLine("2 - Not Hesaplama");
            Console.WriteLine("3 - Burc ogrenme");

            string program = Console.ReadLine();
            if (program == "1")
            {
                HesapMakinesi();
            }
            else if (program == "2")
            {
                notHesaplama();
            }
            else if (program == "3")
            {
                burcOgrenme();
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız!");
            }
        }

        static void HesapMakinesi()
        {
            string devam = "1";
            Console.WriteLine("Hesap makinesi");
            Console.WriteLine("1. sayıyı giriniz: ");
            float sayi1 = float.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz: ");
            float sayi2 = float.Parse(Console.ReadLine());
            Console.WriteLine("İşlem seçiniz:+, -, *, /, ");
            string islem = Console.ReadLine();
            float sonuc = 0;

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız!");
            }
            Console.WriteLine("İşleminiz: {0} {1} {2} = {3}", sayi1, islem, sayi2, sonuc);
            Console.WriteLine("Tekrar hesap yapmak için 1'e ana menüye dönmek için 2'ye basınız. ");
            devam = Console.ReadLine();
            if (devam == "1")
            {
                HesapMakinesi();
            }
            else if (devam == "2")
            {
                Run();
            }
        }

        static void notHesaplama()
        {
            string devam;
            Console.WriteLine("Not hesaplama");
            Console.WriteLine("Vize notunuzu giriniz: ");
            byte vize = byte.Parse(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz: ");
            byte final = byte.Parse(Console.ReadLine());
            float not = (vize * 0.4f) + (final * 0.6f);

            Console.WriteLine(HarfNotu(not));
            if (not >= 0 && not <= 34)
            {
                Console.WriteLine("Ödev notunuzu giriniz: ");
                int odev = Convert.ToInt32(Console.ReadLine());
                not += (odev * 0.5f);
                Console.WriteLine(HarfNotu(not));
            }
           
            Console.WriteLine("Tekrar hesap yapmak için 1'e ana menüye dönmek için 2'ye basınız. ");
            devam = Console.ReadLine();
            if (devam == "1")
            {
                notHesaplama();
            }
            else if (devam == "2")
            {
                Run();
            }
            
        }

        static string HarfNotu(float not)
        {
            if (not >= 90 && not <= 100)
            {
                return "AA";
            }
            else if (not >= 75 && not <= 89)
            {
                return "BA";
            }
            else if (not >= 65 && not <= 74)
            {
                return "BB";
            }
            else if (not >= 50 && not <= 64)
            {
                return "CB";
            }
            else if (not >= 35 && not <= 49)
            {
                return "CC";
            }
            else if (not >= 0 && not <= 34)
            {
                return "FF";
            }
            else
            {
                return "Yanlış not girdiniz!";
            }
        }

        static void burcOgrenme()
        {
            string devam;
            Console.WriteLine("Burç öğrenme");
            Console.WriteLine("Doğduğunuz ayı sayıyla giriniz /ÖRN: Ocak için 1: ");
            byte ay = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Doğduğunuz ayın gününü giriniz :");
            byte gun = byte.Parse(Console.ReadLine());
            if (gun >= 21 && ay == 3 || gun <= 20 && ay == 4)
            {
                Console.WriteLine("Burcunuz: Koç");
            }
            else if (gun >= 21 && ay == 4 || gun <= 20 && ay == 5)
            {
                Console.WriteLine("Burcunuz : Boğa");
            }
            else if (gun >= 21 && ay == 5 || gun <= 20 && ay == 6)
            {
                Console.WriteLine("Burcunuz : İkizler");
            }
            else if (gun >= 21 && ay == 6 || gun <= 20 && ay == 7)
            {
                Console.WriteLine("Burcunuz : Yengeç");
            }
            else if (gun >= 23 && ay == 7 || gun <= 22 && ay == 8)
            {
                Console.WriteLine("Burcunuz : Aslan");
            }
            else if (gun >= 23 && ay == 8 || gun <= 22 && ay == 9)
            {
                Console.WriteLine("Burcunuz : Başak");
            }
            else if (gun >= 23 && ay == 9 || gun <= 22 && ay == 10)
            {
                Console.WriteLine("Burcunuz : Terazi");
            }
            else if (gun >= 23 && ay == 10 || gun <= 22 && ay == 11)
            {
                Console.WriteLine("Burcunuz : Akrep");
            }
            else if (gun >= 23 && ay == 11 || gun <= 21 && ay == 12)
            {
                Console.WriteLine("Burcunuz : Yay");
            }
            else if (gun >= 22 && ay == 12 || gun <= 19 && ay == 1)
            {
                Console.WriteLine("Burcunuz : Oğlak");
            }
            else if (gun >= 20 && ay == 1 || gun <= 18 && ay == 2)
            {
                Console.WriteLine("Burcunuz : Kova");
            }
            else if (gun >= 19 && ay == 2 || gun <= 20 && ay == 3)
            {
                Console.WriteLine("Burcunuz : Balık");
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız!");
            }
            Console.WriteLine("Tekrar hesap yapmak için 1'e ana menüye dönmek için 2'ye basınız. ");
            devam = Console.ReadLine();
            if (devam == "1")
            {
                burcOgrenme();
            }
            else if (devam == "2")
            {
                Run();
            }
        }

    }
}