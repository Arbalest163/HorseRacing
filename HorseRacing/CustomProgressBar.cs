using System;
using System.Drawing;
using System.Windows.Forms;

namespace DancingBar
{
    public partial class CustomProgressBar : UserControl
    {
        private int _refValue;
        private int _value;
        public int Value { 
            get => _value;
            set
            {
                if (value > MaxValue)
                    _value = MaxValue;
                else
                    _value = value;
            }
        }
        public Color Color { get; set; } = Color.Green;
        public int MaxValue { get; set; } = 100;
        public int RectangleSize { get; set; } = 30;
        public CustomProgressBar()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void CustomVerticalProgressVar_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;

            for (int i = 0; i <= (Value * Width / MaxValue) / RectangleSize; i++)
            {
                CreateGraphics().FillRectangle(new SolidBrush(Color), new RectangleF(x, 1, RectangleSize - 1, Width - 2));
                x += RectangleSize;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_refValue != Value)
            {
                _refValue = Value;
                Refresh();
            }
        }
    }
}
