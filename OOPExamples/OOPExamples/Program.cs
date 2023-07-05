
namespace OOPExamples
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Encapsulation Example
            Console.WriteLine("---------------------Encapsulation Example----------------");

            BankAccount account = new BankAccount();
            account.Deposit(1000);
            decimal balance = account.GetBalance(); 
            Console.WriteLine("Current Balance: " + balance);

            account.ResetBalance(); 
            decimal newBalance = account.GetBalance(); 
            Console.WriteLine("New Balance: " + newBalance);

        

            //Interface 
            Console.WriteLine("---------------------Interface Example----------------");
            Rectangle r1 = new Rectangle();

            r1.calculateArea(100, 200);

            //Generics
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Push(4);
            int poppedInt = intStack.Pop(); // Pops and returns 4
            Console.WriteLine("Popped Int: " + poppedInt);

            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Hello");
            stringStack.Push("Esraa");
            string poppedString = stringStack.Pop(); // Pops and returns "Esraa"
            Console.WriteLine("Popped String: " + poppedString);



            //Polymorphism static 
            Console.WriteLine("---------------------Polymorphism Example----------------");
            TestData dataClass = new TestData();
            int add2 = dataClass.Add(45, 34, 67);
            int add1 = dataClass.Add(23, 34);
            Console.WriteLine("Addition of two numbers: " + add1);

            //Polymorphism dynamic
            Console.WriteLine("---------------------Polymorphism Example----------------");
            Drawing circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Drawing square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Drawing rectangle = new Rectangle2();
            Console.WriteLine("Area :" + rectangle.Area());

        }
    }
}