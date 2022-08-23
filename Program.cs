using System;

namespace ConsoleCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel C# alıştırmaları (20 adet)
            #region 1 - Sabit vs. input değerler | 4 işlem
            //int x = 2, y = 5, z = 10;
            //Console.WriteLine($"X sayısı: {x}\nY sayısı: {y}\nZ sayısı: {z}\n");
            //int top = x + y + z;

            //Console.Write("1.Sayı: ");
            //int s1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sayı: ");
            //int s2 = int.Parse(Console.ReadLine());
            //int s3 = s1 * s2;

            //int fark = s3 - top;
            //Console.WriteLine($"\nBelirlediğiniz 2 sayının çarpımı {s3}.\nX,Y ve Z sayılarının toplamı ise {top}.\nBelirlediğiniz 2 sayının çarpımının; X,Y ve Z sayılarının toplamı ile arasındaki fark {fark}.");

            #endregion
            #region 2 - Tek mi Çift mi? | if-else if-else

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int s1 = int.Parse(Console.ReadLine());

            //if (s1 == 0)
            //{
            //    Console.WriteLine("\nGirdiğiniz sayı sıfırdır.");
            //}
            //else if (s1 % 2 == 0)
            //    Console.WriteLine("\nGirdiğiniz sayı çifttir.");
            //else
            //    Console.WriteLine("\nGirdiğiniz sayı tektir.");
            #endregion
            #region 3 - Basit mod alma işlemi | 4 işlem 

            //int x = 2, y = 5, z = 10;
            //int toplam = x + y + z;
            //int mod3 = toplam % 3;
            //Console.WriteLine(mod3);

            #endregion
            #region 4 - Üslü sayılar | Math

            //double x = 2, y = 5, z = 10;
            //double üsyx = Math.Pow(y, x);

            //Console.WriteLine(üsyx);


            #endregion
            #region 5 - Hangi sayı büyüktür? | if-else if-else

            //Console.Write("1. Sayıyı giriniz:");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı giriniz:");
            //int b = int.Parse(Console.ReadLine());

            //if (a > b)
            //{
            //    Console.WriteLine($"{a} sayısı {b} sayısından büyüktür.");
            //}
            //else if (b > a)
            //{
            //    Console.WriteLine($"{b} sayısı {a} sayısından büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine($"Girdiğiniz sayılar eşittir.");
            //}
            #endregion
            #region 6 - Kullanıcı Girişi | if-else if-else

            //string id = "123";
            //string pw = "123";
            //Console.Write("Lütfen Kullanıcı Adınızı Giriniz: ");
            //string idd = Console.ReadLine();
            //Console.Write("Lütfen şifrenizi Giriniz: ");
            //string pww = Console.ReadLine();

            //if ((id == idd) && (pw == pww))
            //{
            //    Console.WriteLine("Kullanıcı adı ve şifreniz doğru. Giriş başarılı!");
            //}
            //else if ((id == idd) && (pw != pww))
            //{
            //    Console.WriteLine("Şifreniz hatalı. Lütfen tekrar deneyin!");
            //}
            //else if ((id != idd) && (pw == pww))
            //{
            //    Console.WriteLine("Kullanıcı adınız hatalı. Lütfen tekrar deneyin!");
            //}
            //else if ((id != idd) && (pw != pww))
            //{
            //    Console.WriteLine("Kullanıcı adınız ve şifreniz hatalı. Lütfen tekrar deneyin!");
            //}


            #endregion
            #region 7 - Sayı pozitif/negatif&&Tek/çift | Karşılaştırma Operatörleri

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a > 0 && a % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı pozitif bir çift sayıdır.");
            //}
            //else if (a > 0 && a % 2 != 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı pozitif bir tek sayıdır.");
            //}
            //else if (a < 0 && a % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı negatif bir çift sayıdır.");
            //}
            //else if (a < 0 && a % 2 != 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı negatif bir tek sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı sıfırdır.");
            //}

            #endregion
            #region 8 - 3 input sayının büyükten küçüğe sıralaması | Karşılaştırma Operatörleri

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sayıyı giriniz: ");
            //int c = int.Parse(Console.ReadLine());

            //if (a>b&&a>c)
            //{
            //    if (b>c)
            //    {
            //        Console.WriteLine($"{a} > {b} > {c}");
            //    }
            //    else if (b==c)
            //    {
            //        Console.WriteLine($"{a} > {b} = {c}");
            //    }
            //    else if (c>b)
            //    {
            //        Console.WriteLine($"{a} > {c} > {b}"); 
            //    }
            //}
            //else if (b>a&&b>c)
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine($"{b} > {a} > {c}");
            //    }
            //    else if (a == c)
            //    {
            //        Console.WriteLine($"{b} > {a} = {c}");
            //    }
            //    else if (c > a)
            //    {
            //        Console.WriteLine($"{b} > {c} > {a}"); 
            //    }
            //}
            //else if (c>b&&c>a)
            //{
            //    if (b > a)
            //    {
            //        Console.WriteLine($"{c} > {b} > {a}"); 
            //    }
            //    else if (b == a)
            //    {
            //        Console.WriteLine($"{ c} > { b} = { a}");
            //    }
            //    else if (a > b)
            //    {
            //        Console.WriteLine($"{c} > {a} > {b}");
            //    }
            //}
            //else if (a==b&&a>c)
            //{
            //    Console.WriteLine($"{a} = {b} > {c}");
            //}
            //else if (a==c&&a>b)
            //{
            //    Console.WriteLine($"{a} = {c} > {b}"); 
            //}
            //else if (b==c&&b>a)
            //{
            //    Console.WriteLine($"{b} = {c} > {a}"); 
            //}
            //else
            //{
            //    Console.WriteLine("Tüm sayılar eşittir.");
            //}
            #endregion
            #region 9 - Dersten geçti/kaldı | Karşılaştırma Operatörleri

            //Console.Write("1. Vize notunuzu giriniz: ");
            //double vize1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Vize notunuzu giriniz: ");
            //double vize2 = int.Parse(Console.ReadLine());
            //Console.Write("Final notunuzu giriniz: ");
            //double final = int.Parse(Console.ReadLine());

            //double ort = (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);

            //if (final >= 70 || (final >= 50 && ort >= 50))
            //{
            //    Console.WriteLine($"Dersi geçtiniz. Ortalamanız: {ort}.");
            //}
            //else if ((final >= 50 && ort < 50) || (final < 50))
            //{
            //    Console.WriteLine($"Dersi geçemediniz. Ortalamanız: {ort}.");
            //}

            #endregion
            #region 10 - Vücut Kitle İndeksi | Karşılaştırma Operatörleri

            //Console.Write("Lütfen adınızı giriniz: ");
            //string isim = Console.ReadLine();
            //Console.Write("Lütfen boyunuzu (Metre cinsinden, virgül kullanarak) giriniz: ");
            //double boy = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Lütfen kilonuzu giriniz: ");
            //double kilo = Convert.ToDouble(Console.ReadLine());

            //double vki = kilo / (boy * boy);

            //if (vki > 0 && vki < 18.5)
            //{
            //    Console.WriteLine($"Sevgili {isim}, Vücut Kitle İndeksin; {vki}. Yani zayıfsın :')");
            //}
            //else if (vki > 18.4 && vki < 25)
            //{
            //    Console.WriteLine($"Sevgili {isim}, Vücut Kitle İndeksin; {vki}. Yani normalsin ;)");
            //}
            //else if (vki > 24.9 && vki < 30)
            //{
            //    Console.WriteLine($"Sevgili {isim}, Vücut Kitle İndeksin; {vki}. Yani fazla kilolusun :(");
            //}
            //else
            //{
            //    Console.WriteLine($"Sevgili {isim}, Vücut Kitle İndeksin; {vki}. Yani obezsin :'(");
            //}
            #endregion
            #region 11 - Ehliyet alabilir mi? | Karşılaştırma Operatörleri

            //Console.Write("İsminizi giriniz: ");
            //string isim = Console.ReadLine();
            //Console.Write("Yaşınızı giriniz: ");
            //int yas = int.Parse(Console.ReadLine());

            //if (yas >= 18)
            //{
            //    Console.Write("Eğitim durumunuzu giriniz(Lise/Üniversite): ");
            //    string egitim = Console.ReadLine();
            //    egitim = egitim.ToLower();

            //    if (egitim=="üniversite" || egitim == "lise")
            //    {
            //        Console.WriteLine($"Sayın {isim} Ehliyet alabilirsiniz.");
            //    }
            //    else
            //        Console.WriteLine($"Sayın {isim} Eğitim durumunuz yetersiz olduğu için ehliyet alamazsınız!");
            //}
            //else
            //    Console.WriteLine($"Sayın {isim} Yaşınız 18'in altında olduğu için ehliyet alamazsınız!");


            #endregion
            #region 12 - Karne notu ve ortalama hesaplama | Karşılaştırma Operatörleri 

            //Console.Write("1. sınav sonucunuzu giriniz: ");
            //double s1 = double.Parse(Console.ReadLine());
            //Console.Write("2. sınav sonucunuzu giriniz: ");
            //double s2 = double.Parse(Console.ReadLine());
            //Console.Write("Sözlü notunuzu giriniz: ");
            //double sozlu = double.Parse(Console.ReadLine());

            //double ort = (s1 + s2 + sozlu) / 3;

            //if (ort >= 85)
            //    Console.WriteLine($"Not bilginiz {ort} ortalama puan ile 5'tir!");
            //else if (ort >= 70)
            //    Console.WriteLine($"Not bilginiz {ort} ortalama puan ile 4'tür!");
            //else if (ort >= 55)
            //    Console.WriteLine($"Not bilginiz {ort} ortalama puan ile 3'tür!");
            //else if (ort >= 45)
            //    Console.WriteLine($"Not bilginiz {ort} ortalama puan ile 2'dir!");
            //else if (ort >= 25)
            //    Console.WriteLine($"Not bilginiz {ort} ortalama puan ile 1'dir!");
            //else
            //{
            //    Console.WriteLine($"Not bilginiz {ort} ortalama puan ile 0'dır!");
            //}

            #endregion
            #region 13 - Aracımın bakım tarihi geldi mi? | Karşılaştırma Operatörleri && DateTime

            //Console.WriteLine("Aracınızın trafiğe çıkış tarihini GÜN/AY/YIL biçiminde giriniz: ");
            //string cikis = Console.ReadLine();
            //DateTime baslangic = Convert.ToDateTime(cikis);
            //DateTime now = DateTime.Now;
            //TimeSpan fark = now - baslangic;
            //double farkGun = fark.TotalDays;

            //if (farkGun >= (365 * 3))
            //    Console.WriteLine("Aracınızın 3. bakım süresi gelmiştir.");
            //else if (farkGun >= (365 * 2))
            //    Console.WriteLine("Aracınızın 2. bakım süresi gelmiştir.");
            //else if (farkGun >=(365))
            //    Console.WriteLine("Aracınızın 1. bakım süresi gelmiştir.");
            //else
            //    Console.WriteLine("Aracınızın bakım süresi henüz gelmemiştir.");
            #endregion
            #region 14 - İnput'a göre sayı sayma | For Döngüsü

            //Console.Write("Başlangıç sayısını gir: ");
            //int bas = int.Parse(Console.ReadLine());
            //Console.Write("Bitiş sayısını gir: ");
            //int bit = int.Parse(Console.ReadLine());
            //Console.Write("Artış miktarını gir: ");
            //int art = int.Parse(Console.ReadLine());

            //for (int i = bas; i <= bit;)
            //{
            //    Console.WriteLine(i);
            //    i = i + art;
            //}

            #endregion
            #region 15 - Dizi elemanlarının modunu alma | For Döngüsü && Diziler

            //int[] sayilar = { 1, 3, 5, 6, 7, 23, 67, 90, 120 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 3 == 0)
            //    {
            //        Console.WriteLine($"Sayılar dizisinde yer alan {sayilar[i]} sayısı 3'ün katıdır.");
            //    }
            //}
            #endregion
            #region 16 - Dizi elemanlarını toplama |For Döngüsü && Diziler
            //int[] sayilar = { 1, 3, 5, 6, 7, 23, 67, 90, 120 };
            //int toplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    toplam = sayilar[i] + toplam;
            //}
            //Console.WriteLine(toplam);

            #endregion
            #region 17 - Dizi elemanlarının Mod'una göre üssünü hesaplatma | For Döngüsü && Diziler && Math
            //int[] sayilar = { 1, 3, 5, 6, 7, 23, 67, 90, 120 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 != 0)
            //    {
            //        Console.WriteLine(Math.Pow(sayilar[i], 2));
            //    }
            //}
            #endregion
            #region 18 - Dizi elemanlarının harf sayısına göre ekrana yazdırılması | For dönsüsü && Diziler && if-else if-else
            //string[] arabalar = { "Opel", "Mazda", "Toyota", "Bmw", "Mercedes" };
            //for (int i = 0; i < arabalar.Length; i++)
            //{
            //    if (arabalar[i].Length >= 5)
            //    {
            //        Console.WriteLine(arabalar[i]);
            //    }
            //}
            #endregion
            #region 19 - İnput'a göre asal sayı bulma | if-else if-else
            //Console.WriteLine("Bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //bool asalmi = true;
            //if (sayi == 1)
            //    Console.WriteLine("1 asal bir sayı değildir.");
            //else
            //{
            //    for (int i = 2; i < sayi; i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            asalmi = false;
            //            break;
            //        }
            //    }
            //    if (asalmi)
            //        Console.WriteLine("Sayı asaldır.");
            //    else
            //        Console.WriteLine("Sayı asal değildir.");
            //}


            #endregion
            #region 20 - Şakamatik_FotograflardaNedenCirkinCikiyorsun? | Do-While Döngüsü && if-else if-else

            //string cevap = "";
            //string devamMi = "";


            //do
            //{
            //    Console.WriteLine("Fotoğraflarda neden çirkin çıkıyorsun?\n");
            //    Console.WriteLine("Arkadaşın fotoğraf çekmeyi biliyor mu?\nA) EVET\nB) HAYIR");
            //    cevap = Console.ReadLine();
            //    cevap = cevap.ToUpper();

            //    if (cevap == "A" || cevap == "EVET")
            //    {
            //        Console.WriteLine("\nÇirkin olduğun için :(\nTekrar denemek için X'e, Çıkmak için herhangi bir tuşa bas.");
            //    }
            //    else if (cevap == "B" || cevap == "HAYIR")
            //    {
            //        Console.WriteLine("\nArkadaşın iyi fotoğraf çekemediği için olabilir.\nİyi fotoğraf çeken bir arkadaş bul ve umudunu kaybetme.\nBelkide gerçekten çirkinsindir.\nTekrar denemek için X'e, Çıkmak için herhangi bir tuşa bas.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nHatalı bilgi çocuğum.\nTekrar denemek için X'e, Çıkmak için herhangi bir tuşa bas.");
            //    }
            //    devamMi = Console.ReadLine();
            //    devamMi = devamMi.ToUpper();

            //} while (devamMi == "X");

            #endregion
            #region 21 - 28'den 29 Yaşına Girerken Yazılan Mini Kod

            //Console.WriteLine("Merhaba şuan 28 yaşındayım\nBu kodu yazarken 29'a girmiş olacağım\n\nLet the party begin!!!");
            //int sonuc = 0;

            //do
            //{                            
            //    Console.WriteLine("\nBugün ne yapmak istersin?\n\n1-Eğlenmek ;D\n2-Yalnız kalmak :'(\n0-Uygulamadan çıkmak istiyorum :*");
            //    sonuc = Convert.ToInt32(Console.ReadLine());
            //    if (sonuc == 1)
            //    {
            //        Console.WriteLine("İyi eğlenceler dostum! Doğum günün kutlu olsun!");
            //    }
            //    else if (sonuc == 2)
            //    {
            //        Console.WriteLine("Seni seviyorum dostum! Doğum günün kutlu olsun!");
            //    }
            //} while (sonuc == 1 || sonuc==2);

            #endregion
            #endregion

            #region OOP_Arabalar
            //Console.Write("Lütfen kaydedeceğiniz araç sayısını giriniz: ");
            //int adet = int.Parse(Console.ReadLine());

            //Araba[] arabalar = new Araba[adet];

            //int i = 0;
            //Araba araba;

            //do
            //{
            //    araba = new Araba();

            //    Console.Write($"{i + 1}.Araç Markası: ");
            //    araba.Marka = Console.ReadLine();

            //    Console.Write($"{i + 1}.Araç Modeli: ");
            //    araba.Model = Console.ReadLine();

            //    Console.Write($"{i + 1}.Araç Rengi: ");
            //    araba.Renk = Console.ReadLine();

            //    Console.Write($"{i + 1}.Araç Ağırlığı: ");
            //    araba.Agirlik = int.Parse(Console.ReadLine());

            //    Console.WriteLine("");
            //    arabalar[i] = araba;
            //    i++;

            //} while (adet > i);

            //foreach (var cars in arabalar)
            //{
            //    Console.WriteLine($"Araç Markası: {cars.Marka} Araç Modeli: {cars.Model} Araç Rengi: {cars.Renk} Araç Ağırlığı: {cars.Agirlik} kg.");
            //}
            #endregion
            #region OOP_sehirler
            //Console.Write("Kaydetmek istediğin şehir sayısını gir: ");
            //int adet = int.Parse(Console.ReadLine());

            //sehirler[] sehir = new sehirler[adet];
            //int i = 0;
            //sehirler city;

            //do
            //{
            //    city = new sehirler();

            //    Console.Write("Ülke giriniz: ");
            //    city.ulke = Console.ReadLine();

            //    Console.Write("Şehir giriniz: ");
            //    city.sehir = Console.ReadLine();

            //    sehir[i] = city;
            //    i++;
            //} while (adet>i);

            //foreach (var item in sehir)
            //{
            //    Console.WriteLine($"Ülke: {item.ulke} Şehir: {item.sehir}");
            //}

            #endregion

        }
    }
    #region OOP_Arabalar
    //class Araba
    //{
    //    public string Marka { get; set; }
    //    public string Model { get; set; }
    //    public string Renk { get; set; }
    //    public int Agirlik { get; set; }
    //}
    #endregion
    #region OOP_sehirler
    //class sehirler
    //{
    //    public string ulke { get; set; }
    //    public string sehir { get; set; }
    //}

    #endregion
}
