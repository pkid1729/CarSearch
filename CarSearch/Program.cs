using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSearch
{
    class Program
    {
        //class bmw
        //class bmw
        //{
        //    void ShowBmw()
        //    {
        //        Console.WriteLine("Here you can get datails about BMW");
        //        Console.ReadLine();
        //    }
        //}
        //class mercedes
        //{
        //    void ShowMercedes()
        //    {
        //        Console.WriteLine("Here you can get datails about Mercedes");
        //        Console.ReadLine();

        //    }
        //}
        //class bugati
        //{
        //    void ShowBugati()
        //    {
        //        Console.WriteLine("Here you can get datails about Bugati");
        //        Console.ReadLine();
        //    }
        //}
        static void Main(string[] args)
        {
        
        //   // class Show1
        //{
        //    void ShowBmw()
        //    {
        //        Console.WriteLine("Here you can get datails about BMW");
        //        Console.ReadLine();
        //    }
        //    void ShowMercedes()
        //    {
        //        Console.WriteLine("Here you can get datails about Mercedes");
        //        Console.ReadLine();

        //    }
        //    void ShowBugati()
        //    {
        //        Console.WriteLine("Here you can get datails about Bugati");
        //        Console.ReadLine();
        //    }

           // void Show() {
            Console.WriteLine("Enter following key to get details 1.BMW \n2.Mercedes \n3.Bugati");
            string s = Console.ReadLine();
            Console.WriteLine("You searched for{0}", s);
            switch (s)
            {
                case "bmw":
                            {
                                Console.WriteLine("Here you can get datails about BMW");
                                Console.ReadLine();
                            break;
                            }
                        case "mercedes":
                            {
                                Console.WriteLine("Here you can get datails about Mercedes");
                                Console.ReadLine();
                            break;
                            }
                        case "bugati":
                            {
                                Console.WriteLine("Here you can get datails about Bugati");
                                Console.ReadLine();
                            break;
                            }
                        default:
                        break;
                       

                }
             Console.ReadLine();
            // public override string ReadLine();
        }
        }
    }

