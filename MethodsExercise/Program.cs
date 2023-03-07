namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 method UserName

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

            UserName(firstName, lastName, favColor, favFood, favAnimal, favHobby);


        }

        //Exercise 1 method UserName

        public static void UserName(string nameFirst, string nameLast, string favColor, string favFood, string favAnimal, string favHobby)
            
        {
            Console.WriteLine($"My name is {nameFirst} {nameLast}. Some of my favorite things are..." +
                $"the color {favColor}, {favFood}, {favAnimal}, and {favHobby}. Nice to meet you!");
          
        }

        

    }   
}
