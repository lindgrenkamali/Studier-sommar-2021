using System;
using System.Collections.Generic;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace WorkingWithImages
{
    class Program
    {
        static void Main(string[] args)
        {
            PicturesToGrayScale();
        }

        private static void PicturesToGrayScale()
        {
            string imagesFolder = Path.Combine(Environment.CurrentDirectory, "Bilder");
            IEnumerable<string> images = Directory.EnumerateFiles(imagesFolder);
            foreach (string imagePath in images)
            {
                string thumbnailPath = Path.Combine(Environment.CurrentDirectory, "Bilder", Path.GetFileNameWithoutExtension(imagePath) + "-thumbnail" + Path.GetExtension(imagePath));
                using (Image img = Image.Load(imagePath))
                {
                    img.Mutate(i => i.Resize(img.Width / 12, img.Height / 12));
                    img.Mutate(i => i.Grayscale());
                    img.Save(thumbnailPath);
                }
            }

           
    }
    }
}
