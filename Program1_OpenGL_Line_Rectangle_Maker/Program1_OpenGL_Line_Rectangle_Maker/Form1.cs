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

namespace Program1_OpenGL_Line_Rectangle_Maker
{
   public partial class Form1 : Form
   {
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
      }
      
   }
}
