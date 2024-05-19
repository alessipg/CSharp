using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            /*
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}", shape.Name, shape.Area());
                
                Circle test = shape as Circle;
                if (test == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                if(test is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }
            }

            object circ1 = new Circle(4);
            Circle circ2 = (Circle)circ1;
            Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());

            
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };

            grover.Sound = "Wooooof";

            whiskers.MakeSound();
            grover.MakeSound();
            whiskers.SetAnimalIDInfo(12345, "Sally Smith");
            grover.SetAnimalIDInfo(12346, "Paul Brown");
            whiskers.GetAnimalIDInfo();
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));
            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooofff",
                Sound2 = "Geeerrr"
            };
            spot.MakeSound();

            Console.WriteLine("The cat is name {0} and says {1}",
                cat.GetName(), cat.Sound );
            cat.Owner = "Gabriel";
            Console.WriteLine("{0} owner is {1}",
                cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter id is {1}",
                cat.GetName(), cat.idNum);
            Console.WriteLine("# of animals : {0}",
                Animal.NumOfAnimals);
            Console.WriteLine("# of animals : {0}",
                Animal.numOfAnimals);
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}",
                rect1.Area());
            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length : {0}",
                rect2.length);

            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };

            Console.WriteLine("# of Animals {0}",
                Animal.GetNumAnimals());

            Console.WriteLine("Area of Rectangle : {0}",
                ShapeMath.GetArea("rectangle", 5, 6));

            int? randNum = null;
            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }
            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }
            */
        }

        /*struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1)
            {
                this.length = l;
                this.width = w;
            }
            public double Area()
            {
                return length * width;
            }
        }*/
    }
}
