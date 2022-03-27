using System;
using static System.Console;

namespace DesafioRPG
{
    public class Program
    {
        static void Main (string[] Args) // metodo main é a porta de entrada do código. 
        {
            Personagem p1 = new Personagem("Arus", 42, 72, 469, "Knight"); // criação de um novo personagem com base na classe 'Personagm' da mesma pasta.

            Personagem p2 = new Personagem("Wedge", 42, 82, 292, "Ninja");

            WriteLine("Escolha seu personagem: p1 ou p2 ");
            string userInput = ReadLine();

            if (userInput == "p1")
            {               
                WriteLine(p1.Caracteristicas()); // retorna o p1 conforme o método 'Caracteristicas' escrito dentro da classe 'Personagem;
                WriteLine(p1.ToString()); // retorna o método de ataque conforme o tipo de herói do personagem;
            }
            else
            {
                WriteLine(p2.Caracteristicas());
                WriteLine(p2.ToString());
            }              
        }
    }
}
