using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demoGlcontrol
{
    class Casa: Objeto
    {
        public Casa(Vector3 posicion, float ancho, float alto, float largo) {
            float lar;
            if (ancho > largo)
            {
                lar = ancho;
            }
            else
            {
                lar = largo;
            }
            this.listaDeFaces().Add("techo", new Face(posicion, ancho, largo, alto * 0.1f, new Vector3(234 / 255.0f, 205 / 255.0f, 143 / 255.0f)));
            this.listaDeFaces().Add("techo1", new Face(new Vector3(posicion.X+largo*0.15f, posicion.Y + alto * 0.1f, posicion.Z), ancho,largo * 0.7f, alto * 0.1f, new Vector3(234 / 255.0f, 205 / 255.0f, 143 / 255.0f)));
            this.listaDeFaces().Add("techo2", new Face(new Vector3(posicion.X + largo * 0.3f, posicion.Y + alto * 0.2f, posicion.Z), ancho, largo * 0.4f, alto * 0.1f, new Vector3(234 / 255.0f, 205 / 255.0f, 143 / 255.0f)));
            this.listaDeFaces().Add("techo3", new Face(new Vector3(posicion.X + largo * 0.4f, posicion.Y + alto * 0.3f, posicion.Z), ancho, largo * 0.2f, alto * 0.1f, new Vector3(234 / 255.0f, 205 / 255.0f, 143 / 255.0f)));
            this.listaDeFaces().Add("base",new Face(new Vector3(posicion.X + largo * 0.1f, posicion.Y - alto *0.1f, posicion.Z - ancho * 10 / 100),ancho,largo*0.8f,alto, new Vector3(188 / 255.0f, 129 / 255.0f, 80 / 255.0f)));
            this.listaDeFaces().Add("puerta",new Face(new Vector3(posicion.X + largo * 0.2f, posicion.Y - alto * 0.5f, posicion.Z - ancho * 0.1f), ancho*0.5f, largo * 0.15f, alto*0.6f, new Vector3(1, 0, 0)));
            this.listaDeFaces().Add("ventana", new Face(new Vector3(posicion.X + largo * 0.6f, posicion.Y - alto * 0.4f, posicion.Z - ancho * 0.1f), ancho * 0.5f, largo * 0.15f, alto * 0.3f, new Vector3(0, 1, 0)));
        }

    }
}
