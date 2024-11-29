using System.Collections;

class Program
{ static void Main()
    {
        ArrayList isimler = new ArrayList();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Bir isim giriniz: ");
            string isim = Console.ReadLine();
            isimler.Add(isim);
        }
        isimler.Sort();
        Console.WriteLine("\nAlfabetik sıralı isimler:");
        foreach (string isim in isimler)
        {
            Console.WriteLine(isim);
        }
    }
}