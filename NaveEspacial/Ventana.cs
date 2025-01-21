using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NaveEspacial
{
    internal class Ventana
    {
        public int Ancho { get; set; }
        public int Altura { get; set; } 
        public Point LimiteSuperior { get; set; }
        public Point LimiteInferior { get; set; }
        public ConsoleColor Color { get; set; }

        //La public ventana de aqui abajo es el constructor
        public Ventana(int ancho,int altura,ConsoleColor color,Point limiteSuperior,Point limiteInferior)
        {
            //Esto son las propiedades
            Ancho = ancho;
            Altura = altura;
            Color = color;
            LimiteSuperior = limiteSuperior;
            LimiteInferior = limiteInferior;
            Init();
            
        }
        private void Init()
        {
            Console.SetWindowSize(Ancho,Altura);
            Console.Title = "Nave";
            Console.CursorVisible = false;
            Console.BackgroundColor = Color;
            Console.Clear();
            DibujarMarco();

        }
        public void DibujarMarco() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for(int i = LimiteSuperior.X; i <= LimiteInferior.X; i++)
            {
                Console.SetCursorPosition(i,LimiteSuperior.Y);
                Console.Write("═"); //Para escribir este caracter Alt + 205 es del código Ascii
                
            }
            for(int i = LimiteSuperior.Y; i <= LimiteInferior.Y; i++)
            {
                Console.SetCursorPosition(LimiteSuperior.X,i);
                Console.Write("║"); //Alt + 186
                Console.SetCursorPosition(LimiteInferior.X,i);
                Console.Write("║");
            }
            for (int i = LimiteSuperior.X; i < LimiteInferior.X; i++)
            {
                Console.SetCursorPosition(i, LimiteInferior.Y);
                Console.Write("═");
            }

            Console.SetCursorPosition(LimiteSuperior.X,LimiteSuperior.Y);
            Console.Write("╔"); //Alt + 201
            Console.SetCursorPosition(LimiteSuperior.X, LimiteInferior.Y);
            Console.Write("╚"); //Alt + 200
            Console.SetCursorPosition(LimiteInferior.X, LimiteSuperior.Y);
            Console.Write("╗"); //Alt + 187
            Console.SetCursorPosition(LimiteInferior.X, LimiteInferior.Y);
            Console.Write("╝"); //Alt + 188
        }
    }
             
}
