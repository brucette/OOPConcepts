using System.Linq;

namespace OOPConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // PUNKT 3.1.1
                // Person mathias = new Person(38, "Mathias", "Wahl", 1.70, 75);
                // Console.WriteLine(mathias.age); // age is inaccessible
                // Console.WriteLine($"Age is: {mathias.Age}"); // accessible
                // mathias.Age = -3;

                // PUNKT 3.1.5
                PersonHandler personHandler = new PersonHandler();
                Person chris = new Person(18, "Chris", "Ronaldo", 1.70, 75);
                Person sara = personHandler.CreatePerson(45, "Sara", "Jones", 1.64, 57);
                personHandler.SetAge(sara, 47);

                Console.WriteLine($"Age is: {sara.Age}" +
                    $"\nHeight is now {sara.Height}");
                personHandler.Grow(sara);

            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nError message: {ex.Message}");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"General Error message: Something went wrong!");
            }
            finally 
            {
                Console.ResetColor();
            }

            // PUNKT 3.2.7
            UserError error1 = new TextInputError();
            UserError error2 = new NumericInputError();
            UserError error3 = new NumericInputError();
            UserError error4 = new TextInputError();
            UserError error5 = new EmailInputError();
            UserError error6 = new DateInputError();
            UserError error7 = new OmitInputError();

            List<UserError> list = new List<UserError>
            {
                error1, error2, error3, error4, error5, error6, error7
            };

            foreach (UserError error in list) 
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
