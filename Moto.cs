using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion2
{
    internal class Moto:Terrestre,motor,ruedas,manubrio
    {
        public Moto(){
            MessageBox.Show("Se creo una motocicleta");
        }
    }
}
