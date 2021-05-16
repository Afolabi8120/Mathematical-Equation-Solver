using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Equations_Solver
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int userOption;

            string restart;

            Start:
            Console.WriteLine(" Hello, this a mathematical equation solver that helps you solve \n some of your math problem ranging from Quadratic Equation, \n Area of Basic Shapes,  Simple Interest and more.");
            Console.WriteLine("");
            Console.WriteLine("1. Quadratic Equation\n2. Area of Basic Shape\n3. Simple Interest\n4. Factorial\n 5. Permutation");
            Console.WriteLine("");
            Console.WriteLine("Please select an Option");
            userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                //Quadratic Equation starts here
                case 1:
                    Console.WriteLine("You have selected Quadratic Equation as your choice");
                    int a, b, c;

                    string num1, num2, num3;

                    double X, Y;

                    Console.WriteLine("Please enter a number for a");
                    num1 = Console.ReadLine();
                    Console.WriteLine("Please enter a number for b");
                    num2 = Console.ReadLine();
                    Console.WriteLine("Please enter a number for c");
                    num3 = Console.ReadLine();

                    a = int.Parse(num1);
                    b = int.Parse(num2);
                    c = int.Parse(num3);

                    X = (-(b) + Math.Sqrt(Math.Pow(b, 2) - 4 * (a) * (c))) / (2 * (a));
                    Y = (-(b) - Math.Sqrt(Math.Pow(b, 2) - 4 * (a) * (c))) / (2 * (a));

                    Console.WriteLine("X = {0} and Y = {1}", X, Y);
                    Console.WriteLine("");

                    myChoiceQuadratic:
                    Console.WriteLine("Do you wish to continue, enter Y to continue or N to Exit");
                    restart = Console.ReadLine().ToUpper();

                    switch (restart)
                    {
                        case "Y":
                            goto Start;
                            break;
                        case "N":
                            Console.WriteLine("Press enter to exit");
                            break;
                        default:
                            Console.WriteLine("Invalid Input Provided");
                            goto myChoiceQuadratic;
                            break;
                    }

                    break; //Quadratic Equation ends here
                case 2:
                    //Area of Basic Shapes starts here
                    Console.WriteLine("You have selected Area of Basic Shapes as your choice\n");
                    Console.WriteLine("1. Area of a Rectangle\n2. Area of a Parrallelogram\n3. Area of a Circle\n4. Area of a Triangle\n5. Circumference of a Circle\n");
                    int num = int.Parse(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("\t\tAREA OF A RECTANGLE");
                            Console.WriteLine("");
                            double length, breath, area;

                            Console.WriteLine("Enter the value for length");
                            length = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the value for base");
                            breath = double.Parse(Console.ReadLine());

                            area = length * breath;
                            Console.WriteLine("Area = {0} ", area);
                            Console.WriteLine("");

                                myChoiceRectangle:
                                Console.WriteLine("Do you wish to continue, enter Y to continue or N to Exit");
                                restart = Console.ReadLine().ToUpper();

                                switch (restart)
                                {
                                    case "Y":
                                        goto Start;
                                        break;
                                    case "N":
                                        Console.WriteLine("Press enter to exit");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input Provided");
                                        goto myChoiceRectangle;
                                        break;
                                }

                            break;
                        case 2:
                            Console.WriteLine("\t\tAREA OF A PARALLELOGRAM");
                            Console.WriteLine("");
                            double base1, height1, area1;

                            Console.WriteLine("Enter the value for the base");
                            base1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the value for the height");
                            height1 = double.Parse(Console.ReadLine());

                            area1 = base1 * height1;
                            Console.WriteLine("Area = {0} ", area1);
                            Console.WriteLine("");

                            myChoiceParrallelogram:
                            Console.WriteLine("Do you wish to continue, enter Y to continue or N to Exit");
                            restart = Console.ReadLine().ToUpper();

                                switch (restart)
                                {
                                    case "Y":
                                        goto Start;
                                        break;
                                    case "N":
                                        Console.WriteLine("Press enter to exit");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input Provided");
                                        goto myChoiceParrallelogram;
                                        break;
                                }

                            break;
                        case 3:
                            Console.WriteLine("\t\tAREA OF A CIRCLE");
                            Console.WriteLine("");
                            double radius, area2;

                            Console.WriteLine("Enter the value for the radius");
                            radius = double.Parse(Console.ReadLine());

                            area2 = Math.PI * Math.Pow(radius, 2);
                            Console.WriteLine("Area = {0} ", area2);
                            Console.WriteLine("");

                            myChoiceCircle:
                            Console.WriteLine("Do you wish to continue, enter Y to continue or N to Exit");
                                restart = Console.ReadLine().ToUpper();

                                switch (restart)
                                {
                                    case "Y":
                                        goto Start;
                                        break;
                                    case "N":
                                        Console.WriteLine("Press enter to exit");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input Provided");
                                        goto myChoiceCircle;
                                        break;
                                }

                            break;
                        case 4:
                            Console.WriteLine("\t\tAREA OF A TRIANGLE");
                            Console.WriteLine("");
                            double base2, height2, area3;

                            Console.WriteLine("Enter the value for the base");
                            base2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the value for the height");
                            height2 = double.Parse(Console.ReadLine());

                            area3 = 1 / 2 * base2 * height2;
                            Console.WriteLine("Area = {0} ", area3);
                            Console.WriteLine("");

                            myChoiceTriangle:
                            Console.WriteLine("Do you wish to continue, enter Y to continue or N to Exit");
                                restart = Console.ReadLine().ToUpper();

                                switch (restart)
                                {
                                    case "Y":
                                        goto Start;
                                        break;
                                    case "N":
                                        Console.WriteLine("Press enter to exit");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input Provided");
                                        goto myChoiceTriangle;
                                        break;
                                }

                            break;
                        case 5:
                            Console.WriteLine("\t\tCIRCUMFERENCE OF A CIRCLE");
                            Console.WriteLine("");
                            double radius2, result;

                            Console.WriteLine("Enter the value for the radius");
                            radius2 = double.Parse(Console.ReadLine());

                            result = 2 * Math.PI * 2;
                            Console.WriteLine("Circumference = {0} ", result);
                            Console.WriteLine("");

                            myChoiceCircumference:
                            Console.WriteLine("Do you wish to continue, enter Y to continue or N to Exit");
                                restart = Console.ReadLine().ToUpper();

                                switch (restart)
                                {
                                    case "Y":
                                        goto Start;
                                        break;
                                    case "N":
                                        Console.WriteLine("Press enter to exit");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input Provided");
                                        goto myChoiceCircumference;
                                        break;
                                }
                            break;
                        default:
                            Console.WriteLine("Invalid Input Provided");
                            goto Start;
                            break;
                    }
                    break;//Area of Basic Shapes ends here
                case 3:
                    //Simple Interest starts here
                    Console.WriteLine("You have selected Simple Interest as your choice");
                    int p, r, t;

                    double SI;

                    Console.WriteLine("Please enter the Principal");
                    p = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the Rate");
                    r = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the Time");
                    t = int.Parse(Console.ReadLine());

                    SI = p * r * t / 100;

                    Console.WriteLine("S.I = {0}", SI);
                    Console.WriteLine("");

                    myChoiceSimpleInterest:
                    Console.WriteLine("Do you wish to continue, enter Y to continue or N to Exit");
                    restart = Console.ReadLine().ToUpper();

                    switch (restart)
                    {
                        case "Y":
                            goto Start;
                            break;
                        case "N":
                            Console.WriteLine("Press enter to exit");
                            break;
                        default:
                            Console.WriteLine("Invalid Input Provided");
                            goto myChoiceSimpleInterest;
                            break;
                    }
                    break;//Simple Interest ends here
                case 4:
                    //Factorial starts here
                    Console.WriteLine("You have selected Factorial as your choice");
                    int value1, fact;

                    fact = 1;

                    Console.WriteLine("Please enter a value");
                    value1 = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= value1; i++)
                    {
                        fact = fact * i;                       
                    }

                    Console.WriteLine("{0}! = {1}", value1, fact);
                    break; //Factorial ends here
                default:
                    Console.WriteLine("Invalid Input Provided");
                    break;
            }

            Console.ReadKey();
        }
    }
}
