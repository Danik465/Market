using System;
using System.Collections.Generic;
using System.Threading;

namespace GameTestOne
{

    public class Person
    {

        public class Part
        {
            public int x, y, oldx, oldy;

        }
        public int MessageX, MessageY;
        public List<Part> parts = new List<Part>();
    }
    class Program
    {

        public static bool isStarted;
        public static int width = 120, height =28;
        public static Person person;
        public static move dir = move.stop;
        public enum move { up, down, left, right, stop }
         


        public static void Init()
        {
            person = new Person() { MessageX = width -119, MessageY = height -8, parts = new List<Person.Part>() { new Person.Part() { x = (width) - 119, y = height -27, oldx = (width / 2) - 1, oldy = height / 2 } } };
            Console.CursorVisible = false;
            isStarted = true;

        }


        public static void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.SetCursorPosition(j, i);
                    if (j == 0 && i == 0)
                    {
                        Console.Write("╔");
                        continue;
                    }
                    if (j == width - 1 && i == 0)
                    {
                        Console.Write("╗");
                        continue;
                    }
                    if (j == 0 && i == height - 1)
                    { Console.Write("╚");
                      continue; 
                    }
                    if (j == width - 1 && i == height - 1)
                    {
                        Console.Write("╝");
                        continue;
                    }

                    if (i == 0 || i == height - 1) 
                    {
                        Console.Write("═");
                        continue;
                    }
                   
                    if (j == 0 || j == width - 1)
                    {
                        Console.Write("║");
                    }
                    if (i == height - 9)
                    {
                        Console.Write("═");
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            
           

            Console.SetCursorPosition(person.MessageX, person.MessageY);
            string source = ("Для начала игры вам нужно взять три карты, но выбирайте с умом.");
            Console.Write(source);
            for (int i = 0; i < person.parts.Count; i++)
            {

                Vibor();
                void Vibor()
                {



                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y);
                    Console.Write("1.Wolf(attak-3 hp-2)");
                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y + 1);
                    Console.Write("2.Fox (attak-2 hp-3)");
                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y + 2);
                    Console.Write("3.turtle (attak-1 hp-4)");
                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y + 3);
                    Console.Write("4.ferret (attak-2 hp-2)");
                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y + 4);
                    Console.Write("5.bear (attak-4 hp-2)");
                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y + 5);
                    Console.Write("6.snake (attak-1 hp-2)");
                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y + 6);
                    Console.Write("7.squirrel (attak-0 hp-2)");
                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y + 7);
                    Console.Write("8.deer (attak-4 hp-3)");
                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y + 8);
                    Console.Write("9.ants (attak-1 hp-4)");
                    Console.SetCursorPosition(person.parts[i].x, person.parts[i].y + 9);
                    Console.Write("10.goat (attak-1 hp-1)");
                }


                int koloda = 0;
                while (koloda < 3)
                {
                    Console.SetCursorPosition(person.MessageX, person.MessageY + 2);
                    string answer = Console.ReadLine();
                    Console.SetCursorPosition(person.MessageX, person.MessageY);
                    Console.WriteLine("                                                                         ");
                    
                   
                    if (answer == "1")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Wolf    (attak-3 hp-2)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }
                    else if (answer == "2")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Fox     (attak-2 hp-3)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }

                    else if (answer == "3")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Turtle  (attak-1 hp-4)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }
                    else if (answer == "4")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Ferret  (attak-2 hp-2)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }
                    else if (answer == "5")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Bear    (attak-4 hp-2)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }
                    else if (answer == "6")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Snake    (attak-1 hp-2)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }
                    else if (answer == "7")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Squirrel  (attak-0 hp-2)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }
                    else if (answer == "8")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Deer      (attak-4 hp-3)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }
                    else if (answer == "9")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Ants      (attak-1 hp-4)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }
                    else if (answer == "10")
                    {
                        Console.SetCursorPosition(person.MessageX, person.MessageY);
                        Console.WriteLine("Goat      (attak-1 hp-1)");
                        Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                        Console.WriteLine("                                                                         ");
                    }
                    else
                    {
                     Console.WriteLine("Такой карты нет, посмотри еще.");
                    }
                    koloda++;
                    person.MessageY++;


                    
                }

                Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                Console.WriteLine("                                                                         ");
                Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
                Console.WriteLine("                                                                         ");
                




            }
            Console.SetCursorPosition(person.MessageX, person.MessageY);
            Console.WriteLine("Надеюсь это окончательное решение, потому что пути назад не будет...");
            Console.SetCursorPosition(person.MessageX, person.MessageY + 1);
            
        }

        static void Main(string[] args)
        {

            Init();
            while (isStarted)
            {
               
                Draw();
                Thread.Sleep(100000);

            }
        }

    }
}







