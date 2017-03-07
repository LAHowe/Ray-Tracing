using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RayTracing
{
    public interface Skin
    {
        Color colorAt(SceneObject o, Vector v);
    }
}
