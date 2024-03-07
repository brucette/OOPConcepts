namespace OOPConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person mathias = new Person(38, "Mathias", "Wahl", 170, 75);
            // Console.WriteLine(mathias.age);  is inaccessible
            Console.WriteLine(mathias.Age); // accessible
        }
    }
}
