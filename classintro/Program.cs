// See https://aka.ms/new-console-template for more information

string adi = "Nurullah";
int yas = 17;

kurs kurs1 = new kurs();
kurs1.kursadi = "c#";
kurs1.Egitmen = "Engin demirog";
kurs1.izlenmeorani = 68;

kurs kurs2 = new kurs();
kurs2.kursadi = "java";
kurs2.Egitmen = "kerem varış";
kurs2.izlenmeorani = 64;

kurs kurs3 = new kurs();
kurs3.kursadi = "python";
kurs3.Egitmen = "berkay bilgin";
kurs3.izlenmeorani = 80;

kurs kurs4 = new kurs();
kurs4.kursadi = "css";
kurs4.Egitmen = "murat kurtbağan";
kurs4.izlenmeorani = 100;

//Console.WriteLine(kurs1.kursadi + " : " + kurs1.Egitmen);

kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3,kurs4 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.kursadi + " : " + kurs.Egitmen);
}



//Console.WriteLine("Hello, World!");

class kurs
{
    public string kursadi { get; set; }
    public string Egitmen { get; set; }
    public int izlenmeorani { get; set; }
}