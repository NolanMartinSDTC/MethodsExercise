namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 method UserName

            //Console.WriteLine("What is your first name?");
            //var firstName = Console.ReadLine();

            //Console.WriteLine("What is your last name?");
            //var lastName = Console.ReadLine();

            //Console.WriteLine("What is your favorite color?");
            //var favColor = Console.ReadLine();

            //Console.WriteLine("What is your favorite food?");
            //var favFood = Console.ReadLine();

            //Console.WriteLine("What is your favorite animal?");
            //var favAnimal = Console.ReadLine();

            //Console.WriteLine("What is your favorite hobby?");
            //var favHobby = Console.ReadLine();

            //UserName(firstName, lastName, favColor, favFood, favAnimal, favHobby);


            //Exercise 2 operators methods

            Console.WriteLine("Enter a number for variable x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number for variable y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            var addResult = Add(x, y);
            Console.WriteLine($"The sum of {x} and {y} is: {addResult}");

            var subResult = Subtract(x, y);
            Console.WriteLine($"The difference of {x} and {y} is: {subResult}");

            var prodResult = Product(x, y);
            Console.WriteLine($"The product of {x} and {y} is: {prodResult}");

            var divResult = Divide(x, y);
            Console.WriteLine($"The quotient of {x} and {y} is: {divResult}");

            var modResult = Modulus(x, y);
            Console.WriteLine($"The remainder of {x} divided by {y} is: {modResult}");

        }

        //Exercise 1 method UserName

        public static void UserName(string nameFirst, string nameLast, string favColor, string favFood, string favAnimal, string favHobby)
            
        {
            Console.WriteLine($"My name is {nameFirst} {nameLast}. Some of my favorite things are..." +
                $"the color {favColor}, {favFood}, {favAnimal}, and {favHobby}. Nice to meet you!");
          
        }

        //Exercise 2 operator methods

        public static int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        public static int Subtract(int x, int y)
        {
            int dif = x - y;
            return dif;
        }
        public static int Product(int x, int y)
        {
            int prod = x * y;
            return prod;
        }
        public static double Divide(int x, int y)
        {
            double div = x / y;
            return div;
        }
        public static int Modulus(int x, int y)
        {
            int mod = x % y;
            return mod;
        }

    }   
}
