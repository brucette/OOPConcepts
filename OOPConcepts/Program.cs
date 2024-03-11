using System.Linq;

namespace OOPConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // **** PUNKT 3.1.1 ****
                // Person mathias = new Person(38, "Mathias", "Wahl", 1.70, 75);
                // Console.WriteLine($"{mathias.age} {mathias.name} {mathias.lName} {mathias.fName} {mathias.weight} {mathias.height}"); // all private fields are inaccessible
                
                // Console.WriteLine($"Age is: {mathias.Age}"); // accessible
                // mathias.Age = -3;

                // All the following throw the correct error messages:
                // Person mathias2 = new Person(0, "Mathias", "Wahl", 1.70, 75);
                // Person mathias3 = new Person(38, "Mathiasmath", "Wahl", 1.70, 75);
                // Person mathias4 = new Person(38, "Mathias", "Wa", 1.70, 75);
                // Person mathias = new Person(38, "", "Wa", 1.70, 75);

                // **** PUNKT 3.1.5 ****
                PersonHandler personHandler = new PersonHandler();

                Person chris = personHandler.CreatePerson(18, "Chris", "Ronaldo", 1.70, 75);
                Person sara = personHandler.CreatePerson(45, "Sara", "Jones", 1.64, 57);

                personHandler.LoseWeight(chris, 20);
                personHandler.Grow(chris);
                Console.WriteLine($"Chris now weighs: {chris.Weight} and is {chris.Height} tall");

                personHandler.SetAge(sara, 47);
                Console.WriteLine($"Sara's age is now: {sara.Age}");

                // personHandler.Grow(sara); // throws correct error
                personHandler.LoseWeight(chris, 50); // throws correct error
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

            // **** PUNKT 3.2.7 - 8 ****
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

            Wolfman wolf = new Wolfman("thewolf", 34, 34, "grey");
            wolf.DoSound();
            wolf.Talk();
        }
    }
}
