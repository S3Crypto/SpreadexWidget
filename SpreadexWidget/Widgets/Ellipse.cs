using System;
namespace SpreadexWidget.Widgets
{
    public class Ellipse : IWidget
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int DiameterH { get; private set; }
        public int DiameterV { get; private set; }

        public Ellipse(int x, int y, int diameterH, int diameterV)
        {
            if (diameterH <= 0 || diameterV <= 0)
            {
                throw new ArgumentException("Diameters must be positive.");
            }

            X = x;
            Y = y;
            DiameterH = diameterH;
            DiameterV = diameterV;
        }

        public string Draw()
        {
            return $"Ellipse ({X},{Y}) diameterH = {DiameterH} diameterV = {DiameterV}";
        }
    }

}

