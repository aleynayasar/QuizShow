using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuizShow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " QUİZ SHOW ";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(" **** WELCOME ****\n ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" THE GAME BEGANS...\n");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" LET'S START\a\n ");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(" GIVE THE ANSWERS IN CAPITAL LETTERS...");
            Console.WriteLine(" PRESS ENTER ");
            Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            string name, surname;
            int age;
            Console.Write(" NAME : ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write(" SURNAME : ");
            surname = Convert.ToString(Console.ReadLine());
            Console.Write(" AGE : ");
            age = Convert.ToInt16(Console.ReadLine());         
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;

            int _true, _false, puan;
            _true = 0;
            _false = 0;
            puan = 0;
            string s1, s2, s3, s4, s5, c1, c2, c3, c4, c5;
            Console.WriteLine(" 1- Clara ...... in London.");
            s1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" A-live\n B-lives\n C-lived\n D-living\n");
            Console.Write(" ANSWER : ");
            c1 = Console.ReadLine();
            if (c1 == "B")
            {
                _true = _true + 1;
                puan = +100;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("CONGRATULATIONS PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                _false = _false + 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(" WRONG ANSWER PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine(" 2- I think we will meet again ..... Sunday.");
            s2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" A-on\n B-at\n C-in\n D-last\n");
            Console.Write(" ANSWER : ");
            c2 = Console.ReadLine();
            if (c2 == "A")
            {
                _true = _true + 1;
                puan = +100;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("CONGRATULATIONS PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                _false = _false + 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(" WRONG ANSWER PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine(" 3- We watch the news ......");
            s3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" A-every evening\n B-last Sunday\n C-next evening\n D-yesterday night\n");
            Console.Write(" ANSWER : ");
            c3 = Console.ReadLine();
            if (c3 == "A")
            {
                _true = _true + 1;
                puan = +100;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(" CONGRATULATIONS PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                _false = _false + 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(" WRONG ANSWER PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine(" 4- This suitcase is too ..... for Shelia to carry home. You should help her.");
            s4 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" A-light\n B-heavy\n C-low\n D-difficult\n");
            Console.Write(" ANSWER : ");
            c4 = Console.ReadLine();
            if (c4 == "B")
            {
                _true = _true + 1;
                puan = +100;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(" CONGRATULATIONS PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                _false = _false + 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(" WRONG ANSWER PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine(" 5- The girl was watching ---- in the mirror when her boyfriend came in.");
            s5 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" A-himself\n B-itself\n C-herself\n D-themselves\n");
            Console.Write(" ANSWER : ");
            c5 = Console.ReadLine();
            if (c5 == "C")
            {
                _true = _true + 1;
                puan = +100;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(" CONGRATULATIONS PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                _false = _false + 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(" WRONG ANSWER PRESS ENTER ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

     
            Console.WriteLine(" Name: " + name);
            Console.WriteLine(" Surname: "+ surname);
            Console.WriteLine(" Number of correct: " + _true);
            Console.WriteLine(" Number of incorrect : " + _false);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine(" Total Points: " + puan);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine(" ********* GAME OVER *********\a ");

            Console.Read();
        }
    }
}
