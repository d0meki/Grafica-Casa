using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoGlcontrol
{
    class Face : IObjeto
    {
        private Vector3 trasladar;
        private Vector4 Rotar;
        private Vector3 Redimensionar;
        private Vector3 pos;
        private Vector3 col;

        private float ancho;
        private float largo;
        private float alto;
        public Face(Vector3 posicion, float ancho, float largo, float alto, Vector3 color )
        {
            this.trasladar = new Vector3(0, 0, 0);
            this.Rotar = new Vector4(0, 0, 0, 0);
            this.Redimensionar = new Vector3(1, 1, 1);
            this.pos = posicion;
            this.ancho = ancho;
            this.largo = largo;
            this.alto = alto;
            this.col = color;
                 

        }
        public void dibujar()
        {
            GL.LoadIdentity();

            GL.PushMatrix();
            GL.Translate(this.trasladar);
            GL.Rotate(this.Rotar.W, new Vector3(this.Rotar.X, this.Rotar.Y, this.Rotar.Z));
            GL.Scale(this.Redimensionar);

            vertices();

            GL.PopMatrix();
        }

        public void vertices()
        {
            GL.Begin(PrimitiveType.Triangles);
            //GL.Color3(188 / 255.0f, 129 / 255.0f, 80 / 255.0f)
            GL.Color3(col.X, col.Y, col.Z);
            //Cara Frontal
            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z);
            //Cara de Atras
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);

            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X + largo, pos.Y - alto, pos.Z - ancho);
            //cara izquierda
            GL.Vertex3(pos.X, pos.Y, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);

            GL.Vertex3(pos.X, pos.Y, pos.Z - ancho);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z);
            GL.Vertex3(pos.X, pos.Y - alto, pos.Z - ancho);
            //cara derecha
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




        public void mover(Vector3 direccion)
        {
            throw new NotImplementedException();
        }

        public void redimencionar(Vector3 escala)
        {
            throw new NotImplementedException();
        }

        public void rotar(Vector4 rotaciones)
        {
            throw new NotImplementedException();
        }
    }
}
