using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FireBee.Extensions
{
    public static class RectangleExtensions
    {
        public static Rectangle SetWidth(this Rectangle rectangle, int width)
        {
            rectangle.Width = width;
            return rectangle;
        }

        public static Rectangle AddWidth(this Rectangle rectangle, int width)
        {
            rectangle.Width += width;
            return rectangle;
        }

        public static Rectangle SetHeight(this Rectangle rectangle, int height)
        {
            rectangle.Height = height;
            return rectangle;
        }

        public static Rectangle AddHeight(this Rectangle rectangle, int height)
        {
            rectangle.Height += height;
            return rectangle;
        }

        public static Rectangle SetX(this Rectangle rectangle, int x)
        {
            rectangle.X = x;
            return rectangle;
        }

        public static Rectangle AddX(this Rectangle rectangle, int x)
        {
            rectangle.X += x;
            return rectangle;
        }

        public static Rectangle SetY(this Rectangle rectangle, int y)
        {
            rectangle.Y = y;
            return rectangle;
        }

        public static Rectangle AddY(this Rectangle rectangle, int y)
        {
            rectangle.Y += y;
            return rectangle;
        }

        public static Rectangle Copy(this Rectangle rectangle)
        {
            return new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }


    }
}
