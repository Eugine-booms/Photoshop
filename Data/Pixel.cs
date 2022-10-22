using System;

namespace MyPhotoshop
{
	public class Pixel
	{
		
		public Pixel(double r, double g, double b)
		{
			if (r < 0 || r > 1)
				throw new ArgumentException(nameof (r));
			if (g < 0 ||g > 1)
				throw new ArgumentException(nameof(g));
			if (b < 0 || b > 1)
				throw new ArgumentException(nameof(b));
			
			R = r;
			G = g;
			B = b;
		}

		public double R { get; set; }
		public double G { get; set; }
		public double B { get; set; }

		public static Pixel operator *(Pixel pixel, double parametr)
		{
			return new Pixel(pixel.R * parametr, pixel.G * parametr, pixel.B * parametr);
		}
		
	}
}
