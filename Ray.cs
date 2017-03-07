using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Ray
    {

        
        public Vector origin;
        public Vector direction;
        public float center, radius;
        
        public Ray(Vector origin, Vector direction)
        {
            this.origin = origin;
            this.direction = direction;

        }

        public Vector travel(float time)
        {
            return  Vector.add(origin, Vector.mult(direction,time));
        
        }
    }
}
