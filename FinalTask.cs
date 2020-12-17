using System;
using System.Collections.Generic;

namespace HelloWorldPt2
{
    class FinalTask
    {
        static void Main(string[] args)
        {
            
            //1
            static void CreateString()
            {
                Console.WriteLine("Please type in your string: ");
                string UserString = Console.ReadLine();
                Console.WriteLine(UserString[0] + UserString + UserString[0]);
            }
            //CreateString();

            //2
            static void MonthString()
            {
                Console.WriteLine("Type in month number: ");
                int monthNmbr = Int32.Parse(Console.ReadLine());
                switch (monthNmbr)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break; 
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;                     
                    case 12:
                        Console.WriteLine("December");
                        break;    
                    default:
                        Console.WriteLine("There are only 12 months!");
                        break;
                }
            }
            //MonthString();

            //3
            static void ReverseString()
            {
                Console.WriteLine("Type in your string: ");
                string UserString = Console.ReadLine();
                char[] UserStringArray = UserString.ToCharArray();
                Array.Reverse(UserStringArray);
                string ReversedString = string.Join("",UserStringArray);
                Console.WriteLine(ReversedString);
            }
            // ReverseString();

            //4
            BMWCar MyBMW = new BMWCar();
            MyBMW.Drive();
            MyBMW.Park();

            AnyOtherCar MyOtherCar = new AnyOtherCar();
            MyOtherCar.Drive();
            MyOtherCar.Park();

        }
    }
}
