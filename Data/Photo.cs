using System;
using System.Drawing;

namespace MyPhotoshop
{
	public class Photo
	{
		private readonly Pixel[,] pixels;
		public readonly int width;
		public readonly int height;

		public Photo(Bitmap bmp) : this(bmp.Width, bmp.Height)
		{

			for (int x = 0; x < bmp.Width; x++)
				for (int y = 0; y < bmp.Height; y++)
				{
					var pixel = bmp.GetPixel(x, y);
					this.SetPixel(x, y, new Pixel ( (double)pixel.R / 255 , (double)pixel.G / 255 ,  (double)pixel.B / 255 ));
				}
		}

		public Photo(int width, int height)
		{
			if (width <= 0)
				throw new ArgumentException(nameof(width), $"Ширина фото не могжет быть <=0");
			if (height <= 0)
				throw new ArgumentException(nameof(height), $"Высота фото не может быть <=0");
			this.width = width;
			this.height = height;
			pixels = new Pixel[width, height];
		}
		
		public Pixel this[int x, int y]
		{
			get
			{
				Check(x, y);
				return pixels[x, y];
			}
			set => SetPixel(x, y, value);
		}

		public void SetPixel(int x, int y, Pixel pixel)
		{
			this.pixels[x, y] = pixel;
		}
		private void Check(int x, int y)
		{
			if (x < 0 || x > width)
				throw new ArgumentException(nameof(x));
			if (y < 0 || y > height)
				throw new ArgumentException(nameof(y));
		}
	}
}

