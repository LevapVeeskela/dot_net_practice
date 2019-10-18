using System;
using Common.Constants;
using Infrastructure.Interfaces;

namespace BusinessLogic.Services
{
    public class TenCwFirstTaskService
    {
        public ISquare[] GetThreeForm()
        {
            var triangle = new Triangle(Constants.TenLesson.Basis, Constants.TenLesson.Height, Constants.TenLesson.NameTriangle);
            var circle = new Circle(Constants.TenLesson.Radius, Constants.TenLesson.NameCircle);
            var foursquare = new Foursquare(Constants.TenLesson.Side, Constants.TenLesson.NameSide);
            ISquare[] array = { triangle, circle, foursquare };
            return array;
        }

        public void WriteInConsole(ISquare[] array)
        {
            foreach (var form in array)
            {
                Console.WriteLine($"This is {form?.Name}. CLR Type is {form.GetType().FullName}. Square is {form?.GetSquare()}");
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