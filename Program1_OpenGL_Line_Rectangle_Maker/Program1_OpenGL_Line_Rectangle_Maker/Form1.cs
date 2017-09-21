// this form will allow you to draw mutliple rectangles and lines
// Author: seelyv

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
      
      /// <summary>
      /// instatiates all the components fields to have usefu infromation in
      /// them prepopulated
      /// </summary>
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

      /// <summary>
      /// Starts the banding on mouse down
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"> holds the coordinates of the mouse click event </param>
      private void glControl1_MouseDown(object sender, MouseEventArgs e)
      {
         var coordinatePoint = new Point(e.X, e.Y);
         var color = _GetColor();
         _GetNewFigure(coordinatePoint, color);
      
      }

      /// <summary>
      /// sets curFigure to the appropriate figure type and sets the color and linewidth
      /// </summary>
      /// <param name="coordinatePoint">X,Y coordinates of the first point in the figure</param>
      /// <param name="newColor">the desired color for the new figure</param>
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
         curFigure.LineWidth = (float) LineWidth.Value;
      }

      /// <summary>
      /// Gets the color that has been selected by the FigureColor combo box
      /// </summary>
      /// <returns>Color object of a predefined color</returns>
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

      /// <summary>
      /// on mouse move it redraws the frame and then also updates the second point in the curFigure
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e">holds new mouse X,Y coordinates</param>
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

      /// <summary>
      /// On mouse up event adds the current figure to the list and sets curFigure to null
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void glControl1_MouseUp(object sender, MouseEventArgs e)
      {
         FigureList.Add(curFigure);
         curFigure = null;
      }

      /// <summary>
      /// On form load this sets up the OpenGL enviroment for use
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void Form1_Load(object sender, EventArgs e)
      {
         GL.MatrixMode(MatrixMode.Projection);
         GL.LoadIdentity();
         GL.Ortho(0, glControl1.Size.Width, glControl1.Size.Height, 0, 1, -1);
      }

      /// <summary>
      /// when the form is shown it draws a empty screen on the form where the OpenGL object sits
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void Form1_Shown(object sender, EventArgs e)
      {
         GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
         glControl1.SwapBuffers();
      }
   }
}
