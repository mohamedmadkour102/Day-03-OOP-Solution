using Demo.BuiltIn_Interface;
using Demo.Interface_Example_01;
using Demo.Interface_Example_02;
using Demo.Interface_Example_03;

namespace Demo
{
    internal class Program
    {

        #region Interface Example 02

        //public static void Print10NumbersFromSeries(SeriesByTwo series)
        //{
        //    if (series == null) return;
        //    for (int i = 0; i< 10; i++)
        //    {
        //        Console.Write($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}
        //public static void Print10NumbersFromSeries(SeriesByThree series)
        //{
        //    if (series == null) return;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //}

        // this is not overloading this is the same behaviour .. lets do diff thing 
        //public static void Print10NumbersFromSeries(ISeries series)
        //// هتاخد مني اوبجكت من اي كلاس بي أمبلمنت الانترفيس ، كده انا عملت الكود كونتراكت  
        //{
        //    if (series == null) return;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();

        //} 
        #endregion
        static void Main()
        {
            #region Interface Example01
            // IMyType myType ;
            // declare for ref of type "IMyType" refering to null 
            // this ref can refer to object from class or struct implementing the interface 
            //clr will allocate 4 bytes at stack 

            // myType = new IMyType(); ===> u cant create object from interface
            //MyType myType = new MyType();
            //myType.Salary = 1;
            //myType.MyFun(); // hello world 
            //myType.Print(); // u cant access the default implemented method 


            // this is the case that u can access the default implemented method ...
            //IMyType referencefrominterface = new MyType();
            //referencefrominterface.Salary = 10;
            //referencefrominterface.MyFun();
            //referencefrominterface.Print(); 
            #endregion

            #region Interface Example 02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);
            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree); 
            #endregion

            #region Interface Example 03 
            //Airplane airplane = new Airplane();
            //airplane.Backword();
            //airplane.Forward();
            // error bec the default access modifier inside the class is private 
            // as logic ==> زي ما قولنا ماحنا مش عارفين هيعمل اكسس لانهي واحده فيهم الفلايبول ولا الموفابل 
            // لذلك لما يكون عندي كلاس واخد 2 ميثودس من 2 انترفيس ونكون عاملينلهم ايمبلمنت اكسبلستلي هنروح نعمل ريفرنس من النترفيس 

            //IMovable movable = new Airplane();
            //movable.Backword();
            //movable.Forward();

            // هنا هينفذ الفوروارد او الباك ورد بتاع الاوبجكت اللي هو هيكون من نوع اير بلان 
            // هيعمل بايند للفانكشن بيزد اون ريفرنس هيروح يلاقيه انترفيس مفيش حاجه تتعمل ف هيعملها بايند بيزد اون اوبجكت اللي هو من نوع ايربلان  
            #endregion

            #region Shallow Copy
            //int []arr01 = { 1, 2, 3};
            //int []arr02 = { 4, 5, 6 };

            //Console.WriteLine($"hashcode of arr01 {arr01.GetHashCode()}");
            //Console.WriteLine($"hashcode of arr02 {arr02.GetHashCode()}");

            //arr02 = arr01;
            //Console.WriteLine("----------------------------");
            //Console.WriteLine($"hashcode of arr01 {arr01.GetHashCode()}");
            //Console.WriteLine($"hashcode of arr02 {arr02.GetHashCode()}");

            //arr02[0] = 100;

            //Console.WriteLine(arr01[0]); 

            #endregion

            #region Deep Copy
            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = { 4, 5, 6 };
            //Console.WriteLine($"hashcode of arr01 {arr01.GetHashCode()}");
            //Console.WriteLine($"hashcode of arr02 {arr02.GetHashCode()}");


            //arr02 = (int[]) arr01.Clone();
            //Console.WriteLine($"hashcode of arr01 {arr01.GetHashCode()}");
            //Console.WriteLine($"hashcode of arr02 {arr02.GetHashCode()}");

            //arr02[0] = 100;

            //Console.WriteLine(arr01[0]); 
            #endregion

            #region why description of clone method say it makes shallow copy 
            //string[] name01 = { "amr", "mona" };
            //string[] name02 = { "ahmed", "noura" };
            //Console.WriteLine($"hashcode of name01 {name01.GetHashCode()}");
            //Console.WriteLine($"hashcode of name02 {name02.GetHashCode()}");

            //name02 = (string[])name01.Clone(); Console.WriteLine("After clone ============");

            //Console.WriteLine($"hashcode of name01 {name01.GetHashCode()}");
            //Console.WriteLine($"hashcode of name02 {name02.GetHashCode()}");

            //Console.WriteLine("==========================");
            //Console.WriteLine(name01[0].GetHashCode());
            //Console.WriteLine(name02[0].GetHashCode());

            //name02[0] = "khaled";//still amr == string immutable  
            #endregion


            #region Builtin Interfaces
            //Employee employee01 = new Employee() { Id = 10, Name = "Ahmed", Salary = 10_000, Department = new Department() { Id = 101, Name = "sales" } };
            //Employee employee02 = new Employee() { Id = 10, Name = "Ahmed", Salary = 10_000, Department = new Department() { Id = 101, Name = "sales" } };


            //Console.WriteLine($"hashcode of emp01 {employee01.GetHashCode()}");
            //Console.WriteLine($"hashcode of emp02 {employee02.GetHashCode()}");

            //employee02 = (Employee)employee01.Clone(); // deep copy using clone 

            //Console.WriteLine("After Deepcopy=================");

            //Console.WriteLine($"hashcode of emp01 {employee01.GetHashCode()}");
            //Console.WriteLine($"hashcode of emp02 {employee02.GetHashCode()}");
            //Console.WriteLine("=================");
            //Console.WriteLine($" emp01 {employee01}");
            //Console.WriteLine($" emp02 {employee02}");

            //if (employee02.Department != null)
            //    employee02.Department.Name = "New";
            //Console.WriteLine(employee01.Department.Name); // dont change bec its deep copy 

            ////     employee02 = new Employee( employee01 ); // second way to make deep copy   

            #endregion
















        }
    }
}
