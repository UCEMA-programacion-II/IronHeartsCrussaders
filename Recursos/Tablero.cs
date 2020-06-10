using System;
using System.Collections.Generic;
using System.Text;

namespace Recursos
{
    public class Tablero
    {
        public Tablero() {

            this.tanque = new Tanque();
            this.bala = new Bala();
            this.campo = new Campo();


        }

        public int ancho { get; set; }
        public int alto { get; set; }

        public Bala bala { get; set; }
        public Tanque tanque { get; set; }
        public Campo campo { get; set; }
        public bool salir { get; set; } 
        public bool hayColision() {
            return campo.Colision(this.tanque); 
        }


    }
}
