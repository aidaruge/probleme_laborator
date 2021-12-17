using System;

namespace probleme_laborator
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            //P18();
            //P19();
            //P20();
            //P21();
            //P22();
            //P23();
            //P24();
            //P25();
            //P26();
            //P27();
            //P28();
            //P29();
            //P30();
            //P31();
            //P32();
            //P33();
            //P34();
            //P35();
            //P36();
            //P37();
            //P38();
            //P39();
            //P40();
            //P41();
            //P42();
            //P43();
            //P44();
            //P45();
            //P46();
            //P47();
            //P48();
            //P49();
            //P50();
            //P51();
            //P52();
            //P53();
            //P54();
            //P55();
            //P56();
            //P57();
            //P58();
            //P59();
            //P60();
            //P61();
            //P62();
            //P63();
            //P64();
            //P5_II();
            //P3_II();
            //P4_II();
            //P1_II();
            //P2_II();
        }

        private static void P1()
        {
            int x, grade;
            Console.WriteLine("Introduceti nr de grade si cazul");
            grade = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 'C':
                    Console.WriteLine(grade * 1.8 + 32);
                    break;
                case 'F':
                    Console.WriteLine((grade - 32) / 1.8);
                    break;

            }
        }
        private static void P2()
        {
            int numar1, numar2;
            char operatie;
            operatie = char.Parse(Console.ReadLine());

            switch (operatie)
            {
                case '+':
                    {
                        numar1 = int.Parse(Console.ReadLine());
                        numar2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Adunarea este {numar1 + numar2}");
                        break;
                    }
                case '-':
                    {
                        numar1 = int.Parse(Console.ReadLine());
                        numar2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Scaderea este {numar1 - numar2}");
                        break;
                    }
                case '*':
                    {
                        numar1 = int.Parse(Console.ReadLine());
                        numar2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Inmultirea este {numar1 * numar2}");
                        break;
                    }
                case '/':
                    {
                        numar1 = int.Parse(Console.ReadLine());
                        numar2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Inmultirea este {numar1 / numar2}");
                        break;
                    }
                case '!':
                    {
                        numar1 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"radicalul este egal cu {Math.Sqrt(numar1)}");
                        break;
                    }
                case '|':
                    {
                        numar1 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"radicalul este egal cu {Math.Abs(numar1)}");
                        break;
                    }
            }

        }
        private static void P3()
        {
            int i, j, k;
            double nr;
            i = int.Parse(Console.ReadLine());
            j = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            nr = Math.Pow(i, j);
            Console.WriteLine(nr % k);
        }
        private static void P4()
        {
            int nr, d, k;
            nr = int.Parse(Console.ReadLine());
            k = 0;
            for (d = 1; d < nr; d++)
            {
                if (nr % d == 0)
                    k = k + d;
            }

            if (nr == k)
                Console.WriteLine($"{nr} este numar perfect");
        }
        private static void P5()
        {
            int a, b, i, d, k;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            for (i = a; i <= b; i++)
            {
                k = 0;
                for (d = 1; d < i; d++)
                {
                    if (i % d == 0)
                        k = k + d;
                }
                if (i == k)
                    Console.Write($"{i} ");

            }
        }
        private static void P6()
        {
            int x, y, d, k, j;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for(x=a; x<=b-1; x++)
            {
                k = 0;
                for (d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                        k = k + d;
                }
                for(y=x+1; y<=b; y++)
                {
                    j = 0;
                    for (d = 1; d <= y; d++)
                    {
                        if (y % d == 0)
                            j = j + d;
                    }
                    if (k == j)
                        Console.WriteLine($"{x}, {y}");
                }
            }
        }

        private static void P7()
        {
            int n, k, i, factn, factk, factnk, combinari;

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            factn = factk = factnk = 1;
            if (n < k)
            {
                Console.WriteLine("Nu exista factorial!");
            }
            for (i = 1; i <= n; i++)
            {
                factn = factn * i;
            }
            for (i = 1; i <= k; i++)
            {
                factk = factk * i;
            }
            for (i = 1; i <= n - k; i++)
            {
                factnk = factnk * i;
            }
            combinari = factn / factk * factnk;
            Console.WriteLine(combinari);
        }
        private static void P8()
        {
            int n, i, suma = 0, produs = 1, nrdiv = 0;
            double ma, mg, mh;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    nrdiv++;
                    suma = suma + i;
                    produs = produs * i;
                }
            }
            ma = suma / nrdiv;
            mg = Math.Sqrt(produs);
            mh = mg / ma;

        }
        private static void P9()
        {
            ///cmmdc
            int a, b, n, m;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = a;
            m = b;
            while (n != m)
            {
                if (n > m)
                    n = n - m;
                else
                    m = m - n;
            }
            Console.WriteLine($"cmmdc e {n}");
            ///cmmmc
            n = a;
            m = b;
            while (n != m)
            {
                if (n < m)
                    n = n + a;
                else
                    m = m + b;
            }
            Console.WriteLine($"cmmmc e {n}");

        }
        private static void P10()
        {
            int n, i, numar, nr = 0, ok;

            n = int.Parse(Console.ReadLine());
            if (n >= 1)
            {
                Console.WriteLine("2 ");
                nr = 1;
            }
            for (numar = 3; numar <= int.MaxValue; numar++)
            {
                ok = 1;
                for (i = 2; i <= numar / 2; i++)
                {
                    if (numar % i == 0)
                        ok = 0;
                }
                if (ok == 1)
                {
                    nr++;
                    if (nr <= n)
                        Console.WriteLine($"{numar} ");
                }
            }

        }
        private static void P11()
        {
            int x, y, r;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            r = x % y;
            while (x * y != 0)
            {
                x = y;
                y = r;
                r = x % y;
            }
            if (y == 1)
                Console.WriteLine("Numerele sunt prime intre ele");
            else
                Console.WriteLine("Numerele nu sunt prime intre ele");
        }
        private static void P12()
        {
            float gradeC, gradeF;
            for (gradeF = 0; gradeF <= 300; gradeF++)
            {
                gradeC = (gradeF - 32) / (9 / 5);
                Console.WriteLine($"{gradeF} = {gradeC}");
            }
        }
        private static void P13()
        {
            float gradeC, gradeF;
            for (gradeC = 0; gradeC <= 300; gradeC++)
            {
                gradeF = (9 / 5) * gradeC + 32;
                Console.WriteLine($"{gradeF} = {gradeC}");
            }
        }
        private static void P14()
        {
            int x, minim = int.MaxValue, maxim = int.MinValue;
            x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                if (x > maxim)
                    maxim = x;
                if (x < minim)
                    minim = x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Minimul e {minim}, maximul e {maxim}");
        }
        private static void P15()
        {
            int n;
            long p = 1;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                p = p * n;
                n--;
            }
            Console.WriteLine(p);
        }
        private static void P16()
        {
            int r, n;
            long randuri;
            r = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            randuri = 2 * (r * n);
            Console.WriteLine($"Cartea are {randuri} randuri.");
        }
        private static void P17()
        {
            int x0, t0, x, t;
            float v;
            x0 = int.Parse(Console.ReadLine());
            t0 = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());
            v = (x - x0) / (t - t0);
            Console.WriteLine(v);
        }
        private static void P18()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriti sa calculam?");
            int x;
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine((a + b) / 2);
                    break;
                case 2:
                    if (a > 0 && b > 0)
                        Console.WriteLine(Math.Sqrt(a * b));
                    else
                        Console.WriteLine("eroare!");
                    break;
            }
        }
        private static void P19()
        {
            int a, b, c;
            int x;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("ce doriti sa calculam?");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:

                    break;
            }
        }
        private static void P20()
        {
            int n, s = 0, nr = 0;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                nr++;
                s = s + n;
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(s / nr);
        }
        private static void P21()
        {
            int n, k, p, nr = 0, x;
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                x = int.Parse(Console.ReadLine());
                n--;
                if (x % p == k)
                    nr++;
            }
            Console.WriteLine(nr);
        }
        private static void P22()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = b;
            a--;
            while (a > 0)
            {
                b = b + c;
                a--;
            }
            Console.WriteLine(b);
        }
        private static void P23()
        {
            int a, b, aux, nr = 0, r;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            while (a - b > 0)
            {
                nr++;
                a = a - b;
            }
            r = b - a;
            Console.WriteLine($"{nr}, {r}");
        }
        private static void P24()
        {
            int n, nr = 0;
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                n = n / 10;
                nr++;
            }
            Console.WriteLine(nr);
        }
        private static void P25()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int ogl = 0, x = 0;
            x = n;
            while (n != 0)
            {
                ogl = ogl * 10 + n % 10;
                n = n / 10;
            }
            if (x == ogl)
                Console.WriteLine($"{x} este palindrom");
            else
                Console.WriteLine($"{x} nu este palindrom");
        }
        private static void P26()
        {
            int n, numar, ok, i;

            n = int.Parse(Console.ReadLine());

            for (numar = 2; numar <= n; numar++)
            {
                ok = 1;
                for (i = 2; i <= numar / 2; i++)
                {
                    if (numar % i == 0)
                        ok = 0;
                }
                if (ok == 1)
                {
                    Console.WriteLine($"{numar} ");
                }
            }
        }
        private static void P27()
        {
            int n, m, numar, suma, ok, i, nr = 0;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            for (numar = 2; numar <= int.MaxValue; numar++)
            {
                ok = 1;
                suma = 0;
                for (i = 2; i <= numar / 2; i++)
                {
                    if (numar % i == 0)
                        ok = 0;
                }
                if (ok == 1)
                {
                    int x = numar;
                    nr++;
                    while (x > 0)
                    {
                        suma = suma + x % 10;
                        x = x / 10;
                    }
                }
                if (ok == 1 && nr <= n && suma < m)
                {
                    Console.WriteLine($"{numar} ");
                }
            }
        }
        private static void P28()
        {
            static bool oglind(int numar)
            {
                int n, oglindit = 0;
                n = numar;
                while (n != 0)
                {
                    oglindit = oglindit * 10 + n % 10;
                    n = n / 10;
                }
                if (numar == oglindit)
                    return true;
                else
                    return false;
            }
            int numar, ok, i;

            for (numar = 100; numar <= 999; numar++)
            {
                ok = 1;
                for (i = 2; i <= numar / 2; i++)
                {
                    if (numar % i == 0)
                        ok = 0;
                }
                if (ok == 1 && oglind(numar))
                {
                    Console.WriteLine($"{numar} ");
                }
            }
        }
        private static void P29()
        {
            int n, numar, nr = 0;
            n = int.Parse(Console.ReadLine());
            int sumacifr(int n)
            {
                int s = 0;
                while (n != 0)
                {
                    s = s + n % 10;
                    n = n / 10;
                }
                return s;
            }
            for (numar = 1; numar <= int.MaxValue; numar++)
            {
                if (sumacifr(numar) % 5 == 0)
                {
                    nr++;
                    if (nr <= n)
                        Console.WriteLine(numar);
                }

            }
        }
        private static void P30()
        {
            //numărul n de cifre ale numărului în baza b
            int b, n;
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int rez = 0;
            for (int i = 1; i <= n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                rez = rez * b + x;
            }
            Console.WriteLine(rez);
        }
        private static void P31()
        {
            //la fel ca 26.
        }
        private static void P32()
        {
            //la fel ca 27.
        }
        private static void P33()
        {
            //la fel ca 28.
        }
        private static void P34()
        {
            double pi = Math.PI;
            int x;
            x = int.Parse(Console.ReadLine());
            double radianiIngrade(double x)
            {
                x = x * (180 / pi);
                return x;
            }
            Console.WriteLine(radianiIngrade(x));
            x = int.Parse(Console.ReadLine());
            double gradeInradiani(double x)
            {
                x = x * (pi / 180);
                return x;
            }
            Console.WriteLine(gradeInradiani(x));
        }
        private static void P35()
        {
            int n, k = 1, x, ok = 0;
            n = int.Parse(Console.ReadLine());
            x = 2;
            while (ok == 0)
            {
                if (n % x == 0)
                {
                    ok = 1;
                    k = n / x;
                    if (k < x)
                    {
                        int aux = x;
                        x = k;
                        k = aux;
                    }
                }
                else
                    x++;
            }
            Console.WriteLine($"{x}, {k}");
        }
        private static void P36()
        {
            int n, s = 0;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.Write($"{n % 10}, ");
                s = s + n % 10;
                n = n / 10;
            }
            Console.WriteLine(s);
        }
        private static void P37()
        {
            int n, a, b, c = 0, i;
            n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.Write(1);
            if (n == 1)
                Console.Write(1);
            if (n >= 3)
            {
                a = 1;
                b = 1;
                Console.Write($"{a} {b} ");
                for (i = 3; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.Write($"{c} ");
                }
            }
        }
        private static void P38()
        {
            int n;
            long p = 1;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                p = p * n;
                n--;
            }
            Console.WriteLine(p);
        }
        private static void P39()
        {
            Console.WriteLine("Moment 1");
            int OraStart, MinutStart, SecundaStart;
            OraStart = int.Parse(Console.ReadLine());
            MinutStart = int.Parse(Console.ReadLine());
            SecundaStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Moment 2");
            int OraStop, MinutStop, SecundaStop;
            OraStop = int.Parse(Console.ReadLine());
            MinutStop = int.Parse(Console.ReadLine());
            SecundaStop = int.Parse(Console.ReadLine());
            int DifO, DifM, DifS;
            if(SecundaStop<SecundaStart)
            {
                SecundaStop += 60;
                MinutStop--;
            }
            if(MinutStop<MinutStart)
            {
                MinutStop += 60;
                OraStop--;
            }
            DifS = SecundaStop - SecundaStart;
            DifM = MinutStop - MinutStart;
            DifO = OraStop - OraStart;
            Console.WriteLine($"{DifO}:{DifM}:{DifS}");
        }
        private static void P40()
        {
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine($"{v} m/s = {v * 18 / 5} km/h");
        }
        private static void P41()
        {
            int n, m;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine(n / m);
        }
        private static void P42()
        {
            int x, i, ok;
            ok = 0;
            x = int.Parse(Console.ReadLine());
            for (i = 1; i * i * i <= x; i++)
            {
                if (i * i * i == x)
                    ok = 1;
            }
            if (ok == 0)
            {
                for (i = -1; i * i * i <= x; i--)
                {
                    if (i * i * i == x)
                        ok = 1;
                }
            }
            if (ok == 1)
                Console.WriteLine("DA");
            else
                Console.WriteLine("NU");
        }
        private static void P43()
        {
            int[] a = { 9, 10, 20, 8, 7 };
            for (int i = 0; i < 5; i++)
            {
                a[i] = a[i] * a[i];
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
        private static void P44()
        {
            int n, i, rez;
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                rez = n * i;
                Console.WriteLine($"{n}*{i}={rez}");
            }
        }
        private static void P45()
        {
            int[] a = { 9, 10, 20, 8, 7, 5, 1};
            for (int i = 6; i >= 0; i--)
                Console.Write($"{a[i]} ");
        }
        private static void P46()
        {
            //la fel ca 25.
        }
        private static void P47()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for(int i=0; i<n; i++)
            {
                v[i] = rnd.Next(1, 99);
            }
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (v[i] == v[j])
                        Console.WriteLine(v[i]);

        }
        private static void P48()
        {
            int i=0, j=0, n;
            int[,] a;
            int[,] b;
            int[,] c;
            n = int.Parse(Console.ReadLine());
            a = new int[i, j];
            b = new int[i, j];
            c = new int[i, j];
            Random rnd = new Random();

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = rnd.Next(1, 1000);
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    b[i, j] = rnd.Next(1, 1000);
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    c[i, j] = a[i, j] + b[i, j];
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    Console.Write($"{c[i, j] }");
        }
        private static void P49()
        {
            int n, i, nr=0, suma=0;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 1000);
            }
            for(i=0; i<n; i++)
            {
                if(v[i]%2==0)
                {
                    nr++;
                    suma = suma + v[i];
                }
            }
            Console.WriteLine(suma / nr);
        }
        private static void P50()
        {
            int n, i, ok=1;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 1000);
            }
            for (i = 0; i < n - 1; i++)
            {
                if (v[i] > v[i + 1])
                    ok = 0;
            }
            if (ok == 1)
                Console.WriteLine("sirul este ordonat crescator!");
            else
                Console.WriteLine("sirul nu este ordonat crescator!");
        }
        private static void P51()
        {
            int n, i, minim=int.MaxValue;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 1000);
            }
            for (i = 0; i < n; i++)
            {
                if (v[i] < minim)
                    minim = v[i];
            }
            Console.WriteLine(minim);
        }
        private static void P52()
        {
            int n, i, ok = 1;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 1000);
            }
            for (i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                    ok = 0;
            }
            if (ok == 1)
                Console.WriteLine("sirul are doar elemente impare!");
            else
                Console.WriteLine("sirul nu are doar elemente impare!");
        }
        private static void P53()
        {
            int n, i, ok = 1;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 1000);
            }
            for (i = 0; i < n; i++)
            {
                if (v[i] % 2 != 0)
                    ok = 0;
            }
            if (ok == 1)
                Console.WriteLine("sirul are doar elemente pare!");
            else
                Console.WriteLine("sirul nu are doar elemente pare!");
        }
        private static void P54()
        {
            int n, i, nrpar=0, nrimpar=0;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 1000);
            }
            for (i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                    nrpar++;
                else
                    nrimpar++;
            }
            Console.WriteLine(nrpar / nrimpar);
        }
        private static void P55()
        {
            int n, i, suma = 0;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 1000);
            }
            for (i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    suma = suma + v[i];
                else
                    suma = suma - v[i];
            }
        }
          private static void P56()
          {
            int n, i;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            v[0] = 1;
            v[1] = 1;
            Console.Write($"{v[0]}, {v[1]} ");
            for (i=2; i<n; i++)
            {
                v[i] = v[i - 1] + v[i - 2];
                Console.Write($"{v[i]}, ");
            }
          }
        private static void P57()
        {
            int n, i;
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for(i=1; i<n-1; i++)
            {
                if (v[i] == (v[i - 1] + v[i + 1]) / 2 && (v[i - 1] + v[i + 1]) % 2 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                    Console.WriteLine("nu exista");
            }
        }
        private static void P58()
        {
            int n, i, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 1000);
            }
            for (i = n-1; i >= 0; i--)
            {
                if(v[i]==k)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                    Console.WriteLine("nu exista");
            }
        }
        private static void P59()
        {
            int n, i, poz;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(i=0; i<n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("introduceti poz:");
            poz = int.Parse(Console.ReadLine());
            for (i=poz; i<n-1; i++)
            {
                v[i] = v[i + 1];
            }
            for (i = 0; i < n - 1; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P60()
        {
            int n, i, k, nr=0;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            k = int.Parse(Console.ReadLine());
            for (i=0; i<n; i++)
            {
                if(v[i]==k)
                {
                    nr++;
                    for(int j=i; j<n-nr; j++)
                    {
                        v[j] = v[j + 1];
                    }
                }
            }
            for(i=0; i<n-nr; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P61()
        {
            int n, i, k, x;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n+1];
            
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti k:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti x:");
            x = int.Parse(Console.ReadLine());

            for (i=n; i>k; i--)
            {
                v[i] = v[i - 1];
            }
            v[k] = x;
            for(i=0; i<n+1; i++)
            { 
                Console.Write($"{v[i]} ");
            }
        }
        private static void P62()
        {
            int n, i, p1, p2, media;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti pozitiile:");
            p1 = int.Parse(Console.ReadLine());
            p2 = int.Parse(Console.ReadLine());
            media = (v[p1] + v[p2]) / 2;
            for (i = n; i > p2; i--)
            {
                v[i] = v[i - 1];
            }
            v[p2] = media;
            for (i = 0; i < n + 1; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
        private static void P63()
        {
            int n, i, k, nr=0;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] u = new int[n];
            for(i=0; i<n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("introduceti nr k:");
            k = int.Parse(Console.ReadLine());
            int j = 0;
            for (i=0; i<n; i++)
            {
                if(v[i]%10==k)
                {
                    u[j] = v[i];
                    j++;
                    nr++;
                }    
            }
            for (j = 0; j < nr; j++)
                Console.Write($"{u[j]} ");
        }
        private static void P64()
        {
            int n, i, j;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] u = new int[n];
            for(i=0; i<n; i++)
                v[i] = int.Parse(Console.ReadLine());
            j = 0;
            for(i=0; i<n; i++)
            {
                if(v[i]%2==0)
                {
                    u[j] = v[i];
                    j++;
                }
            }
            for(i=0; i<n; i++)
            {
                if(v[i]%2!=0)
                {
                    u[j] = v[i];
                    j++;
                }
            }
            for (i = 0; i < j; i++)
                Console.Write($"{u[i]} ");
        }
        private static void P5_II()
        {
            int n, i, j;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (i = 0; i < n - 1; i++)
                for (j = 0; j < n - i - 1; j++)
                    if (v[j] > v[j + 1])
                    {
                        int aux = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = aux;
                    }
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P3_II()
        {
            int n, i;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int ok = 1;
            while (ok == 1)
            {
                ok = 0;
                for (i = 0; i < (n / 2) - 1; i++)
                    if (v[i] > v[i + 1])
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = 1;
                    }
            }
            ok = 1;
            while (ok == 1)
            {
                ok = 0;
                for (i = n / 2; i < n - 1; i++)
                    if (v[i] < v[i + 1])
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = 1;
                    }
            }

            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
        private static void P4_II()
        {
            int n, i, m, x, nr=0;
            m = 10;
            int[] v = new int[m];
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                x = int.Parse(Console.ReadLine());
                v[x]++;
                n--;
            }
            for(i=0; i<=9; i++)
            {
                if (v[i] % 2 != 0)
                    nr++;
            }
            if (nr > 1)
                Console.WriteLine("Nu se poate obtine un sir palindrom");
            else
                Console.WriteLine("Se poate obtine un sir palindrom");
        }
        private static void P1_II()
        {
            int n, i, j;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
                for (j = 0; j < n - 1; j++)
                    if (v[i] == v[j] + v[j + 1])
                        Console.WriteLine(v[i]);
        }
        private static void P2_II()
        {
            int n, i, j, nr=0;
            Console.WriteLine("introduceti n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int m= n;
            int[] u = new int[m];
            for (i = 0; i < n; i++)
                u[i] = v[i];
            Console.WriteLine("u[i]:");
            for (i = 0; i < n; i++)
                Console.WriteLine($"{u[i]} ");
            int ok = 1;
            while(ok==1)
            {
                ok = 0;
                for(i=0; i<n-1; i++)
                    if(v[i]<v[i+1])
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = 1;
                    }
            }
            Console.WriteLine("v[i]:");
            for (i = 0; i < n; i++)
                Console.WriteLine($"{v[i]} ");

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    if (v[i] == u[i] && i==j)
                        nr++;
            Console.WriteLine(nr);
        }
    } 

}
