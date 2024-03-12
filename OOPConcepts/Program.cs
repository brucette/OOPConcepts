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

                Person mathias = new Person(38, "Mathias", "Wahl", 1.70, 75);
                // Console.WriteLine($"{mathias.age} {mathias.name} {mathias.lName} {mathias.fName} {mathias.weight} {mathias.height}"); // all private fields are inaccessible

                // All the following throw the correct error messages:
                // mathias.Age = -3;
                // mathias.FName = "";
                // mathias.FName = "M";
                // mathias.FName = "Mathiasmath";
                // mathias.LName = "";
                // mathias.LName = "Wa";
                // mathias.LName = "Wahlwahlwahlwahl";


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


            // **** PUNKT 3.4.3 ****

            Horse horse = new Horse("Johnny", 200, 12, 2);
            Dog dog = new Dog("Beet", 70, 7, "great dane");
            Hedgehog hedgehog = new Hedgehog("Spiky", 5, 5, 167);
            Worm worm = new Worm("Squiggles", 0.2, 1, false);
            Wolf wolf = new Wolf("Luna", 90, 4, "white");
            Bird bird = new Bird("Tweeter", 0.5, 2, 20);
            Pelican pelican = new Pelican("Mouthy", 20, 8, 90, 30);
            Swan swan = new Swan("Necky", 30, 1, 120, 30);
            Flamingo flamingo = new Flamingo("Pinky", 20, 9, 60, 80);
            Wolfman wolfman = new Wolfman("Adam", 150, 100, "grey");
            Dog eje = new Dog("Eje", 30, 3, "french bulldog");
            Dog latte = new Dog("Latte", 40, 6, "finnish lapphund");


            List<Animal> animals = new List<Animal>
            {
                horse, dog, hedgehog, worm, wolf, bird, pelican, swan, flamingo, wolfman, eje, latte   
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"\nAnimal type is: {animal.GetType().Name}");
                animal.DoSound();

                if (animal is IPerson)
                { 
                    IPerson animalPerson = (IPerson) animal;
                    animalPerson.Talk();
                }
            }
            Console.WriteLine();

            // **** PUNKT 3.4.8 ****

            List<Dog> dogs = new List<Dog>();


            /* FRÅGA 9 & 10
               dogs.Add(horse); - detta fungerar inte eftersom listan tar bara djur som är av typ Dog,
               då Horse inte ärver Dog, funkar det inte. Alla djur ärver antingen direkt eller indirekt från Animal,
               listan måste därför vara av typ Animal för att alla klasser ska kunna lagras tillsammans. 
            */

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            /* FRÅGA 13
               för varje djur i listan kallas det just den typens Stats() metod. 
               Varje Stats() metod anropar basklassens metod, vilket returnerar namn, vikt och ålder,      
               egenskaperna som finns i varenda klass. Sedan läggs till de eventuella specifika 
               egenskaperna som finns i subklassen och returnernas alltihop. 
            */


            // **** PUNKT 3.4.14 ****

            Console.WriteLine("PROPERTIES FOR INSTANCES OF DOGS");

            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                { 
                    Console.WriteLine(animal.Stats());
                    // animal.CatchBall();
                    Dog castDog = (Dog) animal;
                    Console.WriteLine(castDog.CatchBall());
                }
            }

            /* FRÅGA 16 & 17
               Man kommer inte åt metod CatchBall() från Animal listan då metoden inte 
               finns i Animal klass. Listan innehåller instancer/objekt som behandlas av typ Animal 
               som bara har tillgång till Animals metoder.
               Genom att type-casta varje instans av Dog i Animal listan till Dog inom loopen, 
               kan man sen komma åt metoder även i Dog klassen.
            */
        }
    }
}
