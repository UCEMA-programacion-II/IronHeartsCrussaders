using System;
using System.Collections.Generic;
using System.Text;

namespace CicloJuego
{
    public class Juego
    {

        public void jugar() {

            CargarRecurso.ejecutar();
            bool salir = false;
            do {
                Dibujar.ejecutar();
                Actualizar.ejecutar(); }
            while (salir!);
            DescargarRecurso.ejecutar();
            Salir.ejecutar();



        }
    }
}
