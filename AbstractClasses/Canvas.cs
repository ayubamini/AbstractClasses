using System;
using System.Collections.Generic;

namespace AbstractClasses
{
    public class Canvas : ICanvas
    {
        public void DrawCanvas(IList<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape {0} ready to draw", shape);
                shape.Select();
                shape.Draw();
            }
        }
    }
}
