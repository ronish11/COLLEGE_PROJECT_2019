﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_graphical_application
{
    class Polygon : Shape
    {
        public int x, y, width, height;
        public void Draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black);
                Point[] a = { new Point(x, y), new Point(x * 2, y * 2), new Point(x * 3, x * 3), new Point(x * 2, y * 1), new Point(x, y), new Point(x * 2, y * 2), new Point(x * 3, x * 3), new Point(x * 2, y * 1), new Point(x, y), new Point(x * 2, y * 2), new Point(x * 3, x * 3), new Point(x * 2, y * 1) };
                g.DrawPolygon(p, a);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Polygon 3,4,5,6,6
        public void SetParam(int x, int y, int width, int height)
        {
            try
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void set(params int[] list)
        {
            try
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
