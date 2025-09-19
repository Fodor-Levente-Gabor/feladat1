using System;

class Program 
{
    static void Main(string[] args)
    {
        string[] tasks = {"Páros vagy páratlan szám", "Pozitív, negatív vagy nulla", "Évszak meghatározása hónap alapján", "Szavazati jog eldöntése", "Jeles vagy elégtelen", "Számkitaláló – egyenlő vagy nagyobb/kisebb", "Páros és pozitív ellenőrzés", "Betű vagy szám karakter", "Belépés jelszóval", "Három szám közül a legnagyobb", "Három szám közül a legnagyobb"};
        bool run = true;
        int num1 = 0;
        while (run)
        { 
            for (int a = 0; a < 44; a++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine($"{a+1}. {tasks[a]}");
                
                
            }
            Console.WriteLine("0. Program bezárása");
            Console.Write("Válassz műveletet számmal: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            for (int a = 0; a < 44; a++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
             
            //Console.Clear();
            switch (num1)
            {
                case 0:
                    run = false;
                    break;
                case 1:
                    Function1();
                    break;
                case 2:
                    Function2();
                    break;
                case 3:
                    Function3();
                    break;
                case 4:
                    Function4();
                    break;
                case 5:
                    Function5();
                    break;
                case 6:
                    Function6();
                    break;
                case 7:
                    Function7();
                    break;
                case 8:
                    Function8();
                    break;
                case 9:
                    Function9();
                    break;
                case 10:
                    Function10();
                    break;
            }
        }
    }

    static void Function1() {
        Console.Write("Adj meg egy számot: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num2 % 2 == 0) 
        {
            Console.WriteLine($"{num2} páros szám.");
        }
        else
        {
            Console.WriteLine($"{num2} páratlan szám.");
        }
    }
    static void Function2() {
        Console.Write("Adj meg egy számot: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        if (num3 == 0)
        {
            Console.WriteLine($"{num3} nulla.");
        }
        else if (num3 > 0)
        {
            Console.WriteLine($"{num3} pozitív szám.");
        }
        else
        { 
            Console.WriteLine($"{num3} negatív szám.");
        }
    }
    static void Function3() {
        Console.Write("Adj meg egy számot, majd kiírom hogy melyik hónap: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        if (num4 == 1)
        {
            Console.WriteLine($"{num4}. hónap Január.");
        }
        else if (num4 == 2)
        {
            Console.WriteLine($"{num4}. hónap Február.");
        }
        else if (num4 == 3)
        {
            Console.WriteLine($"{num4}. hónap Március.");
        }
        else if (num4 == 4)
        {
            Console.WriteLine($"{num4}. hónap Április.");
        }
        else if (num4 == 5)
        {
            Console.WriteLine($"{num4}. hónap Május.");
        }
        else if (num4 == 6)
        {
            Console.WriteLine($"{num4}. hónap Június.");
        }
        else if (num4 == 7)
        {
            Console.WriteLine($"{num4}. hónap Július.");
        }
        else if (num4 == 8)
        {
            Console.WriteLine($"{num4}. hónap Augusztus.");
        }
        else if (num4 == 9)
        {
            Console.WriteLine($"{num4}. hónap Szeptember.");
        }
        else if (num4 == 10)
        {
            Console.WriteLine($"{num4}. hónap Október.");
        }
        else if (num4 == 11)
        {
            Console.WriteLine($"{num4}. hónap November.");
        }
        else if (num4 == 12)
        {
            Console.WriteLine($"{num4}. hónap December.");
        }
    }
    static void Function4() {
        Console.Write("Add meg hány éves vagy: ");
        int num5 = Convert.ToInt32(Console.ReadLine());
        if (num5 < 18 )
        {
            Console.WriteLine($"{num5} évesen nincs jogod szavazni.");
        }
        else
        { 
            Console.WriteLine($"{num5} van szavazati jogod.");
        }
    }
    static void Function5()
    {
        Console.Write("Adj meg egy érdem jegyet: ");
        int num6 = Convert.ToInt32(Console.ReadLine());
        if (num6 == 1 || num6 == 2)
        {
            Console.WriteLine("Elégtelen.");
        }
        else if (num6 == 3)
        {
            Console.WriteLine("Elégséges.");
        }
        else if (num6 == 4)
        {
            Console.WriteLine("Jó.");
        }
        else
        {
            Console.WriteLine("Jeles.");
        }
    }
    static void Function6() {
        int num7 = 7;
        Console.Write("Találd ki a számot 1 és 10 között: ");
        int num8 = Convert.ToInt32(Console.ReadLine());
        if (num8 == num7)
        {
            Console.WriteLine($"Igen a szám a {num7} volt.");
        }
        else
        {
            Console.WriteLine($"A szám a {num7} volt.");
        }
    }
    static void Function7() {
        Console.Write("Adj meg egy számot: ");
        int num9 = Convert.ToInt32(Console.ReadLine());
        if (num9 % 2 == 0 || num9 > 0 )
        {
            Console.WriteLine($"{num9} szám pozitív és páros is.");
        }
        else
        {
            Console.WriteLine($"{num9} nem pozitív vagy nem páros.");
        }
    }
    static void Function8() {
        Console.Write("Adj meg valamilyen értéket: ");
        string data1 = "null";
        data1 = Console.ReadLine();
        int num10;
        bool isDecimal = int.TryParse(data1, out num10);
        if (isDecimal) 
        {
            Console.WriteLine($"{data1}, szám érték.");
        }
        else
        {
            Console.WriteLine($"{data1}, szöveg érték.");
        }
    }
    static void Function9() {
        Console.WriteLine("Add meg a szupertitkos jelszót: ");
        string data2 = Console.ReadLine();
        if (data2 == "titkos123")
        {
            Console.WriteLine("Helyes jelszó.");
        }
        else
        { 
            Console.WriteLine("Helytelen jelszó.");
        }
    }
    static void Function10() {
        Console.Write("Add meg az első számot: ");
        int num11 = 1;
        num11 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Add meg az első számot: ");
        int num12 = 1;
        num12 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Add meg az első számot: ");
        int num13 = 1;
        num13 = Convert.ToInt32(Console.ReadLine());
        if (num11 > num12 || num11 > num13)
        {
            Console.WriteLine($"{num11} a legnagyobb szám.");
        }
        else if (num12 > num13)
        {
            Console.WriteLine($"{num12} a legnagyobb szám.");
        }
        else
        {
            Console.WriteLine($"{num13} a legnagyobb szám.");
        }
    }
    
}