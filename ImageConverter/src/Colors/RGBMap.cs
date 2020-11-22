using System.Drawing;

namespace ImageConverter
{
    public struct RGBMap
    {
        public static int[,,] GetRGBColorMap(Bitmap bitmap)
        {
            int[,,] mapInt = new int [bitmap.Width, bitmap.Height, 4];
            for(int y=0; y < bitmap.Width; y++)
            {
                for(int x=0; x < bitmap.Height; x++)
                {
                    Color pixelColor = bitmap.GetPixel(y, x);
                    mapInt[y, x, 0] = pixelColor.R;
                    mapInt[y, x, 1] = pixelColor.G;
                    mapInt[y, x, 2] = pixelColor.B;
                    mapInt[y, x, 3] = pixelColor.A;
                }
            }

            return mapInt;
        }
        public static string GetRGBBinaryMas( int [,,] massPix)
        {
            string s = "";
            s = "{";
            for (int i = 0; i < massPix.GetLength(0); i++)
            {
                s += "{";
                for (int j = 0; j < massPix.GetLength(1); j++)
                {
                    s += "{ " + massPix[i, j, 0] +"," + massPix[i, j, 1] +","+ massPix[i, j, 2] +","+ massPix[i, j, 3]+ " }" + (j == massPix.GetLength(0)-1 ? "":",");
                }

                s += "}" + (i == massPix.GetLength(1)-1? "":",");
            }

            s += "}";
            return s;
        }
    }
}