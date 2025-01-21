using NaveEspacial;
using System.Drawing;

Nave nave;
Ventana ventana;
bool jugar = true;

void Iniciar()
{
    Ventana Ventana = new Ventana(130, 50, ConsoleColor.Black, new Point(0, 0), new Point(60, 20));

    Ventana ventana;
    nave = new Nave(new Point(26, 17), ConsoleColor.White, Ventana);
    nave.Dibujar();
}
void Game()
{
    while(jugar) 
    {
        nave.Mover(2);
    }
}
  
        
    


Iniciar();
Game();  //Llamamos al método...
Console.ReadKey();





