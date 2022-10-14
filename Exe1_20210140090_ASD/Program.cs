using System;
using System.Globalization;

namespace Exe1_ASD
{
    class Program
    {
        //Declare array int ukuran 110
        private int[] wildan = new int[110];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada aaray
        private int n;

        //Fungsi / Method untuk menerima masukan
        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 110)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                wildan[i] = Int32.Parse(s1);
            }
        }

        public void SortArray()
        {
            int min_index;
            int temp;

            for (int MA = 0; MA < n - 2; MA++) //step 1
            {
                min_index = MA;
                for (int i = MA + 1; i < n - 1; i++)
                {
                    if (wildan[i] < wildan[min_index]) //Jika elemen tidak dalam urutan yang benar
                    {
                        min_index = i;
                    }
                }
                //Tukar Elemen
                temp = wildan[min_index];
                wildan[min_index] = wildan[MA];
                wildan[MA] = temp;
            }
        }
        

        public void display()
        {
            //Menampilkan Array yang tersusun
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(wildan[i]);
            }
            Console.WriteLine("");
        }

        static void Main(String[] args)
        {
            // Creating the object of the BubbleSort class
            Program listKu = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            listKu.read();
            // Pemanggilan fungsi untuk mengurutkan array
            listKu.SortArray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            listKu.display();
            //Exit
            Console.WriteLine("\n\nTekan Tombol apa Saja Untuk Keluar.");
            Console.Read();
        }
    }

}

//max data num = 90 + 10 + 20 + 20 - 2 x 15
//max data num = 140 - 30
//max data num = 110

//j = MA

//arr = wildan