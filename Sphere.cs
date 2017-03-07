using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Sphere : SceneObject
    {
        //public float a, b, c;
        public float  radius;
        public Vector center;

        public float norm(Vector p1)
        {
            return (float)5.0;
        }

        public Skin getSkin()
        {
            return null;
        }

        public Sphere(float radius, Vector center)//float a, float b, float c, 
        {
            /*this.a = a;
            this.b = b;
            this.c = c;*/
            this.radius = radius;
            this.center = center;
           

        }
        public Point2 texture(Vector v1)
        {

            return new Point2();
        }
        public float intersection(Ray x)
        {
            float a = Vector.sqr(x.direction);
           float b = 2*(Vector.dotProduct(Vector.sub(x.origin,center), x.direction));
           float c = Vector.sqr(Vector.sub(x.origin, center))-(radius*radius);
           float d = (b * b) - (4 * c);

            if (d<0)
            {
                return -1;
            }

            float sd = (float)Math.Sqrt(d);
            float solution = (-b-sd)/2;
            float solution1 = (-b+sd) / 2;

            if(solution>0)
            {
                return solution;
            }

            else if (solution1 > 0)
            {
                return solution1;
            }

            return -1;  
        }

        public Vector normal(Vector p)
        {
            return Vector.div(Vector.sub(p, center), radius);
        }

         
    }
}
