using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.LocalFunc
{
    public class LocalFunctionExample
    {
        public double ObjectVolumn { get; set; }
        public string ObjectType { get; set; }

        public LocalFunctionExample(object shapeObject) {
            double GetObjectVolumn(object shape) {
                switch (shape) {
                    case Cube square:
                        return Math.Pow(square.Edge, 3.00);
                    case Pyramid triangle: 
                        return (triangle.BaseLength * triangle.BaseWidth * triangle.Height) / 3;
                    case Sphere sphere:
                        return 4 * Math.PI * Math.Pow(sphere.Radius, 3) / 3;
                    case null:
                        return 0.0;
                }
                return 0.0;
            }

            ObjectVolumn = GetObjectVolumn(shapeObject);
            ObjectType = ObjectVolumn == 0.0 ? "Invalid Object Shape": shapeObject.GetType().Name;
        }
    }
}
