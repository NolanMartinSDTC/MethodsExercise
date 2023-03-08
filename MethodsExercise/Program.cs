namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 method UserName

            
            UserName();


            //Exercise 2 operators methods

            //Console.WriteLine("Enter a number for variable x: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a number for variable y: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //var addResult = Add(x, y);
            //Console.WriteLine($"The sum of {x} and {y} is: {addResult}");

            //var subResult = Subtract(x, y);
            //Console.WriteLine($"The difference of {x} and {y} is: {subResult}");

            //var prodResult = Product(x, y);
            //Console.WriteLine($"The product of {x} and {y} is: {prodResult}");

            //var divResult = Divide(x, y);
            //Console.WriteLine($"The quotient of {x} and {y} is: {divResult}");

            //var modResult = Modulus(x, y);
            //Console.WriteLine($"The remainder of {x} divided by {y} is: {modResult}");

            // Exercise 2 operators methods challenge!
            int additionRes = Add(1, 2, 3, 4, 5);
            Console.WriteLine(additionRes);
            int subtractionRes = Subtract(1, 2, 3, 4, 5);
            Console.WriteLine(subtractionRes);
            int productRes = Product(1, 2, 3, 4, 5);
            Console.WriteLine(productRes);
            decimal quotientRes = Divide(1, 2, 3, 4, 5);
            Console.WriteLine(quotientRes);

        }

        // Exercise 1 method UserName

        public static void UserName()
            
        {
            Console.WriteLine("What is your first name?");
            var firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            var lastName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            var favFood = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var favAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite hobby?");
            var favHobby = Console.ReadLine();

            Console.WriteLine($"My name is {firstName} {lastName}. Some of my favorite things are..." +
                $"the color {favColor}, {favFood}, {favAnimal}, and {favHobby}. Nice to meet you!");
          
        }

        // Exercise 2 operator methods plus challenge! Woo! 

        public static int Add(params int[] list) // Adds together all values in the list
        {
            int sum = 0; // Starts at zero and adds all values
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum;
        }
        public static int Subtract(params int[] list) // Subtracts all values from the list 
        {
            int dif = list[0]; // Initialized with first value in the list so we are subtracting from that value instead of zero
            for (int i = 1; i < list.Length; i++)
            {
                dif -= list[i];
            }
            return dif;
        }
        public static int Product(params int[] list) // Multiplies all values in list together
        {
            int prod = list[0]; // Starts with first value in the list so we arent multiplying value of 0 by each number in the list
            for (int i = 1; i < list.Length; i++)
            {
                prod *= list[i];
            }
            return prod;
        }
        public static decimal Divide(params int[] list) // Divides the first number in the list by the rest of the numbers in the list
        {
            decimal div = list[0]; // Starts with first value in the list so we dont start off dividing by zero
            for (int i = 1; i < list.Length; i++)
            {
                div /= list[i];
            }
            return div;
        }
        public static int Modulus(int x, int y) // This one would get messy... I'll come back to this one
        {
            int mod = x % y;
            return mod;
        }

    }   
}
