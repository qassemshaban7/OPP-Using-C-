using System;

namespace routOOP2
{
    internal class Program
    {
        public static void DoSomeCode()
        {
            int X =0 , Y =0 , Z =0 ;

            try
            {
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                Z = int.Parse(Console.ReadLine());
                Z = X / Y;

                int[] Arr = new int[3];
                Arr[0] = 33;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex )
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finaly");
            }
            Console.WriteLine("After try catch");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="CustomExeption"></exception>
        public static void DoSomeProtectiveCode()
        {
            int X = 0, Y = 0, Z = 0;
            // X = int.Parse(Console.ReadLine());
            // Y = int.Parse(Console.ReadLine());
            // Z = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("pls enter first number");
            } while (!int.TryParse(Console.ReadLine(), out X));
            do
            {
                Console.WriteLine("pls enter Second number");
            } while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0);


            Z = X / Y;
            if (X > 0)
                throw new CustomExeption();
            int[] Arr = new int[3];
            if (Arr?.Length > 5)
                Arr[0] = 33;
            
        }
        static void Main(string[] args)
        {
            #region Interface

            //IFlayable flayable = new Airplane();
            //flayable.Forward();

            //IMoveable moveable = new Airplane();    
            //moveable.Forward();

            #endregion
            #region operator overloading
            //Complex c1 = new Complex() { Real = 1 , Imag = 2 };
            //Complex c2 = new Complex() { Real = 3 , Imag = 4 };
            //Complex c3 = default;
            ///null
            //Console.WriteLine($"c1  {c1}");
            //Console.WriteLine($"c2  {c2}");
            ////Console.WriteLine("----------------");
            //c3 = c1 + c2;
            ////Console.WriteLine($"c3   {c3}");
            //c1 += c2;
            ////Console.WriteLine($"c1   {c1}");
            //c1 = ++c2;
            ////Console.WriteLine($"c1  {c1}");
            //c1 = c2++;
            ////Console.WriteLine($"c1  {c1}");

            //if (c1 >c2 )
            //    Console.WriteLine("c1 is greater than c2");
            //else
            //    Console.WriteLine("c2 is greater than c1");

            //int x = c1;  //implicit casting
            //Console.WriteLine(x);
            //string str = (string)c1; //explicit casting
            //Console.WriteLine(str);

            #endregion
            #region casting operator overloading
            //employee employee = new employee()
            //{
            //    Id = 1 , FullName ="qassem shaban" ,Password ="456" ,SecurityStamp ="323G"
            //};

            //EmployeeVM employeeVM = (EmployeeVM) employee;
            //Console.WriteLine(employeeVM.FName);
            //Console.WriteLine(employeeVM.LName);

            #endregion
            #region Abstract 
            //Rect rect = new Rect()
            //{
            //    Dim01 = 10,
            //    Dim02 = 20,
            //};
            //Console.WriteLine(rect.CalcArea());

            #endregion
            #region static

            //Utility U1 = new Utility(1, 2);
            //Utility U2 = new Utility(6, 7);
            //Console.WriteLine(Utility.Cm2Inche(254));
            //Console.WriteLine(Utility.Cm2Inche(254));

            #endregion
            #region Sealed & Partial Class

            //Car car = new Car();    
            //car.Id = 1;

            #endregion
            #region Exeption handling and Protective Code

            ////DoSomeCode();
            //try
            //{
            //    DoSomeProtectiveCode();
            //} 
            //catch (Exception ex) 
            //{ 
            //    Console.WriteLine(ex.Message);  
            //}
            
            #endregion

            Console.ReadKey();
        }
    }
}
