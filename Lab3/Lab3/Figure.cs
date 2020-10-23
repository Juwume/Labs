using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
   
    interface IPrint
    {
        void Print();

    }
    abstract class Figure : IComparable
    {
        
        public abstract double Area { get; protected set; }
        public int CompareTo(object figure)
        {
            Figure temp = figure as Figure;
            if (temp != null)
                return this.Area.CompareTo(temp.Area);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
       
        protected double _Area;
    }

    class Rectangle : Figure, IPrint
    {
        public Rectangle(double param1, double param2) //(Ширина,Высота)
        {
            this.Width = param1;
            this.Height = param2;

        }
        public override double Area
        {
            get { return _Area; }
            protected set { _Area = Height * Width; }
        }

        public double Height
        {
            get { return _Height; }
            set
            {
                _Height = value;
                this.Area = 0;
            }
        }
        public double Width
        {
            get { return _Width; }
            set
            {
                _Width = value;
                this.Area = 0;
            }
        }
        public override string ToString()
        {

            string temp = $"Height={this.Height} Width={this.Width} area={this.Area}";
            return temp;

        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        protected double _Height;
        protected double _Width;

    }

    class Square : Rectangle
    {
        public Square(double Side) : base(Side, Side) { }
        new public double Height //Forbibs changing only one parameter 
        {
            get { return _Height; }
            set
            {
                _Height = value;
                _Width = value;
                Area = 0;
            }
        }
        new public double Width
        {
            get { return _Width; }
            set
            {
                _Height = value;
                _Width = value;
                Area = 0;
            }
        }

        public override string ToString()
        {

            string temp = $"Side={this.Height} area={this.Area}";
            return temp;

        }
        new public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }

    class Circle : Figure, IPrint
    {
        public Circle(double param)
        {
            this.Radius = param;
        }
        public override double Area
        {
            get { return _Area; }
            protected set { _Area = Math.PI * _Radius * _Radius; }
        }
        public double Radius
        {
            get { return _Radius; }
            set
            {
                _Radius = value;
                this.Area = 0;
            }
        }
        public override string ToString()
        {

            string temp = $"radius={this.Radius} area={this.Area}";
            return temp;

        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        private double _Radius;
    }
}
