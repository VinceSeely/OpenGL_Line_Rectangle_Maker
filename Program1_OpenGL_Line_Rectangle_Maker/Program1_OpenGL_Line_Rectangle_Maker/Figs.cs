//Figs holds information about how figures will be drawn and what the data type looks like
//Author: tianb

using System.Collections.Generic;   // Use List Generic
using System.Drawing;               // Use Color and Point

using OpenTK.Graphics.OpenGL;       // Use the OpenGl control

namespace Figures
{
   public abstract class Figure
   {
      protected List<Point> pts = new List<Point>();   // List of points in the figure
      protected Color fgColor = Color.White;           // Color to draw figure in
      protected float lineWidth = 1.0F;                // Width of line segments

      public abstract void Show();

      public Color FGColor   
      {
         get { return fgColor; }
         set { fgColor = value; }
      }

      public float LineWidth
      {
         get { return lineWidth; }
         set { lineWidth = value; }
      }

      public void AddPoint ( Point p ) { pts.Add(p); }

      public void ReplacePoint ( Point p, int index ) { pts[index] = p; }
   }

   public class TLine : Figure
   {
      /// <summary>
      ///  Show figure
      /// </summary>
      public override void Show() 
      {
         GL.Color3(fgColor.R, fgColor.G, fgColor.B);
         GL.LineWidth(lineWidth);
         GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(pts[0].X, pts[0].Y);
            GL.Vertex2(pts[1].X, pts[1].Y);
         GL.End();
      }
   }

   public class TRectangle : Figure
   {
      /// <summary>
      /// Show figure
      /// </summary>
      public override void Show()
      {
         GL.Color3(fgColor);
         GL.LineWidth(lineWidth);

         GL.Begin(PrimitiveType.LineLoop);
            GL.Vertex2(pts[0].X, pts[0].Y);
            GL.Vertex2(pts[1].X, pts[0].Y);
            GL.Vertex2(pts[1].X, pts[1].Y);
            GL.Vertex2(pts[0].X, pts[1].Y);
         GL.End();
      }
   }

}  // Name space Figures