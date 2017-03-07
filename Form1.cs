using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTracing
{
    public partial class Form1 : Form
    {

        public static int SIZEy = 100;
        public static int SIZEx = 100;
        public float [,] pixel = new float [SIZEx, SIZEy];
        public float direction = 0;
        public Vector center;
        public float a, b, c;
        public float radius;
        public Ray ray1;
        public Color[,] image = new Color[100,100];
        public Vector p;
        public Vector camera = new Vector (0, -5, 0);
        public float t;
        public Vector light = Vector.normalize(new Vector(1, -1, 1));
        public SceneObject[] SO = new SceneObject[2];
        public LightSource[] LS = new LightSource[2];



        public Form1()
        {
                     
            InitializeComponent();
            Sphere s = new Sphere(1, new Vector(0, 0, 0));
            Ray r = new Ray(new Vector(0, 0, 0), Vector.normalize(new Vector(1, 1, 0)));
            Console.WriteLine(s.intersection(r));



            for (float i = 0; i < 100; i++)
            {
                for(float j = 0; j < 100; j++){
                    p = new Vector(i / 100 * 2 - 1, 0, j / 100*2-1);
                    ray1 = new Ray(camera, Vector.normalize(Vector.sub(p, camera)));
                    t = s.intersection(ray1);
                    if(t==-1)
                    {
                        image[(int)i, (int)j] = Color.Black; 
                    }

                    else
                    {
                        Vector sp = ray1.travel(t);
                        Vector sn = s.normal(sp);
                        float intensity = Math.Max(0, Vector.dotProduct(sn,light));
                        image[(int)i, (int)j] = Color.FromArgb((int)((intensity*0.8+0.2)*255), 0, 0); 
                        
                    }


                }

            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for(int i=0; i<100; i++)
            {for(int j =0; j<100;j++)
                {
                    g.FillRectangle(new SolidBrush(image[i,j]),i,j,1,1);
                }
        }
        }

       
    }
}
