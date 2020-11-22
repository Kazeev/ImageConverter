using System.Drawing;

namespace ImageConverter
{
    public struct GryMap
    {
        public static int[,] GetGryColorMap(Bitmap bitmap)
        {
            int[,] mapInt = new int [bitmap.Width, bitmap.Height];
            for(int y=0; y < bitmap.Width; y++)
            {
                for(int x=0; x < bitmap.Height; x++)
                {
                    Color pixelColor = bitmap.GetPixel(y, x);
                    //  0.3 · r + 0.59 · g + 0.11 · b
                    int grey = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

                    mapInt[y,x] = grey<200 ? 1 : 0;
                }
            }

            return mapInt;
        }
        public static string GetGryBinaryMas( int [,] massPix)
        {
            string s = "";
            s = "{";
            for (int i = 0; i < massPix.GetLength(0); i++)
            {
                s += "{";
                for (int j = 0; j < massPix.GetLength(1); j++)
                {
                    s += massPix[i, j] + (j == massPix.GetLength(0)-1 ? "":",");
                }

                s += "}" + (i == massPix.GetLength(1)-1? "":",");
            }

            s += "}";
            return s;
        }
    }
}