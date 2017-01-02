using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CloneablePoint
{
    public class Point:ICloneable
    {
        public int X { get; set; }
        public int Y { get; set;}

        public PointDescription desc = new PointDescription();

        public Point(){}
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point(int x, int y, string petName)
        {
            this.X = x;
            this.Y = y;
            desc.PetName = petName;

        }

        public override string ToString()
        {
            return String.Format("X = {0}; Y = {1}, Name = {2}, ID = {3}", 
                this.X, this.Y, desc.PetName, desc.PointID);
        }

        public object Clone()
        {
            //return new Point(this.X, this.Y);
            // return this.MemberwiseClone();

            Point newPoint = this.MemberwiseClone() as Point;
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
