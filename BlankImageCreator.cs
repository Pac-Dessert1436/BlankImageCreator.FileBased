#:package System.Drawing.Common@10.0.0
using System.Drawing;

namespace BlankImageCreator;

file static class Program
{
    internal static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("USAGE: dotnet run BlankImageCreator.cs <width> <height>");
            return;
        }

        if (!int.TryParse(args[1], out int width) || !int.TryParse(args[2], out int height)
            || width <= 0 || height <= 0)
        {
            Console.WriteLine("Invalid width or height. Please specify valid integers.");
            return;
        }

        if (OperatingSystem.IsWindowsVersionAtLeast(6, 1))
        {
            using Bitmap bitmap = new(width, height);
            using Graphics graphics = Graphics.FromImage(bitmap);

            string outputPath = $"blank_{width}x{height}.png";
            bitmap.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);
            Console.WriteLine($"Generated blank PNG image: {outputPath}");
        }
        else
        {
            Console.WriteLine("This program only supports Windows 7 or later.");
        }
    }
}