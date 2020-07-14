using System;

namespace Lab3._1StudentInfo
{
    class Program
    {



        static void Main(string[] args)
        {

            //3 arrays Name, Food, Title
            string[] studentName = new string[5] { "John Smith", "Jack Sparrow", "Doug Funny", "Angelica Pickles", "Anne Gable" };
            string[] favFood = new string[5] { "M&Ms", "Chococate", "Swedish Fish", "Pop Rocks", "War Heads" };
            string[] studentTitle = new string[5] { "Freshman", "Sophomore", "Junior", "Junior", "Sophomore" };


            bool validAns2 = true;
            bool userCont = true;
            int userChoice = 0;

            while (userCont == true)
            {
                //Ask user for input
                Console.WriteLine("Choose the student you want to learn about");
                for (int i = 0; i < studentName.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {studentName[i]}");
                }
                string userNameChoice = Console.ReadLine();
                bool validAns = false;

                //convert to int
                if (int.TryParse(userNameChoice, out userChoice))
                {//Check within range
                    if (int.Parse(userNameChoice) > studentName.Length)
                    {
                        Console.WriteLine("Not a valid number");
                    }
                    else
                    {
                        userChoice = int.Parse(userNameChoice) - 1;
                        validAns = true;
                        validAns2 = true;
                    }

                }
                else
                {
                    Console.WriteLine("Select the number of the student");

                }


                while (validAns2 == false || validAns == true)
                {

                    //ask for input of candy or title
                    Console.WriteLine("Do you want to know FAVORITE CANDY or previous TITLE? ");
                    string userChoice2 = Console.ReadLine();
                    if (userChoice2 == "CANDY" || userChoice2 == "candy")
                    {
                        validAns2 = true;
                        Console.WriteLine($"{studentName[userChoice]}'s favorite candy is {favFood[userChoice]}");
                        break;
                    }
                    else if (userChoice2 == "TITLE" || userChoice2 == "PREVIOUS TITLE" || userChoice2 == "title")
                    {
                        validAns2 = true;
                        Console.WriteLine($"{studentName[userChoice]}'s previous title was {studentTitle[userChoice]}");
                        break;
                    }
                    else
                    {
                        //prompt of again if category didn't exist
                        Console.WriteLine("not a valid choice, try again");

                    }

                }
                //Ask if user wants to check another student
                string userChoice3;
                Console.WriteLine("Do you want to learn about another student?(y/n)");
                userChoice3 = Console.ReadLine();
                if (userChoice3 == "n" || userChoice3 == "N" || userChoice3 == "No")
                {
                    userCont = false;
                }




            }
            Console.WriteLine("Thank you!");
        }
    }
}
