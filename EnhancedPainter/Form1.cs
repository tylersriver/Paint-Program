//==========================================================
// Tyler Sriver
// Enhanced Painter
// OOP
// 10/22/2014
//==========================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnhancedPainter
{
    public partial class Form1 : Form
    {
        //boolean to tell if it should be painting 
        bool shouldPaint;
        //Linked list of the instances of the circle class
        List<Circle> points;
        //Constructor for the form
        public Form1()
        {
            InitializeComponent();
            points = new List<Circle>();
            rdbtnSmall.Checked = true;
            rdbtnBlue.Checked = true;
        }

        //Method to redraw all the circles upon maximization
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Circle drawCircle in points)
            {
                using (Graphics graphics = panel1.CreateGraphics())
                {
                    drawCircle.draw(graphics);
                }
            }
        }

        //Method that tells what the mouse to do when it is pressed
        // includes: setting size and color, and drawing initial circle
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Circle drawCircle = new Circle();

            attributes(drawCircle);

            drawCircle.x = e.X - (drawCircle.size / 2);
            drawCircle.y = e.Y - (drawCircle.size / 2);
            shouldPaint = true;
            
            using(Graphics graphics = panel1.CreateGraphics())
            {
                drawCircle.draw(graphics);
            }

            points.Add(drawCircle);
        }

        // Method for when the mouse is not pressed.
        // doesnt allow painting
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        //Method that tells what the mouse to do when it is pressed
        //Includes: setting size and color, drawing circles
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Circle drawCircle = new Circle();
            attributes(drawCircle);
            if (shouldPaint)
            {
                drawCircle.x = e.X - (drawCircle.size / 2);
                drawCircle.y = e.Y - (drawCircle.size / 2);
                using (Graphics graphics = panel1.CreateGraphics())
                {
                    drawCircle.draw(graphics);
                }
                points.Add(drawCircle);
            }
        }

        //Method to set attributes of the Circles including siz and color
        private void attributes(Circle drawCircle)
        {
           if(rdbtnBlue.Checked)
            {
                drawCircle.brushColor = Color.Blue;
            }

            if(rdbtnRed.Checked)
            {
                drawCircle.brushColor = Color.Red;
            }

            if(rdbtnYellow.Checked)
            {
                drawCircle.brushColor = Color.Yellow;
            }
            if (rdbtnEraser.Checked)
            {
                drawCircle.brushColor = Color.White;
            }
            if(rdbtnSmall.Checked)
            {
                drawCircle.size = 7;
            }           
            if(rdbtnMedium.Checked)
            {
                drawCircle.size = 12;
            }
            if(rdbtnLarge.Checked)
            {
                drawCircle.size = 17;
            } 
            if(rdbtnMegaLarge.Checked)
            {
                drawCircle.size = 32;
            }
        }
        //Method for saving a file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StreamWriter fileWriter;
            DialogResult result;
            string fileName;

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                fileChooser.AddExtension = true;
                fileChooser.DefaultExt = ".txt";
                fileChooser.Filter = "Text Files (*.txt)|*.txt";
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (fileName == String.Empty)
                    MessageBox.Show("There is no name for that File.  You need to name your File.", "Give a File Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {

                    FileStream OutputFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    fileWriter = new StreamWriter(OutputFile);
                    foreach (var drawCircle in points)
                        fileWriter.WriteLine(drawCircle.ToString());
                    fileWriter.Close();
                    OutputFile.Close();
                }
            }
        }

        //Method for saving the drawing      
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string fileName;            
            DialogResult Result;            
            StreamReader fileReader;
                  
            using(OpenFileDialog fileChooser = new OpenFileDialog())
            {
                Result= fileChooser.ShowDialog();
                fileName = fileChooser.FileName;     
            }
            if(fileName == string.Empty)
                    MessageBox.Show("You must have a name for the file", "Please insert File Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                        
                     points = new List<Circle>();
                        
                     FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                     fileReader = new StreamReader(input);
                     string FileLine;
                        
                     do
                     {
                           
                        FileLine = fileReader.ReadLine();
                            
                        if (FileLine != null)
                        {
                                
                            string[] parts = FileLine.Split(',');                               
                            Circle temporary = new Circle(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]), Color.FromName(parts[3]));                                
                            points.Add(temporary);                                
                        }
                      }while (FileLine != null);
                        
                        panel1.Invalidate();                       
                        input.Close();
                        fileReader.Close();
                }                  
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"You chose the wrong file. " , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }  
        }
    }
}   

