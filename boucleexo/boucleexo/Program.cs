using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucleexo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i <=20; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int j = 0;
            while ( j<=20)
            {
                if ((j % 2) == 0)
                {
                    Console.WriteLine(j);
                    j = j + 1;
                }
                else j = j + 1;

            }
            */

            /*
            int nombre;
            Console.Write("saisir nombre : ");
            nombre = int.Parse(Console.ReadLine());

            int compteur = 1;
            string chaine = " ";
            while(compteur <=nombre)
            {
                if (compteur != nombre)
                {

                    chaine = chaine + compteur.ToString() + " + ";
                }
                else chaine = chaine + compteur.ToString();

                compteur = compteur + 1;

                
            }
            Console.Write(chaine);


    */
            /*
                    Console.WriteLine("Saisisez 5 nombres : ");

                    int total=0;
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine("Nombre " + i + " :");
                        int valeur = int.Parse(Console.ReadLine());
                        total = total + valeur;
                    }
                    total = total / 5;
                    Console.WriteLine("Moyenne : " +total);
                    */
            /*
      string CalculSommeEntier(int nb1, int nb2)
     {
        string chaine="";
        int valeur=0;

        while( nb1<=nb2 )
        {
          valeur = valeur + nb1;
            nb1 = nb1 + 1;

        }
        chaine = " " + valeur;
        return chaine;
      }


    int x;
    int y;
    string chainec = "";
    Console.WriteLine("Saisir x :");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine("Saisir y :");
    y = int.Parse(Console.ReadLine());


    chainec=CalculSommeEntier(x, y);
    Console.Write("somme :" + chainec);

    */
    /*
            float Calculmoy(List<float>nbs)
            {
                float total=0;
                
                foreach(float e in nbs)
                {

                    total = total + e;
                }
                total = total / nbs.Count();

                return total;
            }

            List<float> listnombre = new List<float>();

            listnombre.Add(10);
            listnombre.Add(10);
            listnombre.Add(5);
            listnombre.Add(5);

            Console.Write(" " + Calculmoy(listnombre));

    */

            void CalculCommun()
            {

                List<int> div = new List<int>();
                List<int> resultdiv3 = new List<int>();
                List<int> resultdiv5 = new List<int>();
                List<int> commun = new List<int>();

                for(int i = 1; i <= 100; i++)
                {

                    div.Add(i);
                }

                foreach(int e in div)
                {
                    if ((e % 3) == 0)
                    {
                        resultdiv3.Add(e);
                    }
                    
                }

                foreach (int f in div)
                {
                    if ((f % 5) == 0)
                    {
                        resultdiv5.Add(f);
                    }

                }

                commun = resultdiv5.Intersect(resultdiv3).ToList();

                foreach (int a in commun)
                {
                    Console.Write(a + " / ");

                }

            }

            CalculCommun();

            Console.ReadLine();
        }
    }
}
