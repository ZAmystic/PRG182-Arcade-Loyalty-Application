using System;
using System.Collections;
using System.Globalization;
using System.Linq.Expressions;
using System.Xml.Schema;

namespace PRG182_Project_V2
{
    internal class Program
    {   
        private static int ArrayCount = 0;                             
        private static String[] ArrayUserDetails = new string[5000];

        private static int passArrayCount = 0;
        private static String[] passCredit = new string[5000];

        private static int failArrayCount = 0;
        private static String[] failCredit = new string[5000];

        private static string outputString;
        private static string applicantName, employmentStatus, flavorName;
        private static int applicantAge, arcadeHighScore, totalPizzas, bowlingHighScore, flavorPick, totalSlushPuppy, counter = 0;
        private static int totalQualified, totalNotQualified = 0;
        private static bool flavorLoop, moreMemberLoop, continueAdding;
        private static DateTime applicantLoyalDate;
        private static char moreMembers;

        public void CollectUserDetails()                //All User Details that will be collected
        {
            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Applicant Information:");
                Console.WriteLine("---------------------------------");

                // Applicants Name
                Console.WriteLine("Enter your name: ");
                applicantName = Console.ReadLine();
                outputString = applicantName + ",";

                // Applicants Age
                Console.WriteLine("");
                Console.WriteLine("Enter your age: ");
                applicantAge = Convert.ToInt16(Console.ReadLine());
                outputString += applicantAge + ",";

                // Applicants High Score Arcade
                Console.WriteLine("");
                Console.WriteLine("Enter your high score in arcade games: ");
                arcadeHighScore = Convert.ToInt16(Console.ReadLine());
                outputString += arcadeHighScore + ",";

                // Applicants Starting Date As Loyal Customer
                Console.WriteLine("");
                Console.WriteLine("Enter your starting date as a loyal customer (yyyy-mm-dd): ");
                applicantLoyalDate = DateTime.Parse(Console.ReadLine());
                outputString += applicantLoyalDate.ToString("yyyy-MM-dd") + ",";

                // Applicants Total Pizzas Consumed Since First Visit
                Console.WriteLine("");
                Console.WriteLine("Enter total pizzas you consumed since first visit: ");
                totalPizzas = Convert.ToInt16(Console.ReadLine());
                outputString += totalPizzas + ",";

                // Applicants High Score Bowling
                Console.WriteLine("");
                Console.WriteLine("Enter your high score in bowling: ");
                bowlingHighScore = Convert.ToInt16(Console.ReadLine());
                outputString += bowlingHighScore + ",";

                // Applicants Employment Status
                employmentStatus = "";
                Console.WriteLine("");

                if (applicantAge >= 18)
                {
                    Console.WriteLine("Are you currently employed? [yes/no]: ");
                    employmentStatus = Console.ReadLine().ToLower();
                    outputString += employmentStatus + ",";
                }
                else
                {
                    Console.WriteLine("Are your parents currently employed? [yes/no]: ");
                    employmentStatus = Console.ReadLine().ToLower();
                    outputString += employmentStatus + ",";
                }

                // Applicants Slush-Puppy Flavour Preference
                flavorName = "";
                Console.WriteLine("");

                do
                {
                    flavorLoop = false;
                    Console.WriteLine("What is your Slush-Puppy flavor preference: ");
                    Console.WriteLine("1. BlueBerry");
                    Console.WriteLine("2. Mountain Dew");
                    Console.WriteLine("3. Gooey Gulp Galore");
                    Console.WriteLine("4. Tropica Pineapple");
                    flavorPick = Convert.ToInt16(Console.ReadLine());

                    switch (flavorPick)
                    {
                        case 1:
                            flavorName = "BlueBerry";
                            break;
                        case 2:
                            flavorName = "Mountain Dew";
                            break;
                        case 3:
                            flavorName = "Gooey Gulp Galore";
                            break;
                        case 4:
                            flavorName = "Tropica Pineapple";
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            flavorLoop = true;
                            break;
                    }
                } while (flavorLoop);

                outputString += flavorName + ",";

                // Applicants Total Slush-Puppy Consumed Since First Visit
                Console.WriteLine("");
                Console.WriteLine("Enter total slush puppies you consumed since first visit: ");
                totalSlushPuppy = Convert.ToInt16(Console.ReadLine());
                outputString += totalSlushPuppy;

                // Make Array Functional
                ArrayUserDetails[ArrayCount] = outputString;
                ArrayCount++;

                //Call validation for credit qualification
                Validation validation = new Validation();
                validation.Credit_Qualification();

                // Create More Members
                Console.WriteLine("");
                do
                {
                    moreMemberLoop = false;
                    Console.WriteLine("Do you want to capture more applicants? [Y/N]: ");
                    moreMembers = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (moreMembers == 'Y')
                    {
                        continueAdding = true;
                        Console.Clear();
                    }
                    else if (moreMembers == 'N')
                    {
                        continueAdding = false;
                        Console.Clear();

                        OpenMenu openmenu = new OpenMenu();
                        openmenu.Get_Menu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                        moreMemberLoop = true;
                    }
                } while (moreMemberLoop);

            } while ((continueAdding == true) && (counter < 5000));

        }

        public class Validation                         //All Credit Validation that gets conducted
        {
            public void Credit_Qualification()              //Credit Qualification Code is finalized here
            {
                //Creating variables thats going to be used in Credit_Qualification
                bool creditCheck_1, creditCheck_2, creditCheck_3, creditCheck_4, creditCheck_5;         //Creating boolean values
                bool allChecks = false;

                //Initialize variable
                int creditCount = 0;
                creditCheck_1 = false;
                creditCheck_2 = false;
                creditCheck_3 = false;
                creditCheck_4 = false;
                creditCheck_5 = false;

                //Getting the total months
                int totalmonths = (((DateTime.Now.Year - applicantLoyalDate.Year) * 12) + (DateTime.Now.Month - applicantLoyalDate.Month));

                if (DateTime.Now.Day < applicantLoyalDate.Day)
                {
                    totalmonths--;
                }

                //Checks if applicant is older or younger than 18 for credit check
                if (employmentStatus == "yes")
                {
                    creditCheck_1 = true;
                    creditCount++;
                }
                else
                {
                    creditCheck_1 = false;
                }

                //Checks if applicant has been a loyal customer for longer than 2 years
                if (applicantLoyalDate.Year >= 2)
                {
                    creditCheck_2 = true;
                    creditCount++;
                }
                else
                {
                    creditCheck_2 = false;
                }

                //Checks if applicant has passed the high scores required to pass
                if ((arcadeHighScore >= 2000) || (bowlingHighScore >= 1500) || ((arcadeHighScore * bowlingHighScore) / 2 >= 1200))
                {
                    creditCheck_3 = true;
                    creditCount++;
                }
                else
                {
                    creditCheck_3 = false;
                }

                //Checks if applicant has eaten a avg of 3 pizzas a month
                if (totalPizzas / totalmonths >= 3)
                {
                    creditCheck_4 = true;
                    creditCount++;
                }
                else
                {
                    creditCheck_4 = false;
                }

                //Checks if applicant has drinked a avg of 4 SlushPuppy a month and did not pick Gooey Gulp Galore
                if (((Convert.ToDouble(totalSlushPuppy) / Convert.ToDouble(totalmonths)) > 4) && (flavorName != "Gooey Gulp Galore"))
                {
                    creditCheck_5 = true;
                    creditCount++;

                }
                else
                {
                    creditCheck_5 = false;
                }

                //Checks if applicant are accpeted into credit qualification only if they meet all critera
                if ((creditCheck_1 == true) && (creditCheck_2 == true) && (creditCheck_3 == true) && (creditCheck_4 == true) && (creditCheck_5 == true))
                {
                    allChecks = true;
                    totalQualified++;
                }
                else if ((creditCheck_1 == false) || (creditCheck_2 == false) || (creditCheck_3 == false) || (creditCheck_4 == false) || (creditCheck_5 == false))
                {
                    allChecks = false;
                    totalNotQualified++;
                }

                //Stores all there names in a collection for all who passed and all who failed
                if (allChecks == true)
                {
                    passCredit[passArrayCount] = applicantName + " | Total credits : " + creditCount;                   //All who passed
                    passArrayCount++;
                }
                else if (allChecks == false)
                {
                    failCredit[failArrayCount] = applicantName;                                                         //All who failed
                    failArrayCount++;
                }
            }
        }

        public class OpenMenu                           //All Menu Related Code
        {
            enum Menu
            {
                Capture_Details  = 1,
                Credit_Qualification,
                Show_Stats          ,
                Exit_Application    
            }

            public void Get_Menu()
            {
                bool ValidOption = true;
                
                do
                {
                    ValidOption = true;

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Menu Options:");
                    Console.WriteLine("---------------------------------");
                    foreach (Menu menu in Enum.GetValues(typeof(Menu)))
                    {
                        Console.WriteLine($"[Press {(int)menu}] - {menu.ToString()}");
                    }
                    Console.WriteLine("---------------------------------=");
                    Console.WriteLine("Enter your choice: ");

                    int MenuPick = Convert.ToInt16(Console.ReadLine());

                    switch (MenuPick)
                    {
                        case 1:
                            Console.Clear();
                            Program program = new Program();
                            program.CollectUserDetails();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("Credit Qualification:");
                            Console.WriteLine("---------------------------------");

                            Console.WriteLine("There is a total of {0} who qualified:", totalQualified);
                            for (int i = 0; i <= passArrayCount; i++)
                            {
                                Console.WriteLine(passCredit[i]);
                            }
                            Console.WriteLine("There is a total of {0} who did not qualified:", totalNotQualified);
                            for (int i = 0; i <= failArrayCount; i++)
                            {
                                Console.WriteLine(failCredit[i]);
                            }
                            Console.WriteLine("---------------------------------");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("Arcade & Bowling Stats:");
                            Console.WriteLine("---------------------------------");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("Shutting Down Program");
                            Console.WriteLine("---------------------------------");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("!INVALID OPTION. PLEASE TRY AGAIN!");
                            ValidOption = false;
                            break;
                    }
                } while (ValidOption == false);
            }
        }

        static void Main(string[] args)                 //Main Code
        {
            OpenMenu openmenu = new OpenMenu();
            openmenu.Get_Menu();

            Console.ReadKey();
        }
    }
}
