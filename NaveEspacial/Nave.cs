using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NaveEspacial
{
    internal class Nave
    {
        public float Vida { get; set; }
        public Point Posicion { get; set; }
        public ConsoleColor Color { get; set; } 
        public Ventana VentanaC { get; set; }

        //Creamos el constructor
        public Nave(Point posicion, ConsoleColor color, Ventana ventana)
        {
            Posicion = posicion;           //asignamos estas variables a nuestras propiedades
            Color = color;  
            VentanaC = ventana;
            Vida = 100;
        }
        public void Dibujar()
        {
            Console.ForegroundColor = Color;
            int x = Posicion.X; //esto son variables
            int y = Posicion.Y;

            Console.SetCursorPosition(x + 3, y);
            Console.Write("A");
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write("<{x}>");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("± W W ±");  //Los caracteres es alt + 241
        }
    }
}
