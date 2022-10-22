using System;

namespace MyPhotoshop
{
	public class Photo
	{
		public Photo(int width, int height)
		{
			if (width <= 0)
				throw new ArgumentException(nameof(width), $"Ширина фото не могжет быть <=0");
			if (height <= 0)
				throw new ArgumentException(nameof(height), $"Высота фото не может быть <=0");
			Width = width;
			Height = height;
			Pixels = new Pixel[width, height];
		}
		public int Width { get; set; }
		public int Height { get; set; }
		public Pixel[,] Pixels { get; private set; }

		public void SetPixel(int x, int y, Pixel pixel)
		{
			this.Pixels[x, y] = pixel;
		}
	}
}

