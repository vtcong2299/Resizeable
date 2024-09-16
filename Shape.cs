using System;

namespace BaiTapResizeable
{
    public class Shape
    {
        private string color="green";
        private bool filled = true;
        private string GetColor()
        {
            return color;
        }
        private void SetColor(string color)
        {   
            this.color = color;
        }
        private bool GetFilled()
        {
            return filled;
        }
        private void SetFilled(bool filled)
        {   
            this.filled = filled;
        }
        public Shape(){}
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public override string ToString()
        {
            return "A Shape with color of " +GetColor()+ " and " + (GetFilled()? "filled ":"not filled");
        }
    }
}