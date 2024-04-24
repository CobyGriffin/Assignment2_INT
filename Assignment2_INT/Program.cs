using System.Runtime.InteropServices;
using System.Transactions;

namespace Assignment2_INT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question_1();
            Question_2();
            Question_3();
            Question_4();
            Question_5();
            Question_6();
            Question_7();

        } //End of Main

        public static void Question_1()
        {
            double num1, num2, num3, num4, num5, result,Avg,Allvariables;

            Console.WriteLine("Enter Number 1");
             
           num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number 2");

            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number 3");

            num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number 4");

            num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number 5");

            num5 = Convert.ToDouble(Console.ReadLine());

            //Finding the Average of set Numbers

           result = num1 + num2 + num3 + num4 + num5;

            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", num1, num2,num3,num4,num5,result);

            Allvariables = 5;

            Avg = result / Allvariables;

            Console.WriteLine("{0} / {1} = {2}", result,Allvariables,Avg);
        }

        public static void Question_2()
        {
            double gallons, miles, result;

            Console.WriteLine("Enter Gallons");

            gallons = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Miles Driven");

            miles = Convert.ToInt32(Console.ReadLine());

            //Finding the distance you can travel from set of numbers

            result = miles / gallons;

            Console.WriteLine("{0} * {1} = {2}", gallons, miles, result);

        }

        public static void Question_3()
        {
            decimal seconds, minutes, hours;

            Console.WriteLine("Enter elapsed event time in seconds");

            seconds = Convert.ToInt32(Console.ReadLine());

            minutes = seconds / 60;

            hours = minutes / 60;

            Console.WriteLine("{0} Is the time of the event in hours",hours);


        }

        public static void Question_4()
        {
            decimal elapsedtime, seconds;

            Console.WriteLine("Enter in elapsed time of event in hours, minutes & seconds");

            elapsedtime= Convert.ToInt32(Console.ReadLine());

            seconds = elapsedtime * 3600;

            Console.WriteLine("{0} Is the elapsed time of the event in seconds", seconds);
        }
        public static void Question_5()
        {
            double original, markup, tax, newprice, result;

            Console.WriteLine("Enter original price of item");

            original = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter markup percentage in decimal");

            markup = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter sales tax in decimal");

            tax = Convert.ToDouble(Console.ReadLine());

            //Math equations

            newprice = (original * markup) + original;

            result = (tax * newprice) + newprice;

            Console.WriteLine("{0} Is the final price after sales tax", result);


        }
        public static void Question_6()
        {
            double centimeters, inches, feet, yards;

            Console.WriteLine("Enter length in centimeters");

            centimeters = Convert.ToInt32(Console.ReadLine());

            //Converting math equations

            inches = centimeters * 2.54;

            feet = inches * 12;

            yards = feet * 3;

            Console.WriteLine("{0} yard(s), {1} feet (foot), and {2} inch(es)", yards, feet, inches);

        }
        public static void Question_7()
        {
            double milk, carton,totalcartons, cost, profit, result;

            Console.WriteLine("Enter the total amount of milk produced");

            milk= Convert.ToInt32(Console.ReadLine());

            carton = 3.78;

            //Math equations

            totalcartons = carton * milk;

            cost = totalcartons * 1.4364;

            profit = carton * 0.27;

            result = profit - cost;

            Console.WriteLine("The cost of producing milk is {0}", cost);

            Console.WriteLine("the profit of producing milk is {0}", result);

        }
    }//Class
} //NameSpace
