﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // ::::::::::::::les variables:::::::::::::::::::::::::::::::::::::::::::::::::
            /*
            
            Console.WriteLine("écrivez le Nom de produit : ");
            string produit = Console.ReadLine(); // nom de produit
            Console.WriteLine("écrivez le prix de " + produit + ":");
            int ht = int.Parse(Console.ReadLine()); // prix hors tax
            float tva = 0.19f;
            float ttc = ht * (tva + 1); // prix ttc
            Console.WriteLine("le prix TTC de " + produit + " est de " + (int)ttc + " DH");
            */

            // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

            // ::::::::::::::les boocles:::::::::::::::::::::::::::::::::::::::::::::::::::
            /*1--------------------
             
            
            int n = 1;
            int y = 3;
            bool c1 = y > 2, c2 = y < 100;

            while(n < 30 && c1 && c2)
            {
                Console.WriteLine(n * y);
                n++;
            }



            /*2-------------------

            float x = 1;
            do
            {
                Console.WriteLine(x);
                x += x * 1 / 2;

            } while (x < 10);


            
            /*3------------------

            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine("On y arrive presque");
            }

            for (int a = 20; a > 0; a--)
            {
                Console.WriteLine("C'est presque bon");
            }

            for (int b = 1; b < 101; b += 15)
            {
                Console.WriteLine("On tient le bon bout");
            }

            for (int c = 200; c > 0; c -= 12)
            {
                Console.WriteLine("Enfin ! ! !");
            }

            
            // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::


            // ::::::::::::::Les collections ::::::::::::::::::::::::::::::::::::::::::::::::
            
            /*
            string[] newList = new string[4];
            List<string> listMois = new List<string> { "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre" };
           
            Console.WriteLine(listMois[2]);   // la valeur de ligne 3
            Console.WriteLine(listMois[5]);   // la valeur de l'indice 5
            
            foreach (string mois in listMois)         // parcourir la list
            {
                Console.WriteLine(mois);
            }

            listMois[7] = "août ";           // modifier "aout" par "août "
            listMois.RemoveAt(2);                   // supprimer troixieme element de list
            listMois.Remove("avril");               // supprimer un element par son nom
            listMois.Insert(0, "test");            // inserer un element sur possition 0

            int indice = listMois.IndexOf("decembre"); // chercher l'indice d'un element
            Console.WriteLine(indice);

            listMois.Sort();                        // trier list
            Console.WriteLine("list final apres l'ordre:");
            foreach (string mois in listMois)         // parcourir l 'ordre
            {
                Console.WriteLine(mois);
            }
            
            
            Console.WriteLine("-------" + Environment.NewLine);
            Console.WriteLine("nouvel list copiée :");
            listMois.CopyTo(0, newList, 0, 4);     // copier 4 element vers une nouvelle liste
            foreach (string i in newList)         // parcourir
            {
                Console.WriteLine(i);
            }

            */

            // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

            // ::::::::::::::les fonctions:::::::::::::::::::::::::::::::::::::::::::::::::::

            

            int Add(int x, int y) // fonction +
            {
                int r = x + y;
                return r;
            }


            int Sous(int x, int y)  // fonction -
            {
                int r = x - y;
                return r;
            }

             int Mult(int x, int y)     // fonction *
            {
                int r = x * y;
                return r;
            }

            float Div(float x, float y)      // fonction /
            {
                float r = x / y ;
                return r;

            }

            double Rest(double x, double y)    // fonction %
            {
                double r = x % y;
                return r;
            }

           


            Console.WriteLine("entrer un premier nombre"); 
             int x = int.Parse(Console.ReadLine()); // stocker le premier nombre
            Console.WriteLine("entrer un deuxieme nombre");
            int y = int.Parse(Console.ReadLine()); // stocker le deuxieme nombre

            Console.WriteLine("entrer l'operation souhaité : +, /, -, %, * , pour arreter saisir q");
            string opt = Console.ReadLine();   // stocker l'operation souhaitée

            

           

      
            if (opt == "+")           
            {
                Console.WriteLine("RESULTAT EST");
                Console.WriteLine(Add(x, y));    // l'appel de fonction Add si la condition est vrai
            }
            else if (opt == "-")
            {
                Console.WriteLine("RESULTAT EST");
                Console.WriteLine(Sous(x, y));
            }
            else if (opt == "*")
            {
                Console.WriteLine("RESULTAT EST");
                Console.WriteLine(Mult(x, y));
            }
            else if (opt == "%")
            {
                if (y == 0)
                {
                    Console.WriteLine("Nous ne pouvons pas diviser par zéro");
                }
                else 
                {
                    Console.WriteLine("RESULTAT EST");
                    Console.WriteLine(Rest(x, y)); 
                }
                
            }
            else if (opt == "/")
            {
                if (y == 0)
                {
                    Console.WriteLine("Nous ne pouvons pas diviser par zéro");
                }
                else 
                {
                    Console.WriteLine("RESULTAT EST");
                    Console.WriteLine(Div(x, y)); 
                }

            }
            else 
            {
                Console.WriteLine("le programme est arreté");
                    
            }
            
             
            







        }
    }
}
