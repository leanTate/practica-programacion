using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion2
{
    public class Auto:Terrestre,ruedas,motor,puertas
    {
        public Auto() {
            MessageBox.Show("Se creo un auto");
        }
    }
}
