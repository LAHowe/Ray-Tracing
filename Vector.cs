using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Vector
    {
        public float x, y, z;
              
        public Vector(float x, float y, float z){

        this.x = x;
        this.y = y;
        this.z = z;
         
       
    }

        public static Vector add(Vector p1, Vector p2)
        {
            return new Vector(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);

        }

        public static float sqr(Vector p1)
        {
            return (p1.x * p1.x+ p1.y * p1.y+ p1.z * p1.z);
        }
        public static Vector sub(Vector p1, Vector p2)
        {
            return new Vector(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);

        }

        public static Vector mult(Vector p1, float v)
        {
            return new Vector(p1.x * v, p1.y * v, p1.z * v);

        }

        public static  Vector div(Vector p1, float k)
        {
            return new Vector(p1.x / k, p1.y /k, p1.z /k);
        }

        public static Vector normalize(Vector v)
        {
           
            return div(v, norm(v));

        }

        public static float dotProduct(Vector p1, Vector p2){

            return p1.x * p2.x + p1.y * p2.y + p1.z * p2.z;


        }

        public static float crossProduct(Vector p1, Vector p2)
        {
            return(p1.x * p2.y) + (p1.x * p2.z) + (p1.y * p2.z) + (p1.z * p2.y) + (p1.z * p2.x);
        }


      
        public static float norm(Vector p1)
        {
          return (float) (Math.Sqrt((p1.x * p1.x) + (p1.y * p1.y) + (p1.z * p1.z)));
        }

        
    }
}
