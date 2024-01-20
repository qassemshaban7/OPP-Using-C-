using routeOOP01.inheritance;
using routeOOP01.interfaces;
using System;

namespace routeOOP01
{
    internal class Program
    {
        #region polymorphism {function overloading}
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static double sum(int x, double y)
        {
            return x + y;
        }
        public static double sum(double x, int y)
        {
            return x + y;
        }
        public static double sum(double x, double y)
        {
            return x + y;
        }
        public static int sum(int x, int y, int z)
        {
            return x + y + z;
        }
        #endregion
        ////public static void proccessSeries (SeriesByTwo series)
        ////{
        ////    for (int i = 0; i < 10; i++)
        ////    {
        ////        Console.WriteLine(series?.Current);
        ////        series.GetNext();
        ////    }
        ////    series.Reset();
        ////}
        ////public static void proccessSeries(SeriesByThree series)
        ////{
        ////    for (int i = 0; i < 10; i++)
        ////    {
        ////        Console.WriteLine(series?.Current);
        ////        series.GetNext();
        ////    }
        ////    series.Reset();
        ////}
        public static void proccessSeries(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series?.Current}  ");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region struct
            //point p1;
            /////allocte 8 unitialized byte at stack

            //p1 = new point(3, 4);
            //Console.WriteLine(p1.ToString()); //namespace.datatype
            ////Console.WriteLine(p1.x);
            ////Console.WriteLine(p1.y);
            //point p2;
            //p2 = new point(5);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);
            #endregion
            /* opp
            * 1. encapsulation 
            * 2. inheritance
            * 3. polymorphism
            */
            #region encapsulation
            //employee e1 = new employee();
            //Console.WriteLine(e1);
            //employee e2 = new employee(20,"qassem",15);
            //Console.WriteLine(e2);
            //e1.empid = 1;  //attrubute
            //Console.WriteLine(e1);
            //e2.SetName("ali"); //setter
            //Console.WriteLine(e2.GetName()); //getter
            //e2.Salary = 1000;
            //Console.WriteLine(e2.Salary);
            #endregion
            #region indexer
            //phonebook note = new phonebook(3);
            //note.addnumber(0, "AHMED", 123);
            //note.addnumber(1, "AYA", 456);
            //note.addnumber(2, "AMR", 789);
            //note.addnumber(3, "ALI", 101);
            //Console.WriteLine(note.GetNumber("AYA")); //456
            //note.SetNumber("AYA", 999); //setter
            //Console.WriteLine(note.GetNumber("AYA")); //999 //getter
            //// indexer 
            //note["AYA"] = 777;
            //Console.WriteLine(note["AYA"]);
            //note["ALI"] = 111;
            //Console.WriteLine(note["ALI"]);

            //for (int i = 0; i <note.Size;  i++) 
            //{
            //    Console.WriteLine(note[i]);
            //}
            #endregion
            #region class
            //car c1;
            //c1 = new car(10, "Jeep", 200);
            //Console.WriteLine(c1);
            //Console.WriteLine(c1.ToString());
            //car c2;
            //c2 = new car(10);
            //Console.WriteLine(c2);
            //Console.WriteLine(c2.ToString());

            #endregion
            #region inheritance
            ////parent p1 = new parent(2,3);
            ////Child child = new Child(4,5,6);
            ////Console.WriteLine(child);
            ////Console.WriteLine(child.ToString());
            ////Console.WriteLine(child.product());

            #endregion
            #region polymorphism {function overloading}
            //int result = sum(4, 6);
            //Console.WriteLine( result);
            //int result2 = sum(4, 6 ,8);
            //Console.WriteLine(result2);
            //double result3 = sum(4, 3.2);
            //Console.WriteLine(result3);
            //double result4 = sum(3.2, 4);
            //Console.WriteLine(result4);

            #endregion
            #region polymorphism {function override}
            //typeA typeA = new typeA(1);
            //typeA.A = 2;
            //typeA.staticBindedShow();

            //typeB typeB = new typeB(3, 4);
            //typeB.B= 3;
            //typeB.A= 4;
            //typeB.staticBindedShow();

            //typeA RefBase = new typeB(1, 2);
            //RefBase.A = 22;
            ///////RefBase.B = 99; //////invalid
            //RefBase.staticBindedShow(); ////parent 
            //RefBase.DynamicBindedMethod();////child

            //typeB t = new typeC(1, 2, 3);
            //t.A = 22;
            //t.B = 22;
            ////t.C= 66; ////invalid
            //t.staticBindedShow();
            //t.DynamicBindedMethod();

            //typeA t2 = new typeC(4, 5, 6);
            //t2.A = 22;
            ////t2.B = 22; ////invalid
            ////t2.C= 66; ////invalid
            //t2.staticBindedShow();
            //t2.DynamicBindedMethod();
            #endregion
            #region interface example_1
            //IMyType myType = new MyType();
            //myType.myfun();
            //myType.print(); ///default implemented method
            //MyType type2 = new MyType();
            //type2.myfun();
            ///////type2.print(); ///invalid
            #endregion
            #region interface example_1
            //SeriesByTwo seriesByTwo =new SeriesByTwo();
            //proccessSeries(seriesByTwo);
            //SeriesByThree seriesByThree = new SeriesByThree();
            //proccessSeries(seriesByThree);
            //SeriesByFour seriesByFour = new SeriesByFour();
            //proccessSeries(seriesByFour);

            #endregion
            #region built in interface IConeable
            //emplloyyee emp1 = new emplloyyee();
            //emp1.Id = 1;
            //emp1.FullName = "qassem shaban";
            //emp1.Salary = 7000;

            /////object initializer
            //emplloyyee emp2 = new emplloyyee()
            //{
            //    Id = 2,
            //    FullName = "amr",
            //    Salary = 8500,
            //};

            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());
            /////اسمين دلع     
            //////emp1 = emp2;  ///deep copy

            //////emp1 = (emplloyyee)emp2.Clone(); ///Shallow copy using clone method
            //emp1 = new emplloyyee(emp2);   ///Shallow copy using copy constructor
            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());

            #endregion
            #region built in interface IComparable

            //emplloyyee[] emplloyyees = new emplloyyee[]
            //{
            //    new emplloyyee(){Id =1, FullName = "amr" , Salary =3000},
            //    new emplloyyee(){Id =2, FullName = "amged" , Salary =4000},
            //    new emplloyyee(){Id =3, FullName = "ahmed" , Salary =1000},
            //};
            //Array.Sort(emplloyyees);
            //foreach(emplloyyee emplloyyee in emplloyyees)
            //{
            //    Console.WriteLine(emplloyyee);
            //}
            ////for (int i = 0; i < emplloyyees?.Length; i++)
            ////{
            ////    int Result = emplloyyees[i].CompareTo(emplloyyees[i+1]);
            ////    if (Result == 1)
            ////        Swap();
            ////}
           
            #endregion

            Console.Read();
        }
    }
}
