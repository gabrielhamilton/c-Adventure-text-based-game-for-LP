using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdv
{
    class Program
    {
       static void Main(string[] args)
       {
           titulo();
       }
       public static void titulo()
       {
           console.WriteLine("Text Adventure Game");
           console.WriteLine("Precione Enter para Começar.");
           console.ReadLine();
           console.Clear();
           Primeiro();
       }
       public static void Primeiro()
       {
           string escolha;
           console.WriteLine("Voce está na frente de uma casa abandonada e escuta uma voz o chamando para entrar...");
           console.WriteLine("Voce olha para a porta e vê que está aberta e uma sombra está na parte de dentro da sala");
           console.WriteLine("O que voce faz ?");
           console.WriteLine("1) Corre");
           console.WriteLine("2) Por curiosidade decide adentrar a casa, pensando que pode ser alguém que voce conhecesse");
           console.WriteLine("3) Dá um grito e pergunta quem está ai ?");
           escolha=console.ReadLine().ToLower();
           console.clear();
            switch (choice)
		    {
				case "1":
				case "Corre":
				case "Corre":
					{
						Console.WriteLine(Character.CorreCase());
						Console.WriteLine("Voce em um momento de desespero e ansiedade, dá uma corrida até o final do quarteirão");
						Console.WriteLine("Preciona Enter para continuar");
						Console.ReadLine();
						GameOver();
						break;

					}
				case "2":
				case "Entrar":
					{
						Console.WriteLine(Character.EntrarCase());
						Console.WriteLine("\"Voce dá passos inseguros até a entrada da casa, tremendo e suando, mas curioso.");
						Console.WriteLine("Preciona Enter para continuar");
						Console.ReadLine();
						Segundo();
						break;

					}
				case "3":
				case "grito":
				case "O grito":
					{
						Console.WriteLine(Character.GritoCase());
						Console.WriteLine("\"Quem está ai ? Voce gritou..");
                        Console.WriteLine("Mas nenhuma voz nem o vulto retrucou, curioso voce dá passos para entrar na casa");
						Console.WriteLine("Preciona Enter para continuar");
						Console.ReadLine();
						Segundo();
						break;

					}
				default:
					{
						Console.WriteLine("Comando Errado");
						Console.WriteLine("Preciona Enter para continuar");
						Console.ReadLine();
						Primeiro();
						break;
					}
			}
       }

    }    
}