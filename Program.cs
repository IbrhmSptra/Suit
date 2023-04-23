using System;

namespace Suit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Main = true;
            string player;
            Random acak = new Random();
            int nomor;
            string [] A = new string [2];
            while (Main) {

                System.Console.WriteLine("-----------------------------------------------");
                System.Console.WriteLine("Selamat Datang Di Permainan Suit Lawan Komputer");
                System.Console.WriteLine("-----------------------------------------------");
                System.Console.WriteLine("Pilih Salah Satu : (Gunting / Batu / Kertas)");
                System.Console.Write("Ketik Disini . . .");
                player = Console.ReadLine();
                player = player.ToUpper();

                while (true) {
                    if (player != "GUNTING" && player != "KERTAS" && player !="BATU") {
                        System.Console.WriteLine();
                        System.Console.WriteLine("***************************");
                        System.Console.WriteLine("    Pilihan Anda Salah");
                        System.Console.WriteLine("***************************");
                        System.Console.WriteLine();
                        System.Console.WriteLine("Pilih Salah Satu : (Gunting / Batu / Kertas)");
                        System.Console.Write("Ketik Disini . . .");
                        player = Console.ReadLine();
                        player = player.ToUpper();
                    }
                    else if (player == "GUNTING" || player == "KERTAS" || player =="BATU") {
                        break;
                    }
                }

                nomor = acak.Next(1,4);
                switch (nomor) {
                    case 1 :
                    A[0] = "GUNTING";
                    break;
                    case 2 :
                    A[0] = "KERTAS";
                    break;
                    case 3 :
                    A[0] = "BATU";
                    break;
                }

                switch (player) {
                    case "GUNTING" :
                    if (A[0] == "GUNTING") {
                        System.Console.WriteLine("-----------------------");
                        System.Console.WriteLine("Komputer : " + A[0]);
                        System.Console.WriteLine("Anda     : " + player);
                        System.Console.WriteLine("   <<<<< SERI >>>>>  ");
                        System.Console.WriteLine("-----------------------");
                    }
                    else if (A[0] == "KERTAS") {
                        System.Console.WriteLine("-----------------------");
                        System.Console.WriteLine("Komputer : " + A[0]);
                        System.Console.WriteLine("Anda     : " + player);
                        System.Console.WriteLine("   <<<<< MENANG >>>>>  ");
                        System.Console.WriteLine("-----------------------");
                    }
                    else {
                        System.Console.WriteLine("-----------------------");
                        System.Console.WriteLine("Komputer : " + A[0]);
                        System.Console.WriteLine("Anda     : " + player);
                        System.Console.WriteLine("   <<<<< KALAH >>>>>  ");
                        System.Console.WriteLine("-----------------------");
                    }
                    break;
                    case "KERTAS" :
                    if (A[0] == "KERTAS") {
                        System.Console.WriteLine("-----------------------");
                        System.Console.WriteLine("Komputer : " + A[0]);
                        System.Console.WriteLine("Anda     : " + player);
                        System.Console.WriteLine("   <<<<< SERI >>>>>  ");
                        System.Console.WriteLine("-----------------------");
                    }
                    else if (A[0] == "BATU") {
                        System.Console.WriteLine("-----------------------");
                        System.Console.WriteLine("Komputer : " + A[0]);
                        System.Console.WriteLine("Anda     : " + player);
                        System.Console.WriteLine("   <<<<< MENANG >>>>>  ");
                        System.Console.WriteLine("-----------------------");
                    }
                    else {
                        System.Console.WriteLine("-----------------------");
                        System.Console.WriteLine("Komputer : " + A[0]);
                        System.Console.WriteLine("Anda     : " + player);
                        System.Console.WriteLine("   <<<<< KALAH >>>>>  ");
                        System.Console.WriteLine("-----------------------");
                    }
                    break;
                    case "BATU" :
                    if (A[0] == "BATU") {
                        System.Console.WriteLine("-----------------------");
                        System.Console.WriteLine("Komputer : " + A[0]);
                        System.Console.WriteLine("Anda     : " + player);
                        System.Console.WriteLine("   <<<<< SERI >>>>>  ");
                        System.Console.WriteLine("-----------------------");
                    }
                    else if (A[0] == "KERTAS") {
                        System.Console.WriteLine("-----------------------");
                        System.Console.WriteLine("Komputer : " + A[0]);
                        System.Console.WriteLine("Anda     : " + player);
                        System.Console.WriteLine("   <<<<< KALAH >>>>>  ");
                        System.Console.WriteLine("-----------------------");
                    }
                    else {
                        System.Console.WriteLine("-----------------------");
                        System.Console.WriteLine("Komputer : " + A[0]);
                        System.Console.WriteLine("Anda     : " + player);
                        System.Console.WriteLine("   <<<<< MENANG >>>>>  ");
                        System.Console.WriteLine("-----------------------");
                    }
                    break;
                }
                System.Console.WriteLine("");
                System.Console.WriteLine("Apakah Anda ingin Bermain Lagi ?");
                A[1] = Console.ReadLine();
                A[1] = A[1].ToUpper();
                while (true) {
                if (A[1] != "IYA" && A[1] != "TIDAK") {
                System.Console.WriteLine("");
                System.Console.WriteLine("Apakah Anda ingin Bermain Lagi ?");
                A[1] = Console.ReadLine();
                A[1] = A[1].ToUpper();
                }
                else if (A[1] == "IYA" || A[1] == "TIDAK") {
                    break;
                }
                }

                if (A[1] == "IYA") {
                    Main = true;
                }
                else {
                    Main = false;
                }



            }
            System.Console.WriteLine("Terima Kasih Telah Bermain, Sampai Jumpa");

        }
    }
}
