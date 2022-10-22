using System;

namespace MyPhotoshop
{
	public class Pixel
	{
		private const int _minValue = 0;
		private const int _maxValue = 1;
		public Pixel(double r, double g, double b)
		{
			R = r;
			G = g;
			B = b;
		}
		public static double Trim(double value)
		{
			if (value > _maxValue)
				return _maxValue;
			if (value < _minValue)
				return _minValue;
			return value;
		}

		private double r;
		public double R { get => r; private set => r = Check(value); }
		private double g;
		public double G { get => g; private set => g = Check(value); }
		private double b;
		public double B { get => b; private set => b = Check(value); }

		public Pixel(double r, double g, double b)
		{
			this.r = this.g = this.b = 0;
			R = r;
			G = g;
			B = b;
		}

		public static Pixel operator *(Pixel p, double c) => new Pixel(Trim(p.R* c), Trim(p.G* c), Trim(p.B* c));
		
		public static Pixel operator *(double c, Pixel p) => p * c;

		private double Check(double value)
		{
			if (value < _minValue || value > _maxValue)
				throw new ArgumentException();
			return value;
		}

	}
}
