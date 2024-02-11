using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Degiskenler();
            Vatandas vatandas = new Vatandas(); // 1 tane vatandaş oluşturduk.

            SelamVer("Melike");
            SelamVer("Engin");
            SelamVer("İbrahim");
            SelamVer();

            Topla();
            int sonuc = Topla(3,5);

            // Diziler / Arrays
            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            //Heap'te yeni bir alan tanımlar
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            // Arrayler , sınıflar , interfaceler , abstractlar referans tiplerdir. 

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1; // sehirler1 ile sehirler2 nin referansı birbirine eşitlenmiştir yani aynı yeri gösteriyordur.
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            // stringler referans tiptir.

            // sehirler1 i gez , sehir : her bir elemanı gezerken ona verdiğimiz takma isim
            foreach (string sehir in sehirler1) {  Console.WriteLine(sehir); }

            List<string> yeniSehirler = new List<string> {"Ankara","İstanbul","İzmir"};
            yeniSehirler.Add("Adana");

            foreach (var sehir  in yeniSehirler) {  Console.WriteLine(sehir); }

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        // Metot
        // Void metotlar sadece işi yapar , herhangi bir şey döndürmezler.
        static void SelamVer(string isim="İsimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1=8,int sayi2=5) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc; 
        }

        private static void Degiskenler()
        {
            //Console.WriteLine("Hello , world");
            //Console.WriteLine("Hello , world");
            //Console.WriteLine("Hello , world");
            //Console.WriteLine("Hello , world");
            //Console.WriteLine("Hello , world");
            //Console.WriteLine("Hello , world");

            //string mesaj = "Helloo , people";
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);

            //mesaj = "Hi! , people";
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj);

            double tutar = 1000000;
            Console.WriteLine(tutar * 1.18);

            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNO = 12345678905;
        }
    }

    // pascal casing
    class Vatandas
    {
        public string ad = "Engin";
        public string soyad = "Demiroğ";
        public int dogumYili = 1985;
        public long tcNO = 12345678905;

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNO { get; set; }
    }
}