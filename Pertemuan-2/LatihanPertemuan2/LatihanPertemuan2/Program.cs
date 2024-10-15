namespace LatihanPertemuan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.Write("Test");
            Console.Write("Test");
            Console.WriteLine("Hello" + " " + "World!");
            Console.WriteLine("Hello" + " " + 100);
            Console.WriteLine(1000 + 200);
            */
            
            /*
            Console.WriteLine("Hello"); // String
            Console.WriteLine(99);  // Integer
            Console.WriteLine('K'); // Char
            Console.WriteLine(true);    // Boolean
            */
            
            /*
            // Eksplisit
            string alamat;
            int umur;
            double beratBadan;
            bool isMenikah;
            
            alamat = "Jl. Argentina No.10";
            umur = 100;
            beratBadan = 55.7;
            isMenikah = false;
            
            string nama = "Lionel Messi";
            int angkatan = 2023;
            float nilaiAkademik = 3.84F;
            
            Console.WriteLine("Nama Saya : " + nama);
            Console.WriteLine("Umur Saya : " + umur);
            Console.WriteLine("Alamatnya adalah : " + alamat); 
            */

            /*
            // implisit
            var nama = "Ronaldo";
            var umur = 1000;
            var beratBadan = 70.5;
            
            Console.WriteLine(nama.GetType());
            Console.WriteLine(umur.GetType());
            Console.WriteLine(beratBadan.GetType());
            */
            
            /*
            // Untuk mengetahui Length
            string text = "HELLO ULBI";
            Console.WriteLine("Panjang variable text adalah " + text.Length);
            
            // To Upper untuk mengubah jadi huruf Kapital
            Console.WriteLine(text.ToUpper());
            
            // ToLower untuk mengubah jadi huruf kecil
            Console.WriteLine(text.ToLower());
            */
            
            /*
            // Menggabungkan dua string
            string firstName = "John";
            string lastName = "Doe";
            string name = firstName + " " + lastName;
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine(fullName);
            
            // String interpolatio
            string iniNama = $"Nama lengkap saya adalah {firstName} {lastName}";
            Console.WriteLine(iniNama);
            
            // String Format
            string ituNama = string.Format("Nama saya {0} {1}", firstName, lastName);
            Console.WriteLine(ituNama);
            // atau
            Console.WriteLine("Nama saya {0} {1}", firstName, lastName);
            */
            
            /*
            // Access String
            string myString = "Aku Kuat";
            Console.WriteLine(myString[4]);
            */
            
            /*
            // Sintaks Input
            Console.WriteLine("Masukan nama anda : ");
            string namaAnda = Console.ReadLine();
            
            Console.WriteLine("Hi, " + namaAnda + "Welcome to party");  //Using Regular
            Console.WriteLine($"Hi, {namaAnda} welcome to party");  // Using Interpolation
            Console.WriteLine("Hi, {0} welcome to party", namaAnda);    // Use Format Indeks
            */
            
            /*
            // Explicit
            int myInt = 9;
            double myDouble = myInt; 
            Console.WriteLine(myInt);      
            Console.WriteLine(myDouble);
            
            // Implicit
            double myInt2 = 9;
            int myDouble2 = (int) myInt; 
            Console.WriteLine(myInt2);      
            Console.WriteLine(myDouble2);
            
            // atau
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool3 = true;
            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool3));   // convert bool to string
            
            // Input Convert
            Console.WriteLine("Masukan Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Angka yang dimasukan : {input}");
            Console.WriteLine(input.GetType());
            */
        }
    }
}