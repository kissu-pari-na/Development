using System;

namespace Factory_Method_Pattern
{

    public abstract class Logistics
    {
        public abstract ITransport GetTransport();

        public void Transport()
        {
            ITransport transport = GetTransport();
            transport.Deliver();
        }
    }

    public class RoadLogistics: Logistics
    {
        public override ITransport GetTransport(){
            return new Truck();
        }
    }

    public class ShipLogistics: Logistics
    {
        public override ITransport GetTransport(){
            return new Ship();
        }
    }

    public interface ITransport
    {
        void Deliver();
    }

    class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivered by Truck");
        }
    }

    class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivered by Ship");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClientCode(new RoadLogistics());
            ClientCode(new ShipLogistics());
        }

        static void ClientCode(Logistics logistics)
        {
            logistics.Transport();
        }
    }
}
