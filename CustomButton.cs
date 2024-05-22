using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public class CustomButton :Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 50;
        private Color borderColor = Color.DodgerBlue;

        //Properties
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); } 
        }
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }
        public Color BackgroundColor
        {
            get => BackColor; set { BackColor = value; }
        }
        public Color TextColor
        {
            get => ForeColor; set { ForeColor = value; }
        }
    }
}
