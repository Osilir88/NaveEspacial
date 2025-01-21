using NaveEspacial;
using System.Drawing;

Nave nave;
Ventana ventana;

void Iniciar()
{
    Ventana Ventana = new Ventana(130, 50, ConsoleColor.Black, new Point(0, 0), new Point(60, 20));
    
    Ventana ventana;
    nave = new Nave(new Point(26,17), ConsoleColor.White,Ventana);
    nave.Dibujar();
}

Iniciar();
Console.ReadKey();





