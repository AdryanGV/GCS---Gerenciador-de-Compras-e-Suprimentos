//Essential Stuff Here
using System.Security.Cryptography.X509Certificates;
ConsoleKeyInfo Key;
int opcao = 1;
bool Selecionado = false;
string corSelecionado = "\u001b[32m";
//
//FunctionsVille - Km-0
void construirPC_Superior()
{
    Console.Write(@"
                     ________________________________________________
                    /                                                \
                   |    _________________________________________     |
                   |   |                                         |    |
        ");
}
void construirPC_Inferior()
{
    Console.Write(@"
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |                                         |    |
                   |   |_________________________________________|    |
                   |                                                  |
                    \_________________________________________________/
                           \___________________________________/
                        ___________________________________________
                     _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_
                  _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_
               _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_
            _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_
         _-'.-.-.-.-.-. .---.-. .-------------------------. .-.---. .---.-.-.-.`-_
        :-------------------------------------------------------------------------:
        `---._.-------------------------------------------------------------._.---'
            
        ");
    //Pensamentos para mim mesmo: São 11 da noite, porquê que eu me coloquei nessa situação só por um computador em ASCII?
}
void processar_Opcoes_Menu()
{ 
    if(opcao == 1)
    {

        Console.WriteLine(@"
            Made by: Adryan, Maria, Felipe
            Made in Brazil
            Year Released: 2025
            Version v01
            License: GPLv3
        ");
    }
    if (opcao == 6) { Selecionado = true; }
}
void Menu() 
{
    Console.Write("           |   |                                         |    |");
    Console.WriteLine("");
    Console.WriteLine($"{(opcao == 1 ? corSelecionado : "")}                   |   |I - ROM\u001b[0m                                  |    |");
    Console.WriteLine($"{(opcao == 2 ? corSelecionado : "")}                   |   |II - Login                               |    |\u001b[0m");
    Console.WriteLine($"{(opcao == 3 ? corSelecionado : "")}                   |   |III - Fazer Requisição de Compra\u001b[0m         |    |");
    Console.WriteLine($"{(opcao == 4 ? corSelecionado : "")}                   |   |IV -Consultar Requisição de Compra\u001b[0m       |    |");
    Console.WriteLine($"{(opcao == 5 ? corSelecionado : "")}                   |   |V - Aprovar Requisição de Compra\u001b[0m         |    |");
    Console.WriteLine($"{(opcao == 6 ? corSelecionado : "")}                   |   |6 - Sair\u001b[0m                                 |    |");
    Console.Write("                   |   |                                         |    |");
}


while (!Selecionado)
{
    construirPC_Superior();
    Menu();
    construirPC_Inferior();
    Key = Console.ReadKey();
    switch (Key.Key)
    {
        case ConsoleKey.DownArrow:
            Console.Clear();
            opcao = (opcao == 6 ? 1 : opcao + 1);
            break;
        case ConsoleKey.UpArrow:
            Console.Clear();
            opcao = (opcao == 1 ? 6 : opcao - 1);
            break;
        case ConsoleKey.Enter:
            Console.Clear();
            processar_Opcoes_Menu();
            break;
    }
}