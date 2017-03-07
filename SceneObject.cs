using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public interface SceneObject
    {
       float intersection(Ray x);
       float norm(Vector p1);
       Point2 texture(Vector p1);
       Skin getSkin();

    }
}
