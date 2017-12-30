﻿using System;

namespace _2.Class_Box_Data_Validation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public string SurfaceArea()
        {
            return $"Surface Area - {(2 * this.Length * this.width + 2 * this.Length * this.height + 2 * this.width * this.height):f2}";
        }
        public string LateralSurfaceArea()
        {
            return $"Lateral Surface Area - {(2 * this.Length * this.height + 2 * this.width * this.height):f2}";
        }
        public string Volume()
        {
            return $"Volume - {(this.Length * this.width * this.height):f2}";
        }
    }
}