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
        private Rectangle button1OriginalCoordinates;
        private Rectangle button2OriginalCoordinates;
        private Rectangle button3OriginalCoordinates;
        private Rectangle button4OriginalCoordinates;
        private Rectangle button5OriginalCoordinates;
        private Rectangle button6OriginalCoordinates;
        private Rectangle button7OriginalCoordinates;
        private Rectangle button8OriginalCoordinates;
        private Rectangle button9OriginalCoordinates;
        private Rectangle button10OriginalCoordinates;
        private Rectangle button11OriginalCoordinates;
        private Rectangle button12OriginalCoordinates;
        private Rectangle button13OriginalCoordinates;
        private Rectangle button14OriginalCoordinates;
        private Rectangle button15OriginalCoordinates;
        private Rectangle button16OriginalCoordinates;
        private Rectangle button17OriginalCoordinates;
        private Rectangle button18OriginalCoordinates;
        private Rectangle button19OriginalCoordinates;
        private Rectangle button20OriginalCoordinates;
        private Rectangle button21OriginalCoordinates;

        private Size formOriginalSize;
        public Form1()
        {
            InitializeComponent();
        }
        private void Forml_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;
            button1OriginalCoordinates = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button2OriginalCoordinates = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            button3OriginalCoordinates = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            button4OriginalCoordinates = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            button5OriginalCoordinates = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            button6OriginalCoordinates = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            button7OriginalCoordinates = new Rectangle(button7.Location.X, button7.Location.Y, button7.Width, button7.Height);
            button8OriginalCoordinates = new Rectangle(button8.Location.X, button8.Location.Y, button8.Width, button8.Height);
            button9OriginalCoordinates = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);
            button10OriginalCoordinates = new Rectangle(button10.Location.X, button10.Location.Y, button10.Width, button10.Height);
            button11OriginalCoordinates = new Rectangle(button11.Location.X, button11.Location.Y, button11.Width, button11.Height);
            button12OriginalCoordinates = new Rectangle(button12.Location.X, button12.Location.Y, button12.Width, button12.Height);
            button13OriginalCoordinates = new Rectangle(button13.Location.X, button13.Location.Y, button13.Width, button13.Height);
            button14OriginalCoordinates = new Rectangle(button14.Location.X, button14.Location.Y, button14.Width, button14.Height);
            button15OriginalCoordinates = new Rectangle(button15.Location.X, button15.Location.Y, button15.Width, button15.Height);
            button16OriginalCoordinates = new Rectangle(button16.Location.X, button16.Location.Y, button16.Width, button16.Height);
            button17OriginalCoordinates = new Rectangle(button17.Location.X, button17.Location.Y, button17.Width, button17.Height);
            button18OriginalCoordinates = new Rectangle(button18.Location.X, button18.Location.Y, button18.Width, button18.Height);
            button19OriginalCoordinates = new Rectangle(button19.Location.X, button19.Location.Y, button19.Width, button19.Height);
            button20OriginalCoordinates = new Rectangle(button20.Location.X, button20.Location.Y, button20.Width, button20.Height);
            button21OriginalCoordinates = new Rectangle(button21.Location.X, button21.Location.Y, button21.Width, button21.Height);
        }




        private void resizeChildrenControls()
        {
            resizeControl(button1OriginalCoordinates, button1);
            resizeControl(button2OriginalCoordinates, button2);
            resizeControl(button3OriginalCoordinates, button3);
            resizeControl(button4OriginalCoordinates, button4);
            resizeControl(button5OriginalCoordinates, button5);
            resizeControl(button6OriginalCoordinates, button6);
            resizeControl(button7OriginalCoordinates, button7);
            resizeControl(button8OriginalCoordinates, button8);
            resizeControl(button9OriginalCoordinates, button9);
            resizeControl(button10OriginalCoordinates, button10);
            resizeControl(button11OriginalCoordinates, button11);
            resizeControl(button12OriginalCoordinates, button12);
            resizeControl(button13OriginalCoordinates, button13);
            resizeControl(button14OriginalCoordinates, button14);
            resizeControl(button15OriginalCoordinates, button15);
            resizeControl(button16OriginalCoordinates, button16);
            resizeControl(button17OriginalCoordinates, button17);
            resizeControl(button18OriginalCoordinates, button18);
            resizeControl(button19OriginalCoordinates, button19);
            resizeControl(button20OriginalCoordinates, button20);
            resizeControl(button21OriginalCoordinates, button21);
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