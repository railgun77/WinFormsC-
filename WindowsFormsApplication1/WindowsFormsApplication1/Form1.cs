using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Rectangle button10riginalRect;
        private Rectangle button20riginalRect;
        private Rectangle button30riginalRect;
        private Rectangle button4OriginalRect;

        private Size formOriginalSize;
        public Form1()
        {
            InitializeComponent();
        }
        private void Forml_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;
            button10riginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button20riginalRect = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            button30riginalRect = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            button4OriginalRect = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
        }




        private void resizeChildrenControls()
        {
            resizeControl(button10riginalRect, button1);
            resizeControl(button20riginalRect, button2);
            resizeControl(button30riginalRect, button3);
            resizeControl(button4OriginalRect, button4);
        }

        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newwidth = (int)(originalControlRect.Width * xRatio);
            int newheight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newwidth, newheight);
        }

        private void Forml_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
    }
}