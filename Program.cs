// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


namespace MyProject;

class Program
{
    static void Main(string[] args)
    {

            const string nama_Benar = "omar";
            const string pw_Benar = "12345678";
            int kesempatan = 3;

            while (kesempatan > 0)
            {
                Console.Write("Masukkan Username mu yuk!: ");
                string username = Console.ReadLine();

                Console.Write("Masukkan Password mu bjir!: ");
                string password = Console.ReadLine();

                if (username == nama_Benar && password == pw_Benar) {
                    Console.WriteLine("Selamat datang, " + username + "!");
                    break;
                } else {
                    kesempatan--;
                    Console.WriteLine("username/password salah uy: " + kesempatan);            
                    if (kesempatan == 0) {
                        Console.WriteLine("bro akun lo ke blokir bjir.");
                    }
                }
            }
    }

}       



