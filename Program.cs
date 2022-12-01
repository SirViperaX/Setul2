using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Setul2
{
    internal class Program
    {
        static void p1()
        {
            int nr = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    nr++;
            }
            Console.WriteLine("Sunt " + nr + " numere pare in secventa data");
        }
        static void p2()
        {
            int nrpoz = 0;
            int nrneg = 0;
            int nrzero = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                    nrneg++;
                if (x > 0)
                    nrpoz++;
                if (x == 0)
                    nrzero++;
            }
            Console.WriteLine("Sunt " + nrpoz + " numere pozitive in secventa data");
            Console.WriteLine("Sunt " + nrneg + " numere negative in secventa data");
            Console.WriteLine("Sunt " + nrzero + " numere zero in secventa data");
        }
        static void p3()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong p = 1;
            ulong s = 0;
            for (ulong i = 1; i <= n; i++)
            {
                s += i;
                p *= i;
            }
            Console.WriteLine("Suma numerelor de la 1 pana la " + n + " este " + s);
            Console.WriteLine("Produsul numerelor de la 1 pana la " + n + " este " + p);
        }
        static void p4()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int poz = -1;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == a)
                    poz = i;
            }
            if (poz == -1)
                Console.WriteLine(poz);
            else
                Console.WriteLine("Pozitia lui " + a + " este " + poz);
        }
        static void p5()
        {
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == i)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
        }
        static void p6()
        {
            int n = int.Parse(Console.ReadLine());
            bool ok = true;
            int x1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                    ok = false;
                x1 = x2;
            }
            if (ok)
                Console.WriteLine($"Numerele sunt in ordine crescatoare");
            else
                Console.WriteLine($"Numerele nu sunt in ordine crescatoare");
        }
        static void p7()
        {
            int n = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (min == 0)
                {
                    min = x;
                }
                if (x < min)
                {
                    min = x;
                }
                if (x > max)
                {
                    max = x;
                }
            }
            Console.WriteLine($"Minimul sirului este {min}, iar maximul sirului este {max}");
        }
        static void p8()
        {
            int n = int.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int fn = 0;
            for (int i = 2; i <= n; i++)
            {
                fn = f2 + f1;
                f1 = f2;
                f2 = fn;
            }
            Console.WriteLine($"{fn}");
        }
        static void p9()
        {
            int n = int.Parse(Console.ReadLine());
            bool ok = true;
            bool ok1 = true;
            int x1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());