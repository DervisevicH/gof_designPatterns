using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public static class CarFactory
    {
        public static ICarSupplier GetCarInstance(int id)
        {
            switch (id)
            {
                case 0: return new Honda();
                case 1: return new Suzuki();
                default: return null; 
            }
        }
    }

    public interface ICarFactory
    {
        ICarSupplier CreateCarSupplier();
    }


    public class CarFactoryById : ICarFactory
    {
        private readonly int _id;

        public CarFactoryById(int id)
        {
            _id = id;
        }

        public ICarSupplier CreateCarSupplier()
        {
            switch (_id)
            {
                case 0: return new Honda();
                case 1: return new Suzuki();
                default: return null;
            }
        }
    }


    public class CarFactoryByName : ICarFactory
    {
        private readonly string _name;

        public CarFactoryByName(string name)
        {
            _name = name;
        }

        public ICarSupplier CreateCarSupplier()
        {
            switch (_name)
            {
                case "Honda": return new Honda();
                case "Suzuki": return new Suzuki();
                default: return null;
            }
        }
    }



}
