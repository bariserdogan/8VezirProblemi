using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8QueenProblem
{
    class Program
    {
        // başlangıç tanımlamaları satır,sutun,matris ve koordinatlar
        static int row = 8;
        static int column = 8;
        static string[,] chess_board = new string[row, column];
        static int x;
        static int y;
        
        public static void Main(string[] args)
        {
            setValueToMatris(); // initial metodumuzu aldık

            Random rand = new Random();
            x = rand.Next(0, 8);
            y = rand.Next(0, 8);
            chess_board[x, y] = " V "; 
            // ilk vezir random nesnesinden gelen sayılarla (x,y) noktasına atandı   // x=5 && y=0 for 8 queen
            /* optimum çözüm :
                ilk vezirin 5,0 noktasına atanmasıdır
                bu durumda tahtaya 8 vezir yerleşebilmektedir
             
              */      

            // close metodlarımıza random değerlermizi gönderdik
            closeRow(x, y);
            closeColumn(x, y);
            closeCrossElements(x, y);

            // sırasıyla yerleşebilcek tüm vezirler için kapatma işlemlerini uyguluyoruz
            // ta ki artık yerleştirilecek yer bulunamayana kadar
            while (findEmptyPlaceForQueen() != null)
            {
                x = findEmptyPlaceForQueen()[0];
                y = findEmptyPlaceForQueen()[1];
                chess_board[x, y] = " V ";
                closeRow(x, y);
                closeColumn(x, y);
                closeCrossElements(x, y);
            }

            display();
            Console.WriteLine("#############");
        }

        // vezirin atandığı satırdaki diğer elemanların yerini '*' ile kapatan metod
        // çünkü aynı satırda ikinci bir vezir olmamalı
        public static void closeRow(int x, int y) 
        {
            // satırın başından sonuna kadar atamanın olamayacağı bütün yerleri for ile kontrol ediyoruz
            for (int i = x - 7; i <= x + 7; i++)
                if (i < 8 && i >= 0) // tahtanın sınırlarını aşmaması için 
                    if (i != x) // vezirin konumu ile döngü elemanının değeri aynı değilse '*' yaz(yani o noktayı kapat)
                        chess_board[i, y] = " * ";
        }

        //vezirin atandığı sütun için de closeRow() metodunda yapılanların aynısını tekrarlıyoruz
        //o sütundaki diğer noktaları '*' ile kapatıyoruz
        public static void closeColumn(int x, int y)
        {
            for (int i = x - 7; i <= x + 7; i++)
                if (i < 8 && i >= 0)
                    if (i != y)
                        chess_board[x, i] = " * ";
        }



        // bu metod ise vezirin bulunduğu köşegenleri kapatmak için
        /*
            *          *
              *       *   // right up
                *   *
                  *
                *   *
              *       *   // right down
             *          *
            
            
            */
            // vezirin köşegen olarak aşağı ve yukarısındaki noktaları yine for döngüsü ile kontrol ediyoruz
        public static void closeCrossElements(int x, int y)
        {
            for (int i = 1; i <= 7; i++)    //only left up
                if (x - i >= 0 && y - i >= 0)
                    chess_board[x - i, y - i] = " * ";

            for (int i = 1; i <= 7; i++)
                if (x + i < 8 && y + i < 8) //only right down
                    chess_board[x + i, y + i] = " * ";

            for (int i = 1; i <= 7; i++)
                if (x + i < 8 && y - i >= 0) //only left down
                    chess_board[x + i, y - i] = " * ";

            for (int i = 1; i <= 7; i++)
                if (x - i >= 0 && y + i < 8) //only left up
                    chess_board[x - i, y + i] = " * ";

        }
        public static int[] findEmptyPlaceForQueen()
        {
            int[] indexesOfEmptyPlaces = new int[2];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chess_board[i, j] != " * " && chess_board[i, j] != " V ")
                    {
                        indexesOfEmptyPlaces[0] = i;
                        indexesOfEmptyPlaces[1] = j;
                        return indexesOfEmptyPlaces;
                    }
                }
            }
            return null;
        }
        // matrisin tüm elemanlarına başlangıç olarak '-' atayan metodu initial metod
        public static void setValueToMatris()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    chess_board[i, j] = " - ";
                }
            }
        }

        // en son çalışan metodumuz
        // tahtayı dolaşarak vezirleri ekrana basıyoruz
        public static void display() 
        {
            Console.Write("Loading...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n");

            for (int i = 0; i < row; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < column; j++)
                {
                    Console.Write(chess_board[i, j]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

    }
}
