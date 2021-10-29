using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
namespace demoGlcontrol
{
    interface IObjeto
    {
        void dibujar();
        void rotar(Vector4 rotaciones);
        void mover(Vector3 direccion);
        void redimencionar(Vector3 escala);
    }
}
