using System.Drawing;

namespace FireBee.Extensions
{
    public static class RectangleFExtensions
    {
        public static Rectangle ToRectangle(this RectangleF rectangle)
        {
            return new Rectangle((int)rectangle.X, (int)rectangle.Y, (int)rectangle.Width, (int)rectangle.Height);
        }
    }
}