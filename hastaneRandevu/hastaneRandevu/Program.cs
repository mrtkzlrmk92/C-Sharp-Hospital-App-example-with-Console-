using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaneRandevu
{
    class Program
    {
       public string[] bolum = {"kardiyoloji","genel cerrahi",
        "kadın doğum","üroloji","cildiye","radyoloji","göz","KBB","ortopedi"};
       static int secilenBolum ;
        public doktor[,] d = new doktor[10, 3];
        static void Main(string[] args)
        {
            Program p = new Program();
            p.bolumSec();
            p.doktorYukle();
            p.doktorSec();
            Console.ReadLine();
        }

        private void doktorSec()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }
        }

        private void doktorYukle()
        {
            int sayac = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    d[i, j].Id = sayac;
                    sayac++;
                    d[i, j].Ad = FakeData.NameData.GetFirstName();
                    d[i, j].Soyad = FakeData.NameData.GetSurname();
                    d[i, j].unvan ="dr";
                    d[i, j].bolumId =i;

                }

            }
        }

        public  void bolumSec()
        {
            for (int i = 0; i < bolum.Length; i++)
            {
                Console.WriteLine(bolum[i]+"\t seçmek için {0} tuşuna basınız",i);
            }
            secilenBolum = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
