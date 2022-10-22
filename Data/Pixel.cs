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
		public double R { get => r; set => r = Check(value); }
		private double g;
		public double G { get => g; set => g = Check(value); }
		private double b;
		public double B { get => b; set => b = Check(value); }

		private double Check(double value)
		{
			if (value < _minValue || value > _maxValue)
				throw new ArgumentException();
			return value;
		}

	}
}
