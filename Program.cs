using System;

namespace ConsoleApp1
{
    class Program
    {
        public static bool devam = true;
        static void Main(string[] args)
        {
            // Değişkenleri Tanımlama
            int bakiye = 100;

            Console.WriteLine("Emre Bank Hoşgeldiniz.");
            while (devam)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi sadece rakam olacak şekilde tuşlayınız:");
                Console.WriteLine("1- Bakiye Sorgulama");
                Console.WriteLine("2- Para Çekme");
                Console.WriteLine("3- Para Yatırma");
                bool succsess = Int32.TryParse(Console.ReadLine(), out int islem);
                if (succsess) // Int olup olmadığını sorgulama
                {
                    if (islem == 1) //Bakiye Sorgu
                    {
                        Console.WriteLine(bakiye + "TL");
                        DevamMi();
                    }
                    else if (islem == 2) // Para çekme
                    {
                        bool devamCekme = true;
                        while (devamCekme)
                        {
                            Console.WriteLine("Çekmek istediğiniz tutarı sadece rakam olarak giriniz:");
                            bool succuessCekme = Int32.TryParse(Console.ReadLine(), out int cekme);
                            if (succuessCekme)
                            {
                                devamCekme = false;
                                if (bakiye >= cekme)
                                {
                                    bakiye = bakiye - cekme;
                                    Console.WriteLine("İşlem başarı ile gerçekleşti");
                                    Console.WriteLine("Yeni bakiyeniz: " + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli bakiye bulunmuyor!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sadece rakam girişi yapınız.");
                                devamCekme = true;
                            }
                        }
                        DevamMi();
                    }
                    else if (islem == 3) // Para Yatırma
                    {
                        bool devamCekme = true;
                        while (devamCekme)
                        {
                            Console.WriteLine("Yatırmak istediğiniz tutarı sadece rakam olarak giriniz:");
                            bool succuessCekme = Int32.TryParse(Console.ReadLine(), out int cekme);
                            if (succuessCekme)
                            {
                                devamCekme = false;

                                bakiye = bakiye + cekme;
                                Console.WriteLine("İşlem başarı ile gerçekleşti");
                                Console.WriteLine("Yeni bakiyeniz: " + bakiye);
                            }
                            else
                            {
                                Console.WriteLine("Sadece rakam girişi yapınız.");
                                devamCekme = true;
                            }
                        }
                        DevamMi();
                    }
                    else // Geçersiz işlem
                    {
                        Console.WriteLine("Geçerli bir rakam girişi yapınız!");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sadece rakam girişi yapınız!");
                }
            }
            Console.WriteLine("Görüşmek üzere...");
        }

        static void DevamMi()
        {
            bool ynCheck = true;
            while (ynCheck)
            {
                Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? Y/N");
                String another = Console.ReadLine();
                if (another == "Y" || another == "y" || another == "N" || another == "n")
                {
                    ynCheck = false;
                }
                else
                {
                    ynCheck = true;
                }
                if (another == "Y" || another == "y")
                {
                    devam = true;
                }
                else if (another == "N" || another == "n")
                {
                    devam = false;
                }
            }
        }
    }
}
