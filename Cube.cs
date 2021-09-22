using System;

namespace LearningVisualStudioC
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Cube has a length of {Length}");
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }
    }
}