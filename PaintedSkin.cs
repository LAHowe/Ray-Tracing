using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class PaintedSkin : Skin
    {

      /*  In PaintedSkin, define the ColorAt method to:

    Compute the surface normal from the scene object
    Compute the surface color by passing the texture point to the underlying texture
    Compute the illumination by adding up the light from each light source.
    Multiply the total illumination by the surface color and return it.*/

        public Color colorAt(SceneObject o, Vector v)
        {
            return Color.Black ;
        }

        public Point2 texture(Vector v)
        {
            return new Point2();
        }
    }
}
