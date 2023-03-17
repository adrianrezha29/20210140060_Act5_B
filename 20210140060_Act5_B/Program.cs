using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        public void ArraySatuDimensi_1()
        {
            //deklarasi atau mendefinisikan array satu dimensi
            int[] A = new int[4];

            //Mengisi atau menyimpan data dalam array satu dimensi
            A[0] = 7;
            A[1] = 8;
            A[2] = 9;
            A[3] = 10;

            //Mengisi menggunakan perulangan FOR
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Masukkan Elemen ke {i} =");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Membaca atau mengambil isi array
            Console.WriteLine($"Elemen[0] = {A[0]}");
            Console.WriteLine($"Elemen[0] = {A[1]}");
            Console.WriteLine($"Elemen[0] = {A[2]}");
            Console.WriteLine($"Elemen[0] = {A[3]}");
            Console.ReadKey();

            //Membaca array dengan perulangan FOR
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Masukkan Elemen ke {i} = {A[i]}");
            }
            Console.ReadKey();
        }

        public void ArraySatuDimensi_2()
        {
            //Mendefinisikan Array satu dimensi dengan ukuran array diinputkan user
            int[] B;
            int ukuran;

            Console.Write("Masukkan ukuran array = ");
            ukuran = Convert.ToInt32(Console.ReadLine());

            //Membuat obyek array
            B = new int[ukuran];

            //Mengisi array
            for (int i = 0; i < ukuran; i++)
            {
                Console.Write($"Masukkan elemen ke-{i} =");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Membaca array dengan perulangan FOR
            Console.WriteLine();
            for (int i = 0; i < ukuran; i++)
            {
                Console.WriteLine($"Isi Elemen ke {i} = {B[i]}");
            }
            Console.ReadKey();
        }

        public void ArrayDuaDimensi()
        {
            //mendefinisikan array 2 dimensi 
            int[,] Arr = new int[3, 4];

            //Mengisi array dimensi FOR
            Console.WriteLine("Mengisi Array 2 Dimensi");
            for (int baris = 0; baris < 3; baris++)
            {
                for (int kolom = 0; kolom < 4; kolom++)
                {
                    Console.Write($"Masukkan elemen [{baris}, {kolom}] = ");
                    Arr[baris, kolom] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //  2   4
            //  1   3   5   7
            //  4   6   7
            //Mendefinisikan array 2 dimensi yang memiliki jumlah kolom yang berbeda-beda

            int[][] Y = new int[3][];

            //Mengisi Langsung
            Y[0] = new int[2] { 2, 4 };
            Y[1] = new int[4] { 1, 3, 5, 7 };
            Y[2] = new int[3] { 4, 6, 8 };

            Console.WriteLine("Mengisi dengan diinputkan dengan menggunakan FOR");
            int kolom;
            for (int b = 0; b < Y.Length; b++)
            {
                Console.Write("Masukkan Jumlah Kolom = ");
                kolom = Convert.ToInt32(Console.ReadLine());

                Y[b] = new int[kolom];
                for (int k = 0; k < Y[b].Length; k++)
                {
                    Console.Write($"Masukkan Elemen [{b}][{k}] = ");
                    Y[b][k] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Menampilkan isi array");
            for (int b = 0; b < Y.Length; b++)
            {
                for (int k = 0; k < Y[b].Length; k++)
                {
                    Console.Write($"{Y[b][k]}  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}