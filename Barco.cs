using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion2
{
    public class Barco:Marino,motor,puertas
    {
        public Barco(){
        MessageBox.Show("Se creo un Barco");
        }
    }
}
