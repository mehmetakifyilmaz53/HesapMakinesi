
using System;
using System.Threading;
Console.WriteLine("*****Hesap Makinesi*****\n\nİşlemler\n1.En büyük ve En küçük sayıyı bulma\n2.Ortalama Hesaplama\n3.Faktöriel Hesaplama\nÇıkmak için 'q' tuşuna basınız");

while (true)
{
    
    Console.WriteLine("\nYapmak İstediğiniz işlemi seçiniz");
    string secim = Convert.ToString(Console.ReadLine());
    if (secim == "1")
    {
        int enbuyuk = 0, enkucuk = 0;

        int yenisayı;

        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Yeni sayıyı Giriniz");
            yenisayı = Convert.ToInt32(Console.ReadLine());

            if (i == 1)
            {
                enbuyuk = yenisayı;
                enkucuk = yenisayı;
            }
            if (yenisayı > enbuyuk)
            {
                enbuyuk = yenisayı;

            }
            if (yenisayı < enkucuk)
            {
                enkucuk = yenisayı;
            }


        }
        Console.WriteLine("En büyük sayı " + enbuyuk);
        Console.WriteLine("En küçük sayı " + enkucuk);
    }
    else if (secim == "2")
    {
        int sayıı, ortalama = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Yeni sayıyı Giriniz");
            sayıı = Convert.ToInt32(Console.ReadLine());
            ortalama += sayıı;
        }
        ortalama = (ortalama / 5);
        Console.WriteLine("Sayıların ortalaması " + ortalama);
    }
    else if (secim == "3")
    {
        int sayı3;
        double toplam = 1;

        Console.WriteLine("Hangi sayıya kadar faktöriel alsın");
        sayı3 = Convert.ToInt32(Console.ReadLine());
        if (sayı3 == 0)
        {
            toplam = 1;
        }
        else
        {
            for (int i = 1; i <= sayı3; i++)
            { toplam *= i; }
            Console.WriteLine("{0}! = {1} ", sayı3, toplam);
        }
    }
    else if (secim =="q")
    { Console.WriteLine("Sistemden Çıkılıyor.....");
        Thread.Sleep(3000);
        break;
    }
    else
    { Console.WriteLine("Lütfen Doğru Tuşlama Yapınız");
        continue;
    }


}