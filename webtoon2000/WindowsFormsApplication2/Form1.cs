using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Rectangle originalFormRect;
        private Rectangle Button1OriginalCoordinates;
        private Rectangle Button2OriginalCoordinates;
        private Rectangle Button3OriginalCoordinates;
        private Rectangle Button4OriginalCoordinates;
        private Rectangle Button5OriginalCoordinates;
        private Rectangle Button6OriginalCoordinates;
        private Rectangle Button7OriginalCoordinates;
        private Rectangle Button8OriginalCoordinates;
        private Rectangle Button9OriginalCoordinates;
        private Rectangle Button10OriginalCoordinates;
        private Rectangle Button11OriginalCoordinates;
        private Rectangle Button12OriginalCoordinates;
        private Rectangle Button13OriginalCoordinates;
        private Rectangle Button14OriginalCoordinates;
        private Rectangle Button15OriginalCoordinates;
        private Rectangle Button16OriginalCoordinates;
        private Rectangle Button17OriginalCoordinates;
        private Rectangle Button18OriginalCoordinates;
        private Rectangle Button19OriginalCoordinates;
        private Rectangle Button20OriginalCoordinates;
        private Rectangle Button21OriginalCoordinates;
        private float Button1OriginalFontSize;
        private float Button2OriginalFontSize;
        private float Button3OriginalFontSize;
        private float Button4OriginalFontSize;
        private float Button5OriginalFontSize;
        private float Button6OriginalFontSize;
        private float Button7OriginalFontSize;
        private float Button8OriginalFontSize;
        private float Button9OriginalFontSize;
        private float Button10OriginalFontSize;
        private float Button11OriginalFontSize;
        private float Button12OriginalFontSize;
        private float Button13OriginalFontSize;
        private float Button14OriginalFontSize;
        private float Button15OriginalFontSize;
        private float Button16OriginalFontSize;
        private float Button17OriginalFontSize;
        private float Button18OriginalFontSize;
        private float Button19OriginalFontSize;
        private float Button20OriginalFontSize;
        private float Button21OriginalFontSize;
        private float fontScale = 1.3f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormRect = new Rectangle(this.Location, this.Size);
            Button1OriginalCoordinates = new Rectangle(button1.Location, button1.Size);
            Button2OriginalCoordinates = new Rectangle(button2.Location, button2.Size);
            Button3OriginalCoordinates = new Rectangle(button3.Location, button3.Size);
            Button4OriginalCoordinates = new Rectangle(button4.Location, button4.Size);
            Button5OriginalCoordinates = new Rectangle(button5.Location, button5.Size);
            Button6OriginalCoordinates = new Rectangle(button6.Location, button6.Size);
            Button7OriginalCoordinates = new Rectangle(button7.Location, button7.Size);
            Button8OriginalCoordinates = new Rectangle(button8.Location, button8.Size);
            Button9OriginalCoordinates = new Rectangle(button9.Location, button9.Size);
            Button10OriginalCoordinates = new Rectangle(button10.Location, button10.Size);
            Button11OriginalCoordinates = new Rectangle(button11.Location, button11.Size);
            Button12OriginalCoordinates = new Rectangle(button12.Location, button12.Size);
            Button13OriginalCoordinates = new Rectangle(button13.Location, button13.Size);
            Button14OriginalCoordinates = new Rectangle(button14.Location, button14.Size);
            Button15OriginalCoordinates = new Rectangle(button15.Location, button15.Size);
            Button16OriginalCoordinates = new Rectangle(button16.Location, button16.Size);
            Button17OriginalCoordinates = new Rectangle(button17.Location, button17.Size);
            Button18OriginalCoordinates = new Rectangle(button18.Location, button18.Size);
            Button19OriginalCoordinates = new Rectangle(button19.Location, button19.Size);
            Button20OriginalCoordinates = new Rectangle(button20.Location, button20.Size);
            Button21OriginalCoordinates = new Rectangle(button21.Location, button21.Size);
            Button1OriginalFontSize = button1.Font.Size;
            Button2OriginalFontSize = button2.Font.Size;
            Button3OriginalFontSize = button3.Font.Size;
            Button4OriginalFontSize = button4.Font.Size;
            Button5OriginalFontSize = button5.Font.Size;
            Button6OriginalFontSize = button6.Font.Size;
            Button7OriginalFontSize = button7.Font.Size;
            Button8OriginalFontSize = button8.Font.Size;
            Button9OriginalFontSize = button9.Font.Size;
            Button10OriginalFontSize = button10.Font.Size;
            Button11OriginalFontSize = button11.Font.Size;
            Button12OriginalFontSize = button12.Font.Size;
            Button13OriginalFontSize = button13.Font.Size;
            Button14OriginalFontSize = button14.Font.Size;
            Button15OriginalFontSize = button15.Font.Size;
            Button16OriginalFontSize = button16.Font.Size;
            Button17OriginalFontSize = button17.Font.Size;
            Button18OriginalFontSize = button18.Font.Size;
            Button19OriginalFontSize = button19.Font.Size;
            Button20OriginalFontSize = button20.Font.Size;
            Button21OriginalFontSize = button21.Font.Size;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeChildrenControls();
        }
        private void ResizeChildrenControls()
    {
        ResizeControl(button1, Button1OriginalCoordinates, Button1OriginalFontSize);
        ResizeControl(button2, Button2OriginalCoordinates, Button2OriginalFontSize);
        ResizeControl(button3, Button3OriginalCoordinates, Button3OriginalFontSize);
        ResizeControl(button4, Button4OriginalCoordinates, Button4OriginalFontSize);
        ResizeControl(button5, Button5OriginalCoordinates, Button5OriginalFontSize);
        ResizeControl(button6, Button6OriginalCoordinates, Button6OriginalFontSize);
        ResizeControl(button7, Button7OriginalCoordinates, Button7OriginalFontSize);
        ResizeControl(button8, Button8OriginalCoordinates, Button8OriginalFontSize);
        ResizeControl(button9, Button9OriginalCoordinates, Button9OriginalFontSize);
        ResizeControl(button10, Button10OriginalCoordinates, Button10OriginalFontSize);
        ResizeControl(button11, Button11OriginalCoordinates, Button11OriginalFontSize);
        ResizeControl(button12, Button12OriginalCoordinates, Button12OriginalFontSize);
        ResizeControl(button13, Button13OriginalCoordinates, Button13OriginalFontSize);
        ResizeControl(button14, Button14OriginalCoordinates, Button14OriginalFontSize);
        ResizeControl(button15, Button15OriginalCoordinates, Button15OriginalFontSize);
        ResizeControl(button16, Button16OriginalCoordinates, Button16OriginalFontSize);
        ResizeControl(button17, Button17OriginalCoordinates, Button17OriginalFontSize);
        ResizeControl(button18, Button18OriginalCoordinates, Button18OriginalFontSize);
        ResizeControl(button19, Button19OriginalCoordinates, Button19OriginalFontSize);
        ResizeControl(button20, Button20OriginalCoordinates, Button20OriginalFontSize);
        ResizeControl(button21, Button21OriginalCoordinates, Button21OriginalFontSize);
    }
    private void ResizeControl (Control control, Rectangle originalControlRect, float originalFontSize)
{
    float xRatio = (float) this.ClientRectangle.Width / (float) originalFormRect.Width;
    float yRatio = (float) this.ClientRectangle.Height / (float) originalFormRect.Height;
    float newX = originalControlRect.Location.X * xRatio;
    float newY = originalControlRect.Location.Y * yRatio;
    control.Location = new Point((int) newX,(int)newY);
    control.Width = (int)(originalControlRect.Width * xRatio);
    control.Height = (int) (originalControlRect.Height * yRatio);
    float ratio = xRatio;
    if (xRatio >= yRatio)
    {
        xRatio = yRatio;
    }
    float newFontSize = originalFontSize * ratio * fontScale;
    Font newFont = new Font(control.Font.FontFamily, newFontSize);
    control.Font = newFont;
}
    }
}