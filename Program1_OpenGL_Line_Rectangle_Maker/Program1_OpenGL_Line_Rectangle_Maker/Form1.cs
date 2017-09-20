using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using Figures;

namespace Program1_OpenGL_Line_Rectangle_Maker
{
   public partial class Form1 : Form
   {

      private List<Figure> FigureList;
      private Figure curFigure;

      public Form1()
      {
         InitializeComponent();
         FigureType.Items.Add("Line");
         FigureType.Items.Add("Rectangle");
         FigureType.SelectedIndex = 0;
         FigureColor.Items.Add("White");
         FigureColor.Items.Add("Red");
         FigureColor.Items.Add("Orange");
         FigureColor.Items.Add("Yellow");
         FigureColor.Items.Add("Green");
         FigureColor.Items.Add("Blue");
         FigureColor.Items.Add("Indigo");
         FigureColor.Items.Add("Violet");
         FigureColor.SelectedIndex = 0;
         LineWidth.Maximum = 50;
         LineWidth.Minimum = 1;
         FigureList = new List<Figure>();
      }

      private void glControl1_Load(object sender, EventArgs e)
      {
      }

      private void glControl1_MouseDown(object sender, MouseEventArgs e)
      {
         var coordinatePoint = new Point(e.X, e.Y);
         var color = _GetColor();
         _GetNewFigure(coordinatePoint, color);
      
      }

      private void _GetNewFigure(Point coordinatePoint, Color newColor)
      {
         switch (FigureType.Text)
         {
            case "Line":
               curFigure = new TLine();
               curFigure.AddPoint(coordinatePoint);
               curFigure.AddPoint(coordinatePoint);
               break;
            case "Rectangle":
               curFigure = new TRectangle();
               curFigure.AddPoint(coordinatePoint);
               curFigure.AddPoint(coordinatePoint);
               break;
         }
         curFigure.FGColor = newColor;
      }

      private Color _GetColor()
      {
         var color = Color.White;
         switch (FigureColor.Text)
         {
            case "Red":
               color = Color.Red;
               break;
            case "Orange":
               color = Color.Orange;
               break;
            case "Yellow":
               color = Color.Yellow;
               break;
            case "Green":
               color = Color.Green;
               break;
            case "Blue":
               color = Color.Blue;
               break;
            case "Indigo":
               color = Color.Indigo;
               break;
            case "Violet":
               color = Color.Violet;
               break;
         }
         return color;
      }

      private void glControl1_MouseMove(object sender, MouseEventArgs e)
      {
         if (curFigure != null)
         {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            var newPoint = new Point(e.X, e.Y);
            curFigure.ReplacePoint(newPoint,1);
            foreach (var figure in FigureList)
            {
               figure.Show();
            }
            curFigure.Show();
            glControl1.SwapBuffers();
         }
      }

      private void glControl1_MouseUp(object sender, MouseEventArgs e)
      {
         FigureList.Add(curFigure);
         curFigure = null;
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         GL.MatrixMode(MatrixMode.Projection);
         GL.LoadIdentity();
         GL.Ortho(0, glControl1.Size.Width, glControl1.Size.Height, 0, 1, -1);
      }
   }
}
