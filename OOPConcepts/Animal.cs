using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

// 3.3:
// fråga 13 - om samtliga fåglar skulle behöva ett nytt attribut, skulle det läggas till klass Bird.
// fråga 14 - om alla djur skulle behöva ett nytt attribut, skulle det läggas till klass Animal.

namespace OOPConcepts
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();

        public Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }

    // Inheriting from Animal class:

    internal class Horse : Animal
    {
        public string Height { get; set; }

        public Horse(string name, int weight, int age, string height) : base(name, weight, age)
        {
            Height = height;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{GetType().Name} says Iiihahahaaa");
        }
    }

    internal class Dog: Animal 
    {
        public string Breed { get; set; }

        public Dog(string name, int weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{GetType().Name} says Woof woof");
        }
    }

    internal class Hedgehog: Animal
    { 
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, int weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
                NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{GetType().Name} says Sniff sniff");
        }
    }

    internal class Worm : Animal 
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, int weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{GetType().Name} says Sssssssssss");
        }
    }

    internal class Bird : Animal 
    { 
        public int WingSpan { get; set; }

        public Bird(string name, int weight, int age, int wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{GetType().Name} says Kraahkraah");
        }
    }

    internal class Wolf : Animal 
    {
        public string Color { get; set; }

        public Wolf(string name, int weight, int age, string color) : base(name, weight, age)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{GetType().Name} says Auououououououuuuuu");
        }
    }

    /////////// PUNKT 3.3.8 /////////
    // Inheriting from Bird class:

    internal class Pelican: Bird 
    {
        public int BeakLength { get; set; }

        public Pelican(string name, int weight, int age, int wingSpan, int beakLength) : base(name, weight, age, wingSpan)
        {
            BeakLength = beakLength;
        }
    }

    internal class Flamingo : Bird 
    {
        public int LegLength { get; set; }

        public Flamingo(string name, int weight, int age, int wingSpan, int legLength) : base(name, weight, age, wingSpan)
        {
            LegLength = legLength;
        }
    }

    internal class Swan : Bird 
    {
        public int NeckLength { get; set; }

        public Swan(string name, int weight, int age, int wingSpan, int neckLength) : base(name, weight, age, wingSpan)
        {
            NeckLength = neckLength;
        }
    }

    public interface IPerson 
    {
        void Talk();
    }

    internal class Wolfman: Wolf, IPerson 
    {
        public Wolfman(string name, int weight, int age, string color) : base(name, weight, age, color)
        {
           
        }

        public void Talk() 
        {
            Console.WriteLine($"{GetType().Name} says I'm a wolfman");
        }
    }
}
