using BOOSE;
using System;
using System.Drawing;

namespace BOOSEapp
{
    /// <summary>
    /// Custom implementation of the BOOSE ICanvas interface.
    /// Provides unrestricted drawing functionality for lines, shapes, and text.
    /// </summary>
    public class AppCanvas : ICanvas
    {
        private Bitmap CanvasBitmap;
        private Graphics g;
        private int xPos, yPos;
        private Pen Pen;

        /// <summary>
        /// Initializes the drawing canvas with a specified width and height.
        /// </summary>
        /// <param name="xsize">Width of the canvas in pixels.</param>
        /// <param name="ysize">Height of the canvas in pixels.</param>
        public AppCanvas(int xsize, int ysize)
        {
            CanvasBitmap = new Bitmap(xsize, ysize);
            g = Graphics.FromImage(CanvasBitmap);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Xpos = 100;
            Ypos = 100;
            Pen = new Pen(Color.Black, 2);
        }

        /// <summary>
        /// Gets or sets the current X-coordinate of the drawing cursor.
        /// </summary>
        public int Xpos { get => xPos; set => xPos = value; }

        /// <summary>
        /// Gets or sets the current Y-coordinate of the drawing cursor.
        /// </summary>
        public int Ypos { get => yPos; set => yPos = value; }

        /// <summary>
        /// Gets or sets the pen color used for drawing.
        /// </summary>
        public object PenColour
        {
            get => Pen.Color;
            set => Pen.Color = (Color)value;
        }

        /// <summary>
        /// Draws or fills a circle on the canvas.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <param name="filled">If true, fills the circle; otherwise, outlines it.</param>
        public void Circle(int radius, bool filled)
        {
            try
            {
                if (filled)
                    g.FillEllipse(new SolidBrush(Pen.Color), Xpos - radius, Ypos - radius, radius * 2, radius * 2);
                else
                    g.DrawEllipse(Pen, Xpos - radius, Ypos - radius, radius * 2, radius * 2);
            }
            catch (Exception ex)
            {
                throw new Exception("Error drawing circle: " + ex.Message);
            }
        }

        /// <summary>
        /// Clears the canvas to a white background.
        /// </summary>
        public void Clear()
        {
            g.Clear(Color.White);
        }

        /// <summary>
        /// Draws a line from the current cursor position to the specified coordinates.
        /// </summary>
        public void DrawTo(int x, int y)
        {
            g.DrawLine(Pen, Xpos, Ypos, x, y);
            Xpos = x;
            Ypos = y;
        }

        /// <summary>
        /// Returns the current bitmap image of the canvas.
        /// </summary>
        public object getBitmap()
        {
            return CanvasBitmap;
        }

        /// <summary>
        /// Moves the cursor to the specified coordinates without drawing.
        /// </summary>
        public void MoveTo(int x, int y)
        {
            Xpos = x;
            Ypos = y;
        }

        /// <summary>
        /// Draws or fills a rectangle.
        /// </summary>
        public void Rect(int width, int height, bool filled)
        {
            try
            {
                if (filled)
                    g.FillRectangle(new SolidBrush(Pen.Color), Xpos, Ypos, width, height);
                else
                    g.DrawRectangle(Pen, Xpos, Ypos, width, height);
            }
            catch (Exception ex)
            {
                throw new Exception("Error drawing rectangle: " + ex.Message);
            }
        }

        /// <summary>
        /// Resets the cursor to its default position (100,100).
        /// </summary>
        public void Reset()
        {
            Xpos = 100;
            Ypos = 100;
        }

        /// <summary>
        /// Sets a new bitmap canvas with the given dimensions.
        /// </summary>
        public void Set(int width, int height)
        {
            CanvasBitmap = new Bitmap(width, height);
            g = Graphics.FromImage(CanvasBitmap);
            g.Clear(Color.White);
        }

        /// <summary>
        /// Changes the pen color using RGB values.
        /// </summary>
        public void SetColour(int red, int green, int blue)
        {
            Pen.Color = Color.FromArgb(red, green, blue);
        }

        /// <summary>
        /// Draws a triangle from the current position.
        /// </summary>
        public void Tri(int width, int height)
        {
            Point[] points =
            {
                new Point(Xpos, Ypos),
                new Point(Xpos + width / 2, Ypos - height),
                new Point(Xpos + width, Ypos)
            };
            g.DrawPolygon(Pen, points);
        }

        /// <summary>
        /// Writes text at the current cursor position.
        /// </summary>
        public void WriteText(string text)
        {
            g.DrawString(text, new Font("Arial", 10), new SolidBrush(Pen.Color), Xpos, Ypos);
        }
    }
}
