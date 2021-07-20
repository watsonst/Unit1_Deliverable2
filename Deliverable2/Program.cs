using System;

namespace Deliverable2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string usersChoice = "";
            bool hello = true;
            bool sup = true;
            bool bye = true;
            string helloThere = "True";
            bool myBool = bool.Parse(helloThere);

            do
            { 
                Console.WriteLine("What would you like to say to the bot?");
                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "hello":
                        if (hello)
                        {
                            Console.WriteLine("Hi good to see you");
                            hello = false;
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry but you have already said that");
                        }
                        break;
                    case "sup":
                        if (sup)
                        {
                            Console.WriteLine("I am good");
                            hello = false;
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry but you have already said that");
                        }
                        break;
                    case "hello there":
                        if (myBool)
                        {
                            Console.WriteLine("General Kenobi");
                            myBool = false;
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry but you have already said that");
                        }
                        break;
                    case "bye":
                        if (bye)
                        {
                            Console.WriteLine("Good bye!");
                            hello = false;
                            Environment.Exit(0);
                        }
                        break;
                        

                  //  default:
                      //  break;
                }
                //switch (userInput)
                //{
                //    case "firstCase":
                //        Console.WriteLine("hello");
                //        break;
                //    case "secondCase":

                //        break;

                //    default:
                //        Console.WriteLine("Thats not an option");
                //        break;
                //}

                //if (userInput == "hello")
                //{
                //    //if hello continue, else you already said this
                //    Console.WriteLine("Hi good to see you");
                //}
                //else if (userInput == "bye")
                //{
                //    Console.WriteLine("Good bye!");
                //    break;
                //}
                //else if (userInput == "sup")
                //{
                //    Console.WriteLine("I am good");
                //}
                //else if (userInput == "hello there")
                //{
                //    Console.WriteLine("General Kenobi");
                //}
                //else if (userInput )
                //    Console.WriteLine("I'm sorry but you have already said that");

                Console.WriteLine("Would you like to say something else? Enter yes to continue.");
                usersChoice = Console.ReadLine().ToLower(); 

            } while (usersChoice == "yes");
        }
    }
}
