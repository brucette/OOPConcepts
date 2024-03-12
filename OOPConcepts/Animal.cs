using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

// **** PUNKT 3.3 **** 

// FRÅGA 13 - om samtliga fåglar skulle behöva ett nytt attribut, skulle det läggas till klass Bird.
// FRÅGA 14 - om alla djur skulle behöva ett nytt attribut, skulle det läggas till klass Animal.

namespace OOPConcepts
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Properties for {GetType().Name}" +
                $"\nName: {Name}" +
                $"\nWeight: {Weight}" +
                $"\nAge: {Age}\n";
        }
    }

    // Inheriting from Animal class:
    internal class Horse : Animal
    {
        public int Height { get; set; }
        public Horse(string name, double weight, int age, int height) : base(name, weight, age)
        {
            Height = height;
        }
        public override void DoSound()
        {
            Console.WriteLine("iiihahahaaa");
        }
        public override string Stats()
        {
            string result = base.Stats();
            return result + $"Height: {Height}\n";
        }
    }

    internal class Dog: Animal 
    {
        public string Breed { get; set; }
        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }
        public override void DoSound()
        {
            Console.WriteLine("woof woof");
        }
        public override string Stats()
        {
            string result = base.Stats();
            return result + $"Breed: {Breed}\n";
        }
        public string CatchBall()
        {
            return "bounce bounce run run";
        }
    }

    internal class Hedgehog: Animal
    { 
        public int NrOfSpikes { get; set; }
        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
                NrOfSpikes = nrOfSpikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("sniff sniff");
        }
        public override string Stats()
        {
            string result = base.Stats();
            return result + $"NrOfSpikes: {NrOfSpikes}\n";
        }
    }

    internal class Worm : Animal 
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }
        public override void DoSound()
        {
            Console.WriteLine("ssssssssss");
        }
        public override string Stats()
        {
            string result = base.Stats();
            return result + $"IsPoisonous: {IsPoisonous}\n";
        }
    }

    internal class Bird : Animal 
    { 
        public int WingSpan { get; set; }
        public Bird(string name, double weight, int age, int wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }
        public override void DoSound()
        {
            Console.WriteLine("kraahkraah");
        }
        public override string Stats()
        {
            string result = base.Stats();
            return result + $"WingSpan: {WingSpan}\n";
        }
    }

    internal class Wolf : Animal 
    {
        public string Color { get; set; }
        public Wolf(string name, double weight, int age, string color) : base(name, weight, age)
        {
            Color = color;
        }
        public override void DoSound()
        {
            Console.WriteLine("auououououououuuuuu");
        }
        public override string Stats()
        {
            string result = base.Stats();
            return result + $"Color: {Color}\n";
        }
    }

    // Inheriting from Bird class:
    internal class Pelican: Bird 
    {
        public int BeakLength { get; set; }
        public Pelican(string name, double weight, int age, int wingSpan, int beakLength) : base(name, weight, age, wingSpan)
        {
            BeakLength = beakLength;
        }
        public override string Stats()
        {
            string result = base.Stats();
            return result + $"BeakLength: {BeakLength}\n";
        }
    }

    internal class Flamingo : Bird 
    {
        public int LegLength { get; set; }
        public Flamingo(string name, double weight, int age, int wingSpan, int legLength) : base(name, weight, age, wingSpan)
        {
            LegLength = legLength;
        }
        public override string Stats()
        {
            string result = base.Stats();
            return result + $"LegLength: {LegLength}\n";
        }
    }

    internal class Swan : Bird 
    {
        public int NeckLength { get; set; }
        public Swan(string name, double weight, int age, int wingSpan, int neckLength) : base(name, weight, age, wingSpan)
        {
            NeckLength = neckLength;
        }
        public override string Stats()
        {
            string result = base.Stats();
            return result + $"NeckLength: {NeckLength}\n";
        }
    }

    // Both inheriting from a class and implementing an interface
    public interface IPerson 
    {
        void Talk();
    }

    internal class Wolfman: Wolf, IPerson 
    {
        public Wolfman(string name, double weight, int age, string color) : base(name, weight, age, color)
        { }

        public void Talk() 
        {
            Console.WriteLine($"{GetType().Name} says I'm a wolfman");
        }
    }
}
