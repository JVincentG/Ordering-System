using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Orderingsystem
{

    class Program

    {
        private static string username, username1, password1, pass,
        stock1, stock2, stock3, stock4, stock5, stock6, stock7, stock8,
           price1, price2, price3, price4, price5, price6, price7, price8 = string.Empty;
        private static double
            cost1, cost2, cost3, cost4, cost5, cost6, cost7, cost8, costs1, costs2, costs3,costs4,costs5, tcost,
            cost11, cost22, cost33, cost44, cost55, cost66, cost77, cost88,
             cost111, cost222, cost333, cost444, cost555, cost666, cost777, cost888,
            cost1111, cost2222, cost3333, cost4444, cost5555, cost6666, cost7777, cost8888,
            cost11111, cost22222, cost33333, cost44444, cost55555, cost66666, cost77777, cost88888;
        static void Main()
        {
            /** Console.WriteLine("Now we Create a new user");
              string username, password = string.Empty;
              Console.Write("Enter a username: ");
              username = Console.ReadLine();
              Console.Write("Enter a password: ");
              password = Console.ReadLine();

              using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\admin.txt")))
              {
                  sw.WriteLine(username);
                  sw.WriteLine(password);
                  sw.Close();
              }
              Console.WriteLine("Done..");
              Console.Clear();**/

            Log();
            Console.Read();
        }


        static void Log()
        {
            Console.WriteLine("Login Account");


            int loginAttempts = 0;

            //Simple iteration upto three times
            for (int i = 0; i < 3; i++)
            {

                Console.Write("Username: ");

                username = Console.ReadLine();

                Console.Write("Password: ");
                pass = "";
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);
                Console.WriteLine();


                using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\admin.txt", FileMode.Open)))
                {
                    username1 = sr.ReadLine();
                    password1 = sr.ReadLine();
                    sr.Close();

                }

                if (username == username1 && pass == password1)

                {
                    Console.WriteLine("Login successful");
                    Console.ReadLine();
                    Console.Clear();
                    Order();
                }
                if (username != username1 || pass != password1)
                    loginAttempts++;
                else
                    break;
                Console.WriteLine("Login failure");
                Console.ReadLine();
                Console.Clear();
            }

            //Display the result
            if (loginAttempts > 2)

            {
                Console.WriteLine("Max Attempt Used");
                Console.ReadLine();
                Console.Clear();
            }








        }
        static void Order()
        {

            Console.WriteLine("Welcome to Venters Shawarma");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Order ");
            Console.WriteLine("2. Add Stocks");
            Console.WriteLine("3. Change Price");
            Console.WriteLine("4. Change password");
            Console.WriteLine("5. Exit");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (num)
            {
                case 1:

                    order1();
                    break;
                case 2:
                    stocks();
                    Console.WriteLine("Shawarma           Stocks");
                    Console.WriteLine("1. Beef Shawarma    " + stock1);
                    Console.WriteLine("2. Chicken Shawarma " + stock2);
                    Console.WriteLine("3. Shawarma Rice    " + stock3 + "\n");
                    Console.WriteLine("Add On");
                    Console.WriteLine("4. Egg              " + stock4);
                    Console.WriteLine("5. Cheese           " + stock5);
                    Console.WriteLine("6. Meat             " + stock6);
                    Console.WriteLine("7. Softdrinks       " + stock7);
                    Console.WriteLine("8. Bottled Water    " + stock8);
                    Console.WriteLine("9. Exit");
                    int num2 = int.Parse(Console.ReadLine());
                    switch (num2)
                    {
                        case 1:
                            stocks();
                            Console.WriteLine("How Many Beef Shawarma?");
                            int qty11 = int.Parse(Console.ReadLine());
                            int ntstock1 = int.Parse(stock1);
                            int stock11 = qty11 + ntstock1;

                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock1.txt")))
                            {
                                sw.WriteLine(stock11);
                                sw.Close();
                            }
                            Console.WriteLine("Stock Added Succesfully");
                            Console.ReadKey();

                            Console.Clear();
                            Order();
                            break;
                        case 2:
                            stocks();
                            Console.WriteLine("How Many Chicken Shawarma?");
                            int qty22 = int.Parse(Console.ReadLine());
                            int ntstock2 = int.Parse(stock2);
                            int stock22 = qty22 + ntstock2;
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                            {
                                sw.WriteLine(stock22);
                                sw.Close();
                            }
                            Console.WriteLine("Stock Added Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 3:
                            stocks();
                            Console.WriteLine("How Many Shawarma Rice?");
                            int qty33 = int.Parse(Console.ReadLine());
                            int ntstock3 = int.Parse(stock3);
                            int stock33 = qty33 + ntstock3;
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock3.txt")))
                            {
                                sw.WriteLine(stock33);
                                sw.Close();
                            }
                            Console.WriteLine("Stock Added Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 4:
                            stocks();
                            Console.WriteLine("How Many Egg?");
                            int qty44 = int.Parse(Console.ReadLine());
                            int ntstock4 = int.Parse(stock4);
                            int stock44 = qty44 + ntstock4;
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock4.txt")))
                            {
                                sw.WriteLine(stock44);
                                sw.Close();
                            }
                            Console.WriteLine("Stock Added Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 5:
                            stocks();
                            Console.WriteLine("How Many Cheese?");
                            int qty55 = int.Parse(Console.ReadLine());
                            int ntstock5 = int.Parse(stock5);
                            int stock55 = qty55 + ntstock5;
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock5.txt")))
                            {
                                sw.WriteLine(stock55);
                                sw.Close();
                            }
                            Console.WriteLine("Stock Added Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 6:
                            stocks();
                            Console.WriteLine("How Many Meat?");
                            int qty66 = int.Parse(Console.ReadLine());
                            int ntstock6 = int.Parse(stock6);
                            int stock66 = qty66 + ntstock6;
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock6.txt")))
                            {
                                sw.WriteLine(stock66);
                                sw.Close();
                            }
                            Console.WriteLine("Stock Added Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 7:
                            stocks();
                            Console.WriteLine("How Many Softdrinks?");
                            int qty77 = int.Parse(Console.ReadLine());
                            int ntstock7 = int.Parse(stock7);
                            int stock77 = qty77 + ntstock7;
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock7.txt")))
                            {
                                sw.WriteLine(stock77);
                                sw.Close();
                            }
                            Console.WriteLine("Stock Added Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 8:
                            stocks();
                            Console.WriteLine("How Many Bottled Water?");
                            int qty88 = int.Parse(Console.ReadLine());
                            int ntstock8 = int.Parse(stock8);
                            int stock88 = qty88 + ntstock8;
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock8.txt")))
                            {
                                sw.WriteLine(stock88);
                                sw.Close();
                            }
                            Console.WriteLine("Stock Added Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 9:
                            Console.Clear();
                            Order();
                            break;
                    }
                    break;



                case 3:
                    php();
                    Console.WriteLine("Shawarma           Price");
                    Console.WriteLine("1. Beef Shawarma    " + price1);
                    Console.WriteLine("2. Chicken Shawarma " + price2);
                    Console.WriteLine("3. Shawarma Rice    " + price3);
                    Console.WriteLine("Add On");
                    Console.WriteLine("4. Egg              " + price4);
                    Console.WriteLine("5. Cheese           " + price5);
                    Console.WriteLine("6. Meat             " + price6);
                    Console.WriteLine("7. Softdrinks       " + price7);
                    Console.WriteLine("8. Bottled Water    " + price8);
                    Console.WriteLine("9. Exit");
                    int num3 = int.Parse(Console.ReadLine());
                    switch (num3)
                    {
                        case 1:
                            php();
                            Console.WriteLine("New Price of Beef Shawarma:");
                            int np1 = int.Parse(Console.ReadLine());
                           
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\price1.txt")))
                            {
                                sw.WriteLine(np1);
                                sw.Close();
                            }
                            Console.WriteLine("Price Changed Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 2:
                            php();
                            Console.WriteLine("New Price of Chicken Shawarma:");
                            int np2 = int.Parse(Console.ReadLine());
                            
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\price2.txt")))
                            {
                                sw.WriteLine(np2);
                                sw.Close();
                            }
                            Console.WriteLine("Price Changed Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            php();
                            Console.WriteLine("New Price of Shawarma Rice:");
                            int np3 = int.Parse(Console.ReadLine());
                            
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\price3.txt")))
                            {
                                sw.WriteLine(np3);
                                sw.Close();
                            }
                            Console.WriteLine("Price Changed Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 4:
                            php();
                            Console.WriteLine("New Price of Egg:");
                            int np4 = int.Parse(Console.ReadLine());
                          
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\price4.txt")))
                            {
                                sw.WriteLine(np4);
                                sw.Close();
                            }
                            Console.WriteLine("Price Changed Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 5:
                            php();
                            Console.WriteLine("New Price of Cheese:");
                            int np5 = int.Parse(Console.ReadLine());
                         
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\price5.txt")))
                            {
                                sw.WriteLine(np5);
                                sw.Close();
                            }
                            Console.WriteLine("Price Changed Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 6:
                            php();
                            Console.WriteLine("New Price of Meat:");
                            int np6 = int.Parse(Console.ReadLine());
                           
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\price6.txt")))
                            {
                                sw.WriteLine(np6);
                                sw.Close();
                            }
                            Console.WriteLine("Price Changed Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 7:
                            php();
                            Console.WriteLine("New Price of Softdrinks:");
                            int np7 = int.Parse(Console.ReadLine());
                            
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\price7.txt")))
                            {
                                sw.WriteLine(np7);
                                sw.Close();
                            }
                            Console.WriteLine("Price Changed Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 8:
                            php();
                            Console.WriteLine("New Price of Bottled Water:");
                            int np8 = int.Parse(Console.ReadLine());
                           
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\price8.txt")))
                            {
                                sw.WriteLine(np8);
                                sw.Close();
                            }
                            Console.WriteLine("Price Changed Succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            Order();
                            break;
                        case 9:
                            Console.Clear();
                            Order();
                            break;
                    }
                    break;
                case 4:
                    string oldpw = String.Empty;
                    Console.Write("Enter your old password: ");
                    oldpw = Console.ReadLine();
                    using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\admin.txt", FileMode.Open)))
                    {
                        username1 = sr.ReadLine();
                        password1 = sr.ReadLine();
                        sr.Close();
                    }

                    if (oldpw == password1)
                    {
                        Console.WriteLine("Password Matched");
                        Console.ReadKey(true);
                        Console.Clear();

                        Console.WriteLine("Enter Your New Password");
                        string newpw = Console.ReadLine();
                        Console.WriteLine("Confirm Password");
                        string conpw = Console.ReadLine();
                        if (newpw == conpw)
                        {
                            using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\admin.txt")))
                            {
                                sw.WriteLine(username);
                                sw.WriteLine(newpw);
                                sw.Close();
                            }
                            Console.WriteLine("Password Changed");
                            Console.ReadKey(true);
                            Console.Clear();
                            Log();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Password Does not match");
                            Console.ReadKey(true);
                            Console.Clear();
                            Log();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Password");
                        Console.ReadKey(true);
                        Console.Clear();
                        Log();
                    }
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }









        }
        static void admin()
        {
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\admin.txt", FileMode.Open)))
            {
                username1 = sr.ReadLine();
                password1 = sr.ReadLine();

                sr.Close();

            }
        }

        static void stocks()
        {
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\stock1.txt", FileMode.Open)))
            {

                stock1 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\stock2.txt", FileMode.Open)))
            {

                stock2 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\stock3.txt", FileMode.Open)))
            {

                stock3 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\stock4.txt", FileMode.Open)))
            {

                stock4 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\stock5.txt", FileMode.Open)))
            {

                stock5 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\stock6.txt", FileMode.Open)))
            {

                stock6 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\stock7.txt", FileMode.Open)))
            {

                stock7 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\stock8.txt", FileMode.Open)))
            {

                stock8 = sr.ReadLine();

                sr.Close();

            }
        }
        static void php()
        {
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\price1.txt", FileMode.Open)))
            {

                price1 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\price2.txt", FileMode.Open)))
            {

                price2 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\price3.txt", FileMode.Open)))
            {

                price3 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\price4.txt", FileMode.Open)))
            {

                price4 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\price5.txt", FileMode.Open)))
            {

                price5 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\price6.txt", FileMode.Open)))
            {

                price6 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\price7.txt", FileMode.Open)))
            {

                price7 = sr.ReadLine();

                sr.Close();

            }
            using (StreamReader sr = new StreamReader(File.Open("D:\\ordering\\price8.txt", FileMode.Open)))
            {

                price8 = sr.ReadLine();

                sr.Close();

            }
        }
        static void order1()
        {
            admin();
            php();
            stocks();
            Console.WriteLine("Shawarma            Price   Stocks");
            Console.WriteLine("1. Beef Shawarma    Php" + price1 + "    " + stock1);
            Console.WriteLine("2. Chicken Shawarma Php" + price2 + "    " + stock2);
            Console.WriteLine("3. Shawarma Rice    Php" + price3 + "    " + stock3 + "\n");
            Console.WriteLine("Add On");
            Console.WriteLine("4. Egg              Php" + price4 + "    " + stock4);
            Console.WriteLine("5. Cheese           Php" + price5 + "    " + stock5);
            Console.WriteLine("6. Meat             Php" + price6 + "    " + stock6);
            Console.WriteLine("7. Softdrinks       Php" + price7 + "    " + stock7);
            Console.WriteLine("8. Bottled Water    Php" + price8 + "    " + stock8);
            Console.WriteLine("9. Exit");

            int num1 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    stocks();
                    php();
                    Console.WriteLine("How Many Beef Shawarma?");
                    int qty11 = int.Parse(Console.ReadLine());
                    int ntstock1 = int.Parse(stock1);
                    int ntprice1 = int.Parse(price1);
                    int newstock1 = ntstock1 - qty11;
                    if (qty11 > ntstock1)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.ReadKey();
                        Console.Clear();
                        order1();


                    }
                    else
                    {
                        cost1 = qty11 * ntprice1;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock1.txt")))
                        {
                            sw.WriteLine(newstock1);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                        int repeat = int.Parse(Console.ReadLine());
                        switch (repeat)
                        {
                            case 1:

                                Console.Clear();
                                order2();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;

                case 2:
                    stocks();
                    php();
                    Console.WriteLine("How Many Chicken Shawarma?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock2 = int.Parse(stock2);
                    int ntprice2 = int.Parse(price2);
                    int newstock2 = ntstock2 - qty11;
                    if (qty11 > ntstock2)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.ReadKey();
                        Console.Clear();
                        order1();


                    }
                    else
                    {
                        cost2 = qty11 * ntprice2;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                        {
                            sw.WriteLine(newstock2);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                        int repeat2 = int.Parse(Console.ReadLine());
                        switch (repeat2)
                        {
                            case 1:

                                Console.Clear();
                                order2();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 3:
                    stocks();
                    php();
                    Console.WriteLine("How Many Shawarma Rice?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock3 = int.Parse(stock3);
                    int ntprice3 = int.Parse(price3);
                    int newstock3 = ntstock3 - qty11;
                    if (qty11 > ntstock3)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.ReadKey();
                        Console.Clear();
                        order1();


                    }
                    else
                    {
                        cost3 = qty11 * ntprice3;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock3.txt")))
                        {
                            sw.WriteLine(newstock3);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                        int repeat3 = int.Parse(Console.ReadLine());
                        switch (repeat3)
                        {
                            case 1:

                                Console.Clear();
                                order2();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 4:
                    stocks();
                    php();
                    Console.WriteLine("How Many Egg?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock4 = int.Parse(stock4);
                    int ntprice4 = int.Parse(price4);
                    int newstock4 = ntstock4 - qty11;
                    if (qty11 > ntstock4)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.ReadKey();
                        Console.Clear();
                        order1();


                    }
                    else
                    {
                        cost4 = qty11 * ntprice4;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock4.txt")))
                        {
                            sw.WriteLine(newstock4);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                        int repeat4 = int.Parse(Console.ReadLine());
                        switch (repeat4)
                        {
                            case 1:

                                Console.Clear();
                                order2();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 5:
                    stocks();
                    php();
                    Console.WriteLine("How Many Cheese?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock5 = int.Parse(stock5);
                    int ntprice5 = int.Parse(price5);
                    int newstock5 = ntstock5 - qty11;
                    if (qty11 > ntstock5)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.ReadKey();
                        Console.Clear();
                        order1();


                    }
                    else
                    {
                        cost5 = qty11 * ntprice5;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock5.txt")))
                        {
                            sw.WriteLine(newstock5);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                        int repeat5 = int.Parse(Console.ReadLine());
                        switch (repeat5)
                        {
                            case 1:

                                Console.Clear();
                                order2();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 6:
                    stocks();
                    php();
                    Console.WriteLine("How Many Meat?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock6 = int.Parse(stock6);
                    int ntprice6 = int.Parse(price6);
                    int newstock6 = ntstock6 - qty11;
                    if (qty11 > ntstock6)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.ReadKey();
                        Console.Clear();
                        order1();


                    }
                    else
                    {
                        cost6 = qty11 * ntprice6;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock6.txt")))
                        {
                            sw.WriteLine(newstock6);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                        int repeat6 = int.Parse(Console.ReadLine());
                        switch (repeat6)
                        {
                            case 1:

                                Console.Clear();
                                order2();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 7:
                    stocks();
                    php();
                    Console.WriteLine("How Many Softdrinks?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock7 = int.Parse(stock7);
                    int ntprice7 = int.Parse(price7);
                    int newstock7 = ntstock7 - qty11;
                    if (qty11 > ntstock7)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.ReadKey();
                        Console.Clear();
                        order1();


                    }
                    else
                    {
                        cost7 = qty11 * ntprice7;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock7.txt")))
                        {
                            sw.WriteLine(newstock7);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                        int repeat7 = int.Parse(Console.ReadLine());
                        switch (repeat7)
                        {
                            case 1:

                                Console.Clear();
                                order2();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 8:
                    stocks();
                    php();
                    Console.WriteLine("How Many Bottled Water?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock8 = int.Parse(stock8);
                    int ntprice8 = int.Parse(price8);
                    int newstock8 = ntstock8 - qty11;
                    if (qty11 > ntstock8)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.ReadKey();
                        Console.Clear();
                        order1();


                    }
                    else
                    {
                        cost8 = qty11 * ntprice8;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock8.txt")))
                        {
                            sw.WriteLine(newstock8);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                        int repeat8 = int.Parse(Console.ReadLine());
                        switch (repeat8)
                        {
                            case 1:

                                Console.Clear();
                                order2();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 9:
                    Console.Clear();
                    Order();
                    break;
                    int qty = int.Parse(Console.ReadLine());

            }

        }
        static void order2()
        {
            admin();
            php();
            stocks();
            Console.WriteLine("Shawarma            Price   Stocks");
            Console.WriteLine("1. Beef Shawarma    Php" + price1 + "    " + stock1);
            Console.WriteLine("2. Chicken Shawarma Php" + price2 + "    " + stock2);
            Console.WriteLine("3. Shawarma Rice    Php" + price3 + "    " + stock3 + "\n");
            Console.WriteLine("Add On");
            Console.WriteLine("4. Egg              Php" + price4 + "    " + stock4);
            Console.WriteLine("5. Cheese           Php" + price5 + "    " + stock5);
            Console.WriteLine("6. Meat             Php" + price6 + "    " + stock6);
            Console.WriteLine("7. Softdrinks       Php" + price7 + "    " + stock7);
            Console.WriteLine("8. Bottled Water    Php" + price8 + "    " + stock8);
            Console.WriteLine("9. Exit");

            int num1 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    stocks();
                    php();
                    Console.WriteLine("How Many Beef Shawarma?");
                    int qty11 = int.Parse(Console.ReadLine());
                    int ntstock1 = int.Parse(stock1);
                    int ntprice1 = int.Parse(price1);

                    if (qty11 > ntstock1)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.Read();
                    }
                    else
                    {



                        int newstock1 = ntstock1 - qty11;
                        cost11 = qty11 * ntprice1;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock1.txt")))
                        {
                            sw.WriteLine(newstock1);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                        int repeat = int.Parse(Console.ReadLine());
                        switch (repeat)
                        {
                            case 1:

                                Console.Clear();
                                order3();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 2:
                    stocks();
                    php();
                    Console.WriteLine("How Many Chicken Shawarma?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock2 = int.Parse(stock2);
                    int ntprice2 = int.Parse(price2);
                    int newstock2 = ntstock2 - qty11;
                    cost22 = qty11 * ntprice2;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock2);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                    int repeat2 = int.Parse(Console.ReadLine());
                    switch (repeat2)
                    {
                        case 1:

                            Console.Clear();
                            order3();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 3:
                    stocks();
                    php();
                    Console.WriteLine("How Many Shawarma Rice?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock3 = int.Parse(stock3);
                    int ntprice3 = int.Parse(price3);
                    int newstock3 = ntstock3 - qty11;
                    cost33 = qty11 * ntprice3;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock3.txt")))
                    {
                        sw.WriteLine(newstock3);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat3 = int.Parse(Console.ReadLine());
                    switch (repeat3)
                    {
                        case 1:

                            Console.Clear();
                            order3();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 4:
                    stocks();
                    php();
                    Console.WriteLine("How Many Egg?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock4 = int.Parse(stock4);
                    int ntprice4 = int.Parse(price4);
                    int newstock4 = ntstock4 - qty11;
                    cost44 = qty11 * ntprice4;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock4.txt")))
                    {
                        sw.WriteLine(newstock4);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat4 = int.Parse(Console.ReadLine());
                    switch (repeat4)
                    {
                        case 1:

                            Console.Clear();
                            order3();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 5:
                    stocks();
                    php();
                    Console.WriteLine("How Many Cheese?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock5 = int.Parse(stock5);
                    int ntprice5 = int.Parse(price5);
                    int newstock5 = ntstock5 - qty11;
                    cost55 = qty11 * ntprice5;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock5.txt")))
                    {
                        sw.WriteLine(newstock5);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat5 = int.Parse(Console.ReadLine());
                    switch (repeat5)
                    {
                        case 1:

                            Console.Clear();
                            order3();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 6:
                    stocks();
                    php();
                    Console.WriteLine("How Many Meat?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock6 = int.Parse(stock6);
                    int ntprice6 = int.Parse(price6);
                    int newstock6 = ntstock6 = -qty11;
                    cost66 = qty11 * ntprice6;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock6);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat6 = int.Parse(Console.ReadLine());
                    switch (repeat6)
                    {
                        case 1:

                            Console.Clear();
                            order3();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 7:
                    stocks();
                    php();
                    Console.WriteLine("How Many Softdrinks?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock7 = int.Parse(stock7);
                    int ntprice7 = int.Parse(price7);
                    int newstock7 = ntstock7 - qty11;
                    cost77 = qty11 * ntprice7;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock7);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat7 = int.Parse(Console.ReadLine());
                    switch (repeat7)
                    {
                        case 1:

                            Console.Clear();
                            order3();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 8:
                    stocks();
                    php();
                    Console.WriteLine("How Many Bottled Water?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock8 = int.Parse(stock8);
                    int ntprice8 = int.Parse(price8);
                    int newstock8 = ntstock8 - qty11;
                    cost88 = qty11 * ntprice8;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock8.txt")))
                    {
                        sw.WriteLine(newstock8);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat8 = int.Parse(Console.ReadLine());
                    switch (repeat8)
                    {
                        case 1:

                            Console.Clear();
                            order3();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 9:
                    Console.Clear();
                    Order();
                    break;
                    int qty = int.Parse(Console.ReadLine());

            }

        }
        static void order3()
        {
            admin();
            php();
            stocks();
            Console.WriteLine("Shawarma            Price   Stocks");
            Console.WriteLine("1. Beef Shawarma    Php" + price1 + "    " + stock1);
            Console.WriteLine("2. Chicken Shawarma Php" + price2 + "    " + stock2);
            Console.WriteLine("3. Shawarma Rice    Php" + price3 + "    " + stock3 + "\n");
            Console.WriteLine("Add On");
            Console.WriteLine("4. Egg              Php" + price4 + "    " + stock4);
            Console.WriteLine("5. Cheese           Php" + price5 + "    " + stock5);
            Console.WriteLine("6. Meat             Php" + price6 + "    " + stock6);
            Console.WriteLine("7. Softdrinks       Php" + price7 + "    " + stock7);
            Console.WriteLine("8. Bottled Water    Php" + price8 + "    " + stock8);
            Console.WriteLine("9. Exit");

            int num1 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    stocks();
                    php();
                    Console.WriteLine("How Many Beef Shawarma?");
                    int qty11 = int.Parse(Console.ReadLine());
                    int ntstock1 = int.Parse(stock1);
                    int ntprice1 = int.Parse(price1);

                    if (qty11 > ntstock1)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.Read();
                    }
                    else
                    {



                        int newstock1 = ntstock1 - qty11;
                        cost111 = qty11 * ntprice1;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock1.txt")))
                        {
                            sw.WriteLine(newstock1);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                        int repeat = int.Parse(Console.ReadLine());
                        switch (repeat)
                        {
                            case 1:

                                Console.Clear();
                                order4();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 2:
                    stocks();
                    php();
                    Console.WriteLine("How Many Chicken Shawarma?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock2 = int.Parse(stock2);
                    int ntprice2 = int.Parse(price2);
                    int newstock2 = ntstock2 - qty11;
                    cost222 = qty11 * ntprice2;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock2);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                    int repeat2 = int.Parse(Console.ReadLine());
                    switch (repeat2)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 3:
                    stocks();
                    php();
                    Console.WriteLine("How Many Shawarma Rice?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock3 = int.Parse(stock3);
                    int ntprice3 = int.Parse(price3);
                    int newstock3 = ntstock3 - qty11;
                    cost333 = qty11 * ntprice3;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock3.txt")))
                    {
                        sw.WriteLine(newstock3);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat3 = int.Parse(Console.ReadLine());
                    switch (repeat3)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 4:
                    stocks();
                    php();
                    Console.WriteLine("How Many Egg?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock4 = int.Parse(stock4);
                    int ntprice4 = int.Parse(price4);
                    int newstock4 = ntstock4 - qty11;
                    cost444 = qty11 * ntprice4;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock4.txt")))
                    {
                        sw.WriteLine(newstock4);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat4 = int.Parse(Console.ReadLine());
                    switch (repeat4)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 5:
                    stocks();
                    php();
                    Console.WriteLine("How Many Cheese?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock5 = int.Parse(stock5);
                    int ntprice5 = int.Parse(price5);
                    int newstock5 = ntstock5 - qty11;
                    cost555 = qty11 * ntprice5;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock5.txt")))
                    {
                        sw.WriteLine(newstock5);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat5 = int.Parse(Console.ReadLine());
                    switch (repeat5)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 6:
                    stocks();
                    php();
                    Console.WriteLine("How Many Meat?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock6 = int.Parse(stock6);
                    int ntprice6 = int.Parse(price6);
                    int newstock6 = ntstock6 = -qty11;
                    cost666 = qty11 * ntprice6;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock6);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat6 = int.Parse(Console.ReadLine());
                    switch (repeat6)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 7:
                    stocks();
                    php();
                    Console.WriteLine("How Many Softdrinks?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock7 = int.Parse(stock7);
                    int ntprice7 = int.Parse(price7);
                    int newstock7 = ntstock7 - qty11;
                    cost777 = qty11 * ntprice7;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock7);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat7 = int.Parse(Console.ReadLine());
                    switch (repeat7)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 8:
                    stocks();
                    php();
                    Console.WriteLine("How Many Bottled Water?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock8 = int.Parse(stock8);
                    int ntprice8 = int.Parse(price8);
                    int newstock8 = ntstock8 - qty11;
                    cost888 = qty11 * ntprice8;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock8.txt")))
                    {
                        sw.WriteLine(newstock8);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat8 = int.Parse(Console.ReadLine());
                    switch (repeat8)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 9:
                    Console.Clear();
                    Order();
                    break;
                    int qty = int.Parse(Console.ReadLine());

            }

        }
        static void order4()
        {
            admin();
            php();
            stocks();
            Console.WriteLine("Shawarma            Price   Stocks");
            Console.WriteLine("1. Beef Shawarma    Php" + price1 + "    " + stock1);
            Console.WriteLine("2. Chicken Shawarma Php" + price2 + "    " + stock2);
            Console.WriteLine("3. Shawarma Rice    Php" + price3 + "    " + stock3 + "\n");
            Console.WriteLine("Add On");
            Console.WriteLine("4. Egg              Php" + price4 + "    " + stock4);
            Console.WriteLine("5. Cheese           Php" + price5 + "    " + stock5);
            Console.WriteLine("6. Meat             Php" + price6 + "    " + stock6);
            Console.WriteLine("7. Softdrinks       Php" + price7 + "    " + stock7);
            Console.WriteLine("8. Bottled Water    Php" + price8 + "    " + stock8);
            Console.WriteLine("9. Exit");

            int num1 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    stocks();
                    php();
                    Console.WriteLine("How Many Beef Shawarma?");
                    int qty11 = int.Parse(Console.ReadLine());
                    int ntstock1 = int.Parse(stock1);
                    int ntprice1 = int.Parse(price1);

                    if (qty11 > ntstock1)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.Read();
                    }
                    else
                    {



                        int newstock1 = ntstock1 - qty11;
                        cost1111 = qty11 * ntprice1;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock1.txt")))
                        {
                            sw.WriteLine(newstock1);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                        int repeat = int.Parse(Console.ReadLine());
                        switch (repeat)
                        {
                            case 1:

                                Console.Clear();
                                order5();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 2:
                    stocks();
                    php();
                    Console.WriteLine("How Many Chicken Shawarma?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock2 = int.Parse(stock2);
                    int ntprice2 = int.Parse(price2);
                    int newstock2 = ntstock2 - qty11;
                    cost2222 = qty11 * ntprice2;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock2);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                    int repeat2 = int.Parse(Console.ReadLine());
                    switch (repeat2)
                    {
                        case 1:

                            Console.Clear();
                            order5();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 3:
                    stocks();
                    php();
                    Console.WriteLine("How Many Shawarma Rice?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock3 = int.Parse(stock3);
                    int ntprice3 = int.Parse(price3);
                    int newstock3 = ntstock3 - qty11;
                    cost3333 = qty11 * ntprice3;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock3.txt")))
                    {
                        sw.WriteLine(newstock3);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat3 = int.Parse(Console.ReadLine());
                    switch (repeat3)
                    {
                        case 1:

                            Console.Clear();
                            order5();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 4:
                    stocks();
                    php();
                    Console.WriteLine("How Many Egg?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock4 = int.Parse(stock4);
                    int ntprice4 = int.Parse(price4);
                    int newstock4 = ntstock4 - qty11;
                    cost4444 = qty11 * ntprice4;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock4.txt")))
                    {
                        sw.WriteLine(newstock4);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat4 = int.Parse(Console.ReadLine());
                    switch (repeat4)
                    {
                        case 1:

                            Console.Clear();
                            order5();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 5:
                    stocks();
                    php();
                    Console.WriteLine("How Many Cheese?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock5 = int.Parse(stock5);
                    int ntprice5 = int.Parse(price5);
                    int newstock5 = ntstock5 - qty11;
                    cost5555 = qty11 * ntprice5;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock5.txt")))
                    {
                        sw.WriteLine(newstock5);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat5 = int.Parse(Console.ReadLine());
                    switch (repeat5)
                    {
                        case 1:

                            Console.Clear();
                            order5();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 6:
                    stocks();
                    php();
                    Console.WriteLine("How Many Meat?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock6 = int.Parse(stock6);
                    int ntprice6 = int.Parse(price6);
                    int newstock6 = ntstock6 = -qty11;
                    cost6666 = qty11 * ntprice6;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock6);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat6 = int.Parse(Console.ReadLine());
                    switch (repeat6)
                    {
                        case 1:

                            Console.Clear();
                            order5();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 7:
                    stocks();
                    php();
                    Console.WriteLine("How Many Softdrinks?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock7 = int.Parse(stock7);
                    int ntprice7 = int.Parse(price7);
                    int newstock7 = ntstock7 - qty11;
                    cost7777 = qty11 * ntprice7;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock7);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat7 = int.Parse(Console.ReadLine());
                    switch (repeat7)
                    {
                        case 1:

                            Console.Clear();
                            order5();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 8:
                    stocks();
                    php();
                    Console.WriteLine("How Many Bottled Water?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock8 = int.Parse(stock8);
                    int ntprice8 = int.Parse(price8);
                    int newstock8 = ntstock8 - qty11;
                    cost8888 = qty11 * ntprice8;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock8.txt")))
                    {
                        sw.WriteLine(newstock8);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat8 = int.Parse(Console.ReadLine());
                    switch (repeat8)
                    {
                        case 1:

                            Console.Clear();
                            order5();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 9:
                    Console.Clear();
                    Order();
                    break;
                    int qty = int.Parse(Console.ReadLine());

            }

        }
        static void order5()
        {
            admin();
            php();
            stocks();
            Console.WriteLine("Shawarma            Price   Stocks");
            Console.WriteLine("1. Beef Shawarma    Php" + price1 + "    " + stock1);
            Console.WriteLine("2. Chicken Shawarma Php" + price2 + "    " + stock2);
            Console.WriteLine("3. Shawarma Rice    Php" + price3 + "    " + stock3 + "\n");
            Console.WriteLine("Add On");
            Console.WriteLine("4. Egg              Php" + price4 + "    " + stock4);
            Console.WriteLine("5. Cheese           Php" + price5 + "    " + stock5);
            Console.WriteLine("6. Meat             Php" + price6 + "    " + stock6);
            Console.WriteLine("7. Softdrinks       Php" + price7 + "    " + stock7);
            Console.WriteLine("8. Bottled Water    Php" + price8 + "    " + stock8);
            Console.WriteLine("9. Exit");

            int num1 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    stocks();
                    php();
                    Console.WriteLine("How Many Beef Shawarma?");
                    int qty11 = int.Parse(Console.ReadLine());
                    int ntstock1 = int.Parse(stock1);
                    int ntprice1 = int.Parse(price1);

                    if (qty11 > ntstock1)
                    {
                        Console.WriteLine("Insuficient Stock");
                        Console.Read();
                    }
                    else
                    {



                        int newstock1 = ntstock1 - qty11;
                        cost11111 = qty11 * ntprice1;
                        using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock1.txt")))
                        {
                            sw.WriteLine(newstock1);
                            sw.Close();
                        }
                        Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                        int repeat = int.Parse(Console.ReadLine());
                        switch (repeat)
                        {
                            case 1:

                                Console.Clear();
                                order4();
                                break;

                            case 2:
                                {
                                    billing();
                                    break;
                                }
                        }
                    }
                    break;
                case 2:
                    stocks();
                    php();
                    Console.WriteLine("How Many Chicken Shawarma?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock2 = int.Parse(stock2);
                    int ntprice2 = int.Parse(price2);
                    int newstock2 = ntstock2 - qty11;
                    cost22222 = qty11 * ntprice2;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock2);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item? \n1. Yes \n2. No");
                    int repeat2 = int.Parse(Console.ReadLine());
                    switch (repeat2)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 3:
                    stocks();
                    php();
                    Console.WriteLine("How Many Shawarma Rice?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock3 = int.Parse(stock3);
                    int ntprice3 = int.Parse(price3);
                    int newstock3 = ntstock3 - qty11;
                    cost33333 = qty11 * ntprice3;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock3.txt")))
                    {
                        sw.WriteLine(newstock3);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat3 = int.Parse(Console.ReadLine());
                    switch (repeat3)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 4:
                    stocks();
                    php();
                    Console.WriteLine("How Many Egg?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock4 = int.Parse(stock4);
                    int ntprice4 = int.Parse(price4);
                    int newstock4 = ntstock4 - qty11;
                    cost44444 = qty11 * ntprice4;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock4.txt")))
                    {
                        sw.WriteLine(newstock4);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat4 = int.Parse(Console.ReadLine());
                    switch (repeat4)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 5:
                    stocks();
                    php();
                    Console.WriteLine("How Many Cheese?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock5 = int.Parse(stock5);
                    int ntprice5 = int.Parse(price5);
                    int newstock5 = ntstock5 - qty11;
                    cost55555 = qty11 * ntprice5;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock5.txt")))
                    {
                        sw.WriteLine(newstock5);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat5 = int.Parse(Console.ReadLine());
                    switch (repeat5)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 6:
                    stocks();
                    php();
                    Console.WriteLine("How Many Meat?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock6 = int.Parse(stock6);
                    int ntprice6 = int.Parse(price6);
                    int newstock6 = ntstock6 = -qty11;
                    cost66666 = qty11 * ntprice6;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock6);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat6 = int.Parse(Console.ReadLine());
                    switch (repeat6)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 7:
                    stocks();
                    php();
                    Console.WriteLine("How Many Softdrinks?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock7 = int.Parse(stock7);
                    int ntprice7 = int.Parse(price7);
                    int newstock7 = ntstock7 - qty11;
                    cost77777 = qty11 * ntprice7;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock2.txt")))
                    {
                        sw.WriteLine(newstock7);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat7 = int.Parse(Console.ReadLine());
                    switch (repeat7)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 8:
                    stocks();
                    php();
                    Console.WriteLine("How Many Bottled Water?");
                    qty11 = int.Parse(Console.ReadLine());
                    int ntstock8 = int.Parse(stock8);
                    int ntprice8 = int.Parse(price8);
                    int newstock8 = ntstock8 - qty11;
                    cost88888 = qty11 * ntprice8;
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\ordering\\stock8.txt")))
                    {
                        sw.WriteLine(newstock8);
                        sw.Close();
                    }
                    Console.WriteLine("Do you want to add item \n1. Yes \n2. No");
                    int repeat8 = int.Parse(Console.ReadLine());
                    switch (repeat8)
                    {
                        case 1:

                            Console.Clear();
                            order4();
                            break;

                        case 2:
                            {
                                billing();
                                break;
                            }
                    }
                    break;
                case 9:
                    Console.Clear();
                    Order();
                    break;
                    int qty = int.Parse(Console.ReadLine());

            }

        }
        static void billing()
        {

            total();



            Console.WriteLine("Senior Citizen/ PWD Discount: \n1. Yes \n2. No");
            int discount1 = int.Parse(Console.ReadLine());

            switch (discount1)
            {
                case 1:
                    double discoun = tcost / 5;
                    double discount = tcost - discoun;
                    Console.WriteLine("Total Order: " + discount);
                    Console.Write("Cash: ");
                    int cash = int.Parse(Console.ReadLine());
                    if (discount > cash)
                    {
                        Console.WriteLine("Insufficient Cash"); 
                    }
                    else
                    {
                        double change = cash - discount;
                        Console.WriteLine("Change: " + change);
                        Console.ReadKey();
                        Console.Clear();
                        Order();
                    }
                    break;
                case 2:
                    Console.WriteLine("Total Order:" + tcost);
                    Console.Write("Cash: ");
                    int cash2 = int.Parse(Console.ReadLine());
                    if (tcost > cash2)
                    {
                        Console.WriteLine("Insufficient Cash");
                    }
                    else
                    {
                        double change2 = tcost - cash2;
                        Console.WriteLine("Change: " + change2);
                        Console.ReadKey();
                        Console.Clear();
                        Order();
                    }
                    break;
            }


        }

        static void total()
        {
            costs1 = cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7 + cost8;
            costs2 = cost11 + cost22 + cost33 + cost44 + cost55 + cost66 + cost77 + cost88;
            costs3 = cost111 + cost222 + cost333 + cost444 + cost555 + cost666 + cost777 + cost888;
            costs4 = cost1111 + cost2222 + cost3333 + cost4444 + cost5555 + cost6666 + cost7777 + cost8888;
            costs5 = cost11111 + cost22222 + cost33333 + cost44444 + cost55555 + cost66666 + cost77777 + cost88888;
            tcost = costs1 + costs2 + costs3 + costs4 + costs5;
        }
    }
}