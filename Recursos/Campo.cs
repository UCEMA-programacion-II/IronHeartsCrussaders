using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Recursos
{
    public class Campo
    {

        public Campo() {
            this.ancho = 50;
            this.alto = 50;
        }
        public List<Punto> elementos { get; set; }

        public int ancho{ get; set; }
        public int alto { get; set; }

        public void Dibujar() { }

        public void DibujarTiro(string orientacion, Tanque tanque) {
            
            if (orientacion == "X"){

                for (int x = tanque.X; x == this.ancho; x++)

                    Console.SetCursorPosition(x, tanque.Y);
                Console.WriteLine("*");
               
                Console.WriteLine("*");



            }
        
        }
        private void Inicializar() { }

        public bool Colision(Tanque tanque) {
            foreach (Punto p in elementos) {
                if (tanque.X == p.X && tanque.Y == p.y && p.Elemento == 1) {

                    return true;
                }
                
            }

            return false;
        }

        

    }
}
