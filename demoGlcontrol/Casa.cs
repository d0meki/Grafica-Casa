using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demoGlcontrol
{
    class Casa
    {


        private float ancho;
        private float largo;
        private float alto;
        private Vector3 pos;
        private Vector3 trasladar;
        //public float angulo = 0;
        public Casa(Vector3 posicion, float ancho, float largo, float alto) {

            this.trasladar = new Vector3(0, 0, 0);
            this.pos = posicion;
            this.ancho = ancho;
            this.largo = largo;
            this.alto = alto;
        }
        public void dibujar()
        {
            GL.LoadIdentity();

            GL.PushMatrix();
            GL.Translate(this.trasladar);
            // GL.Rotate(angulo, 0, 1, 0);
            GL.Rotate(90, 0, 1, 0);
            casa();
           // angulo++;
            GL.PopMatrix();
        }


        public void casa()
        {

            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(188 / 255.0f, 129 / 255.0f, 80 / 255.0f);
            //TECHO DE LA CASA FRONTAL
            GL.Vertex3(pos.X, pos.Y + alto, pos.Z-alto/2);
            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X+largo, pos.Y + alto, pos.Z - alto / 2);

            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y + alto, pos.Z - alto / 2);
            GL.Vertex3(pos.X+largo, pos.Y, pos.Z);
            
            //TECHO DE LA CASA TRASERA
            GL.Vertex3(pos.X, pos.Y + alto, pos.Z - alto / 2);
            GL.Vertex3(pos.X, pos.Y, pos.Z-ancho);
            GL.Vertex3(pos.X+largo, pos.Y+alto, pos.Z - alto / 2);

            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y + alto, pos.Z - alto / 2);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);
            GL.Color3(234 / 255.0f, 205 / 255.0f, 143 / 255.0f);
            
            //TECHO DE LA CASA CARA IZQUIERDA
            GL.Vertex3(pos.X, pos.Y + alto, pos.Z - alto / 2);
            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            //TECHO DE LA CASA CARA DERECHA
            GL.Vertex3(pos.X+largo, pos.Y + alto, pos.Z - alto / 2);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z-ancho);

            //PUERTA
            GL.Color3(143 / 255.0f, 105 / 255.0f, 39 / 255.0f);
            GL.Vertex3(pos.X + ancho / 3, pos.Y - alto / 2, pos.Z);
            GL.Vertex3(pos.X + ancho / 3, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + ancho / 6, pos.Y - alto / 2, pos.Z);

            GL.Vertex3(pos.X + ancho / 3, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + ancho / 6, pos.Y - alto / 2, pos.Z);
            GL.Vertex3(pos.X + ancho / 6, pos.Y - alto, pos.Z);


            //BASE DE LA CASA

            //Cara Frontal
            GL.Color3(93 / 255.0f, 109 / 255.0f, 126 / 255.0f);
            GL.Vertex3(pos.X, pos.Y, pos.Z);//0,0,0
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);//0,-5,0
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);//8,0,0

            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);//0,-5,0
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);//8,0,0
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);//,8,-5,0



            //Cara de Atras
            GL.Color3(231 / 255.0f, 76 / 255.0f, 60 / 255.0f);
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);

            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z - ancho);


            //cara izquierda
            GL.Color3(118 / 255.0f, 215 / 255.0f, 196 / 255.0f);
            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);

            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);

            //cara derecha
            GL.Color3(244 / 255.0f, 208 / 255.0f, 63 / 255.0f);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);

            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z - ancho);
            //cara superior
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);

            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);
            //cara inferior
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);

            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z - ancho);
            GL.End();

        }
    }
}
