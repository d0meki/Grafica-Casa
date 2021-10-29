using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoGlcontrol 
{
    class Objeto : IObjeto
    {
        Dictionary<string, Face> ListaDeFaces;
        public Objeto()
        {
            ListaDeFaces = new Dictionary<string, Face>();
        }
        public Dictionary<string, Face> listaDeFaces()
        {
            return ListaDeFaces;

        }
        public void dibujar()
        {
            foreach (Face faces in ListaDeFaces.Values)
            {
                faces.dibujar();
            }
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
