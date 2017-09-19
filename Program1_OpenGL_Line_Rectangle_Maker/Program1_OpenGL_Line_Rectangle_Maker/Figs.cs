// Put a comment block here!
// You should put a comment block on top of each class also.
// Look for ??? places to finish the code.
// Remove all my editorial comments from this file!

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

      public Color FGColor   // C# properties are neat!
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

   // Note that the use of the "T" for 
   // type names is to avoid conflicts with 
   // System.Drawing objects with the same names.
   // That way the "user" can also say:  using Figures;

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