using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
namespace demoGlcontrol
{
    class Escenario
    {
        Dictionary<string, Objeto> listaObjetos;
        public Escenario()
        {
            this.listaObjetos = new Dictionary<string, Objeto>();
        }
        public void agregarObjeto(string nombre, Objeto dibujo)
        {
            this.listaObjetos.Add(nombre, dibujo);
        }
        public void mover(Vector3 direccion)
        {

            foreach (Objeto dibujos in listaObjetos.Values)
            {
                dibujos.mover(direccion);
            }

        }
        public Objeto getObjeto(string key)
        {
            if (listaObjetos.ContainsKey(key))
            {
                return listaObjetos[key];
            }
            else
            {
                return listaObjetos["casa"];
            }

        }
        public void dibujarEscenario()
        {
            foreach (Objeto dibujos in listaObjetos.Values)
            {
                dibujos.dibujar();
            }
        }
    }
}
