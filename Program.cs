using System;


class Program
{
    static void sarkiSoz() //Geriye Değer Döndürmeyen Bir void metot.Ekrana sevdiğiniz bir şarkı sözünü yazdırsın.


    {
        Console.WriteLine("Müşküle tabi zulüm \nPeki derdime dert ne diye \nBeni anlamadın da kanatma canım' ne olur");
    }

    static int rastgelesayi()  //Geriye Tamsayı Döndüren Bir metot. Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.


    {
        Random rnd = new Random();
        int rastgele = rnd.Next(30);
        return rastgele % 3;
    }

    static int carpim(int a, int b) // Parametre Alan ve Geriye Değer Döndüren Bir Metot. Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
    {
        return a * b;
    }

    static void karsilama(string name, string surname) // Parametre Alan ve Geriye Değer Döndürmeyen bir Metot. Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
    {
        Console.WriteLine("Hoşgeldin, " + name + surname);
    }


    static void Main()     // metodları çağırıyoruz
    {
    
        sarkiSoz();

        Console.WriteLine($"Kalan {rastgelesayi()}");

        Console.WriteLine($"5 ile 15 çarpımı : {carpim(5,15)}");

        karsilama("Engin", "onder");


    }















}