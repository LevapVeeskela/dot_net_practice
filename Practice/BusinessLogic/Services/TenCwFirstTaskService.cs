using System;
using Infrastructure.Interfaces;

namespace BusinessLogic.Services
{
    public class TenCwFirstTaskService
    {
        public object[] GetThreeForm()
        {
            var triangle = new Triangle(10, 20, "Triangle");
            var circle = new Circle(10, "circle");
            var foursquare = new Foursquare(10, "Foursquare");
            object[] array = { triangle, circle, foursquare };
            return array;
        }

        public void WriteInConsole(object[] array)
        {
            foreach (var form in array)
            {
                var tempForm = form as ISquare;
                Console.WriteLine($"This is {tempForm.Name}. CLR Type is {form.GetType().FullName}. Square is {tempForm.GetSquare()}");
            }
        }


        public class Triangle : ISquare
        {
            private const double Half = 0.5;
            private readonly ushort _basis;
            private readonly ushort _height;

            public Triangle(ushort basis, ushort height, string name)
            {
                _basis = basis;
                _height = height;
                Name = name;
            }

            public string Name { get; set; }

            public ushort GetSquare()
            {
                return (ushort)(Half * _basis * _height);
            }
        }
        public class Circle : ISquare
        {
            private readonly ushort _radius;

            public Circle(ushort radius, string name)
            {
                _radius = radius;
                Name = name;
            }

            public string Name { get; set; }

            public ushort GetSquare()
            {
                return (ushort)(Math.PI * _radius * _radius);
            }
        }
        public class Foursquare : ISquare
        {
            private readonly ushort _side;

            public Foursquare(ushort side, string name)
            {
                _side = side;
                Name = name;
            }

            public string Name { get; set; }

            public ushort GetSquare()
            {
                return (ushort)(_side * _side);
            }
        }
    }
}