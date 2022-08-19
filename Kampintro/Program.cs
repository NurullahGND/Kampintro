// See https://aka.ms/new-console-template for more information
string kategorietiketi = "Kategori";
int ogrencisayisi = 32000;
double faizorani = 1.45;
bool sistemeGirisYapmismi = true;
double dolardun = 7.55;
double dolarbugun = 7.55;

if (dolardun>dolarbugun)
{
    Console.WriteLine("-");
}
else if (dolardun<dolarbugun)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("=");
}
if (sistemeGirisYapmismi==true)
{
    Console.WriteLine("kullanıcı ayarları butonu");
}
else 
{
    Console.WriteLine("giriş yap butonu");
}

Console.WriteLine(kategorietiketi);
