using System;

namespace PrimulProiect
{
    class Program
    {
        static void Main(string[] args)
        {
               const float procentGravitatieLuna = 0.17f;
                 float greutateOm;


                //  rezultat flot/ 
                // const => procent
                // float => validarea datelor

                // afiseaza text user
                Console.Write("Introduceti greutatea unui om : ");

                // validam greutatea omului
                  greutateOm = float.Parse(Console.ReadLine());

                if (greutateOm == 0)
                {
                    Console.WriteLine("Uups ati introdus date invalide");
                }



                // rezultat greutate om pe luna

                float rezultat = greutateOm * procentGravitatieLuna;
                Console.Write("Greutatea dvs eate : " + rezultat);


            //----------------------------
            /*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
              paralelipiped dreptunghic, va afisa volumul lui*/

            //afisare text user
             Console.Write("Introduceti dimensiunile paralipipedului: ");
            

             Console.Write("inaltime: ");
             int inaltime = int.Parse(Console.ReadLine());

             Console.Write("lungime: ");
            int lungime = int.Parse(Console.ReadLine());

             Console.Write("latime: ");
            int latime = int.Parse(Console.ReadLine());






             if (inaltime== 0 || lungime == 0 || latime  == 0)
             {

                 Console.WriteLine("Datele introduse trebuie sa fie diferite de 0!!!");

             }


             int rezultat = lungime * latime * inaltime;

             Console.Write("Volumul paralipipedului dvs este :" + rezultat);
            //------------------------

            /*Scrieti un program care va calcula media aritmetica a trei numere citite de la
            tastatura*/


              Console.Write("Introdu primul numar: ");
              float numarul1 = float.Parse(Console.ReadLine());

              Console.Write("Introdu al doilea numar: ");
              float numarul2 = float.Parse(Console.ReadLine());

              Console.Write("Introdu primul numar: ");
              float numarul3 = float.Parse(Console.ReadLine());


              float  rezultat = (numarul1 + numarul2 + numarul3) / 3;

              Console.WriteLine("Media este de: " + rezultat);

            //-------------------------------
            /*Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura*/
           Console.Write("Introdu numarul: ");

            int numar = int.Parse(Console.ReadLine());

            int rezultat = numar % 10;
            Console.WriteLine("ultima cifra din numar este: " + rezultat);

            //-----------------------------------

            /*Scrieti un program care va afisa semnul unui numar citit de la tastatura
            • Daca numarul este pozitiv, va afisa “+”
            • Daca numarul este negativ, va afisa “-”
            • Daca numarul este 0, va afisa “0”*/

            Console.Write("Introdu  numarul: ");

            int numar = int.Parse(Console.ReadLine());

            if(numar > 0)
            {
                Console.WriteLine("+");
            }
            if(numar < 0)
            {
                Console.WriteLine("-");
            }
            if(numar == 0)
            {
                Console.WriteLine("0");
            }

            //--------------------------------


            /*Se citesc doua numere de la tastatura, x,y. 
             *Scrieti un program care va afisa cele doua valori in ordine crescatoare.*/

             Console.Write("x: ");
             int x = int.Parse(Console.ReadLine());

             Console.Write("y: ");
             int y = int.Parse(Console.ReadLine());

             if(x > y)
             {
                 Console.WriteLine(x + "," + y);

             }
             else
             {
                 Console.WriteLine(y + "," + x);
             }
            //-------------------------
            /*Se citesc trei numere de la tastatura, x,y,z. 
         * Scrieti un program care va afisa cele trei valori in ordine descrescatoare.*/

             Console.Write("x: ");
             int x = int.Parse(Console.ReadLine());

             Console.Write("y: ");
             int y = int.Parse(Console.ReadLine());

             Console.Write("z: ");
             int z = int.Parse(Console.ReadLine());


             if(x <= y && y <= z)
             {
                 Console.Write(x + "," + y + "," + z);
             }
             else if(x <= y &&  z <= y)
             {
                 Console.Write(x + "," + z + "," + y);
             }
             else if (y <= x && x <= z)
             {
                 Console.Write(y + "," + x + "," + z);
             }
             else if( y <= z && z <= x)
             {
                 Console.Write(y + "," + z + "," + x);
             }
             else if(z <= x && x <= y)
             {
                 Console.Write(z + "," + x + "," + y);
             }
             else if(z <= x && y <= x)
             {
                 Console.Write(z + "," + y + "," + x);
             }
            //----------------


            /*Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar*/

              Console.Write("Introdu numarul: ");
              int numar = int.Parse(Console.ReadLine());

              if(numar%2 == 1)
              {
                  Console.WriteLine("Numarul este impar");
              }
              else
              {
                  Console.WriteLine("Numarul este par");
              }

            //------------------------------

           /* Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
               daca x este divizibil cu y*/

            Console.Write("Introdu primul nr: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Introdu al doilea nr: ");
            int y = int.Parse(Console.ReadLine());

            if(x % y == 0)
            {
                Console.Write("Sunt divizibile");
            }
            else
            {
                Console.Write("Nu Sunt divizibile");
            }
            //------------------------------

            /*Scrieti un program care interschimba valoarea a doua variabile intregi.*/

            int a,b,aux;
            a = 5;
            b = 7;
            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("a = "+ a + "" + "b = " +b);

            //----------------------

            /*Scrieti un program care sa va afisa suma cifrelor unui numar intreg citit de la tastatura.*/

            Console.Write("Introdu numarul: ");
            int numar = int.Parse(Console.ReadLine());
            int sum = 0;
            while (numar != 0)
            {
                sum = sum + numar % 10;
                numar = numar / 10;
            }
            Console.Write(sum);
        }


        

    }
}
