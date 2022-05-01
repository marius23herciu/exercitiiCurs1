using System;

namespace exercitiiCurs1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Cele doua forward slash "//" in fata unei linii de cod marcheaza linia ca fiind comentata iar instructiunile de pe linie nu vor fi rulate.
            // Acum va rula exercitiu 2
            // Pentru a rula exercitiul 1 vom sterge "//" din fata liniei 12, "//Ex1" si vom comenta linia 13 adaugand "//" in fata textului "Ex2"
            //Ex1();
            //Ex2();
            Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            //Ex8();
            //Ex9();
            //Ex10();
            // Sa nu uitati sa salvati in mod frecvent (Ctrl+S) pentru a nu pierde munca
        }
        static void Ex1()
        {
            //Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
            //paralelipiped dreptunghic, va afisa volumul lui

            Console.WriteLine("Introduceti lungimea");
            int lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea");
            int latime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea");
            int inaltime = int.Parse(Console.ReadLine());
            var volumParalelipipedDreptunghic = lungime * latime * inaltime;
            Console.WriteLine("Volumul este " + volumParalelipipedDreptunghic);
        }
        static void Ex2()
        {
            //Scrieti un program care va calcula media aritmetica a trei numere citite de la
            //tastatura

            Console.WriteLine("Introduceti un numar");
            double n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar");
            double n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar");
            double n3 = int.Parse(Console.ReadLine());
            var medieAritmetica = (n1 + n2 + n3) / 3;
            Console.WriteLine("Media aritmetica este " + medieAritmetica);
        }
        static void Ex3()
        {
            // Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
            //tastaura
            //Console.WriteLine("Introduceti un numar");
            //int numarIntreg = int.Parse(Console.ReadLine());
            //string numar = numarIntreg.ToString();
            //string rezultat = "";
            //for (int i = numar.Length - 1; i < numar.Length; i++)
            //{
            //    rezultat = numar[i].ToString();
            //}
            //Console.WriteLine("Ultima cifra a numarului introdus este " + rezultat);

            ////varianta profesorului
            Console.WriteLine("Introduceti numarul ");
            int numarul = int.Parse(Console.ReadLine());

            int ultimaCifra = numarul % 10;

            Console.WriteLine("ultima cifra a numarului este " + ultimaCifra);
        }
        static void Ex4()
        {
            //            Scrieti un program care va afisa semnul unui numar citit de la tastatura
            //• Daca numarul este pozitiv, va afisa “+”
            //• Daca numarul este negativ, va afisa “-”
            //• Daca numarul este 0, va afisa “0”
            Console.WriteLine("Introduceti un numar");
            int numar = int.Parse(Console.ReadLine());
            if (numar > 0)
            {
                Console.WriteLine("Numarul introdus este mai mare decat 0");
            }
            else
            {
                if (numar < 0)
                {
                    Console.WriteLine("Numarul introdus este mai mic decat 0");
                }
                else
                {
                    Console.WriteLine("Numarul introdus este 0");
                }
            }
        }
        static void Ex5()
        {
            //     Se citesc doua numere de la tastatura, x,y.Scrieti un program care va afisa cele doua valori in ordine crescatoare.
            //• Exemplu: citim ,9,0 Afisam: 0 9
            Console.WriteLine("Introduceti un numar");
            int numarX = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar");
            int numarY = int.Parse(Console.ReadLine());
            if (numarX > numarY)
            {
                Console.WriteLine(numarY + " " + numarX);
            }
            else
            {
                Console.WriteLine(numarX + " " + numarY);
            }
        }
        static void Ex6()
        {
            // Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.
            //• Exemplu: citim 3,9,0 Afisam: 9 3 0
            Console.WriteLine("Introduceti un numar");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar");
            int z = int.Parse(Console.ReadLine());
            int[] matrice = new int[3];
            matrice[0] = x; matrice[1] = y; matrice[2] = z;
            for (int j = 0; j < matrice.Length; j++)
            {
                for (int i = 0; i < matrice.Length - 1; i++)
                {
                    if (matrice[i] < matrice[i + 1])
                    {
                        int temporar = matrice[i];
                        matrice[i] = matrice[i + 1];
                        matrice[i + 1] = temporar;
                    }
                }
            }
            foreach (var item in matrice)
            {
                Console.Write(item + " ");
            }

            //// varianta profesorului

            //Console.WriteLine("Introduceti primul numar");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Introduceti al doilea numar");
            //int y = int.Parse(Console.ReadLine());

            //Console.WriteLine("Introduceti al treilea numar");
            //int z = int.Parse(Console.ReadLine());

            //Console.WriteLine("Numerele ordonate");
            //if (x > y)
            //{
            //    if (z > x)
            //    {
            //        //zxy
            //        Console.WriteLine(z);
            //        Console.WriteLine(x);
            //        Console.WriteLine(y);
            //    }
            //    else if (y > z)
            //    {
            //        //xyz
            //        Console.WriteLine(x);
            //        Console.WriteLine(y);
            //        Console.WriteLine(z);
            //    }
            //    else
            //    {
            //        //xzy
            //        Console.WriteLine(x);
            //        Console.WriteLine(z);
            //        Console.WriteLine(y);
            //    }
            //}
            //else
            //{
            //    if (z > y)
            //    {
            //        //zyx
            //        Console.WriteLine(z);
            //        Console.WriteLine(y);
            //        Console.WriteLine(x);
            //    }
            //    else if (x > z)
            //    {
            //        //yxz
            //        Console.WriteLine(y);
            //        Console.WriteLine(x);
            //        Console.WriteLine(z);
            //    }
            //    else
            //    {
            //        //yzx
            //        Console.WriteLine(y);
            //        Console.WriteLine(z);
            //        Console.WriteLine(x);
            //    }
            //}
        }
        static void Ex7()
        {
            // Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar
            // In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
            Console.WriteLine("Introduceti un numar");
            int numar = int.Parse(Console.ReadLine());
            if (numar==0)
            {
                Console.WriteLine("Numarul introdus este 0");
            }
            else
            {
                if (numar % 2 == 0)
                {
                    Console.WriteLine("par");
                }
                else
                {
                    Console.WriteLine("impar");
                }
            }
        }
        static void Ex8()
        {
            // Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
            //daca x este divizibil cu y.
            // In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
            //“indivizibil”.
            Console.WriteLine("Introduceti un numar");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar");
            int y = int.Parse(Console.ReadLine());
            if (x % y == 0)
            {
                Console.WriteLine("divizibil");
            }
            else
            {
                Console.WriteLine("indivizibil");
            }
        }
        static void Ex9()
        {
            // Scrieti un program care interschimba valoarea a doua variabile intregi
            Console.WriteLine("Introduceti un numar");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar");
            int y = int.Parse(Console.ReadLine());
            int temporar = x;
            x = y;
            y = temporar;
            Console.WriteLine(x + " " + y);
        }
        static void Ex10()
        {
            // Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la
            //tastatura.
            // Numarul are exact 2 cifre
            Console.WriteLine("Introduceti un numar");
            int numar = int.Parse(Console.ReadLine());
            string cifre = numar.ToString();
            int rezultat = 0;
            if (cifre.Length != 2)
            {
                Console.WriteLine("Numarul introdus trebuie sa aiba 2 cifre!");
            }
            else
            {
                rezultat = int.Parse(cifre[0].ToString()) + int.Parse(cifre[1].ToString());
                Console.WriteLine("Suma cifrelor numarului introdus este " + rezultat);
            }

            ////varianta profesorului

            //Console.WriteLine("Introduceti primul numar");
            //int x = int.Parse(Console.ReadLine());

            //int sumaCifrelor = x / 10 + x % 10;

            //Console.WriteLine("suma cifrelor este " + sumaCifrelor);
        }
    }
}
