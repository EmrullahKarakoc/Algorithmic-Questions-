using System;

namespace ObssCodeMaster
{
    class Program
    {
        

        static void Main(string [] args)
        {
            /*
             U: Ust tarafta bulunan 1 sayısı
             L: Alt tarafta bulunan 1 sayısı
             C: Sutunlarda Bulunan toplam 1 Sayıları



            Bize bu degerler verildigi zaman olusabilecek olasılıkta 2 diziyi ekrana yazdıran algoritmam
             
             */
            int U = 10;
            int L = 6;
            int [] C = { 1,1,2,1,2,1,2,1,2,1,2};

            int[,] dizi = new int[2, C.Length];
            int sayac = 0;
            foreach(var deger in C)
            {
                sayac += deger;
            }

            if(sayac != (U+L))
            {
                Console.WriteLine("IMPOSSIBLE");

            }
            else
            {              
                int a = 0;
                foreach (var deger in C)
                {
                        if (deger == 2)
                        {
                            dizi[0, a] = 1;
                            dizi[1, a] = 1;
                            U--;
                            L--;
                            C[a] = 0;
                        }
                             a++;
                }

                for (int i = 0; i < C.Length; i++)
                {
                    if (U > 0 && dizi[0, i] == 0)
                    {
                        dizi[0, i] = 1;
                        U--;
                    }
                }

                for (int i = 0; i < C.Length; i++)
                {
                    if (L > 0 && dizi[1, i] == 0 && dizi[0, i] != 1)
                    {
                        dizi[1, i] = 1;
                        L--;
                    }
                }
                string sonuc = "";
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < (dizi.Length) / 2; j++)
                    {
                        sonuc += dizi[i, j] + " ";
                    }
                    if (i == 0)
                        sonuc += "\n";
                }
                Console.WriteLine(sonuc);
            }


            Console.ReadKey();
        }
    }
}
