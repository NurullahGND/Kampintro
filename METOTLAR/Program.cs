﻿// See https://aka.ms/new-console-template for more information
using METOTLAR;


Urun urun1 = new Urun();
urun1.Adi = "elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2};

foreach (var urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("--------------------");
}

Console.WriteLine("----------Metotlar----------");

Sepetmanager sepetmanager = new Sepetmanager();
sepetmanager.Ekle(urun1);
sepetmanager.Ekle(urun2);

sepetmanager.Ekle2("Armut", "Yeşil armut", 12, 10);
sepetmanager.Ekle2("Elma", "Yeşil elma", 12, 9);
sepetmanager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
