//==========================================================
// Tyler Sriver
// Circle Class
// OOP
// 10/22/2014
//==========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace EnhancedPainter
{
    class Circle
    {
        //Integer for x coordinate of circle
        public int x {get; set;}
        //Integer for y coordinate of circle
        public int y { get; set;}
        //Integer for the size of the circle
        public int size {get; set;}
        //Color instance for the color of the cirlce 
        public Color brushColor {get; set;}
        
        //Default Constructor, no parameters 
        public Circle()
        {
           
        }

        //Constructor that takes 4 parameters, all the attributes of the circle
        public Circle(int SIZE, int X, int Y, Color color)
        {
            x = X;
            y = Y;
            size = SIZE;
            brushColor = color;
        }
        
        //Draw method to draw the circle
        public void draw(Graphics graphics)
        {                       
                graphics.FillEllipse(new SolidBrush(brushColor), x, y, size, size);            
        }

        //ToString override method to put the attributes into the context needed for 
        //Saving it to the file. "size, x, y, color"
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", size, x, y, brushColor.Name);
        }
    }
}
