using System;

namespace Factory_Pattern
{
    public static class Factory
    {
        public static IFood ServeFood(string foodType)
        {
            switch (foodType)
            {
                case "Italian":
                    return new Italian();
                case "Bangla":
                    return new Bangla();
                case "Chinese":
                    return new Chinese();
                default:
                    return new Basic();
            }
        }
    }

    public interface IFood
    {
        void GetFood();
    }

    class Italian : IFood
    {
        public void GetFood()
        {
            Console.WriteLine("Have Italian food");
        }
    }

    class Bangla : IFood
    {
        public void GetFood()
        {
            Console.WriteLine("Have Bangla food");
        }
    }

    class Chinese : IFood
    {
        public void GetFood()
        {
            Console.WriteLine("Have Chinese food");
        }
    }

    class Basic : IFood
    {
        public void GetFood()
        {
            Console.WriteLine("Have Basic food");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServeFood("Bangla");
            ServeFood("Chinese");
            ServeFood("Italian");
            ServeFood("I dont know");
        }

        static void ServeFood(string foodType){
            IFood orderedFood = Factory.ServeFood(foodType);
            orderedFood.GetFood();
        }
    }
}
