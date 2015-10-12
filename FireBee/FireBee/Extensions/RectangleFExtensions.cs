using System.Drawing;

namespace FireBee.Extensions
{
    public static class RectangleFExtensions
    {
        public static Rectangle ToRectangle(this RectangleF rectangle)
        {
            return new Rectangle((int)rectangle.X, (int)rectangle.Y, (int)rectangle.Width, (int)rectangle.Height);
        }

        public static RectangleF Copy(this RectangleF rectangle)
        {
            return new RectangleF(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        public static RectangleF AddWidth(this RectangleF rectangle, float width)
        {
            rectangle.Width += width;
            return rectangle;
        }

        public static RectangleF SetWidth(this RectangleF rectangle, float width)
        {
            rectangle.Width = width;
            return rectangle;
        }

        public static RectangleF AddHeight(this RectangleF rectangle, float height)
        {
            rectangle.Width += height;
            return rectangle;
        }

        public static RectangleF SetHeight(this RectangleF rectangle, float height)
        {
            rectangle.Width = height;
            return rectangle;
        }

        public static RectangleF AddX(this RectangleF rectangle, float x)
        {
            rectangle.X += x;
            return rectangle;
        }

        public static RectangleF SetX(this RectangleF rectangle, float x)
        {
            rectangle.X = x;
            return rectangle;
        }

        public static RectangleF AddY(this RectangleF rectangle, float y)
        {
            rectangle.Y += y;
            return rectangle;
        }

        public static RectangleF SetY(this RectangleF rectangle, float y)
        {
            rectangle.Y = y;
            return rectangle;
        }
    }
}