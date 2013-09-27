using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpStudy
{
    class ListTest
    {
        static void Main(string[] args)
        {
            ListTest p = new ListTest();
            List<string> list = new List<string>();
            list.Add("Cow");
            list.Add("Pig");
            list.Add("Horse");

            p.displayMenu();
            while (true)
            {
                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Input an animal: ");
                        string animal = Console.ReadLine();
                        list.Add(animal);
                        break;

                    case "2":
                        p.displayList(list);
                        break;
                    case "3":
                        Console.Write("Input an animal that you want to delete: ");
                        animal = Console.ReadLine();
                        if (list.Remove(animal))
                        {
                            Console.WriteLine("You have already deleted successfuly");
                        }
                        else
                        {
                            Console.WriteLine("Error happened!");
                        }
                        break;
                    case "4":
                        Console.Write("Enter 1 for ascending sort or 2 for descending sort: ");
                        string sortType = Console.ReadLine();

                        if (sortType == "1")
                        {
                            list.Sort();
                        }
                        if (sortType == "2")
                        {
                            list.Sort(
                                delegate(string a, string b)
                                {
                                    return string.Compare(b, a);
                                }
                            );
                        }

                        p.displayList(list);
                        break;

                    case "5":
                        Console.Write("Input your keyword to search: ");
                        string kw = Console.ReadLine();
                        List<string> rs = list.FindAll(
                            delegate(string a)
                            {
                                return a.Contains(kw);
                            }
                        );
                        Console.WriteLine("Result:");
                        p.displayList(rs);
                        break;
                    case "0":
                        p.displayMenu();
                        break;
                }

                
                if (choice == "x")
                {
                    break;
                }
            }
        }

        public void displayMenu()
        {
            Console.WriteLine("//-------------------MENU----------------------//");
            Console.WriteLine("\t1. Add new");
            Console.WriteLine("\t2. Display list");
            Console.WriteLine("\t3. Remove");
            Console.WriteLine("\t4. Sorting");
            Console.WriteLine("\t5. Find");
            Console.WriteLine("\t0. Menu");
            Console.WriteLine("\tx. Quit");
        }
        public void displayList(List<string> list)
        {
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }
        }

    }
}
