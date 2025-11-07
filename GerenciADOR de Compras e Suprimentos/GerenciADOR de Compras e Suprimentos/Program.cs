//Second Time I'm Trying to do a somewhat funcional program
//Let's try to make it simple this time
int opcao = 1;
bool Selecao = false;
string corSelecionado = "\u001b[32m";
Guid obama = Guid.NewGuid();
string[] coordenador = { "Obama", "9/11" };
bool logged = false;
void menu_Opcoes()
{
    Console.WriteLine($"{(opcao == 1 ? corSelecionado : "")}Login\u001b[0m");
    Console.WriteLine($"{(opcao == 2 ? corSelecionado : "")}Sair\u001b[0m");
}
void checar()
{
    if(opcao == 1)
    {
        bool user = false;
        bool password = false;
        Console.Clear();
        Console.WriteLine($"{corSelecionado}Insira seu usuário: \u001b[0m");
        string usuario_Inserido = Console.ReadLine();
        Console.WriteLine($"{corSelecionado}Insira sua Senha: \u001b[0m");
        string senha_Inserida = Console.ReadLine();
        if (usuario_Inserido == coordenador[0]) { user = true; }
        if (senha_Inserida == coordenador[1]) { password = true; }
        if (user == true && password == true) { 
            logged = true;
            Console.Clear();
            Console.WriteLine($"Você está Logado como {(coordenador[0])}!");
        }
        else { 
            Console.Clear();
            Console.WriteLine("Usuário ou senha incorretos.");
        }
    }
    if(opcao == 2) { Selecao = true;}
}
void acoes_Logado()
{
    
    bool Seleci = false;
    if (logged == true)
    {
        Console.WriteLine($"{(opcao == 1 ? corSelecionado : "")}Fazer Requisição de Compra\u001b[0m");
        Console.WriteLine($"{(opcao == 2 ? corSelecionado : "")}Logout\u001b[0m");
    }
    else { return; }
    while (Seleci == false)
    {
        var key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.DownArrow:
                opcao = (opcao == 2 ? 1 : opcao + 1);
                break;
            case ConsoleKey.UpArrow:
                opcao = (opcao == 1 ? 2 : opcao - 1);
                break;
            case ConsoleKey.Enter:
                Seleci = true;
                break;
        }
    }
}
while (Selecao == false)
{
    menu_Opcoes();
    var key = Console.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.DownArrow:
            Console.Clear();
            opcao = (opcao == 2 ? 1 : opcao + 1);
            break;
        case ConsoleKey.UpArrow:
            Console.Clear();
            opcao = (opcao == 1 ? 2 : opcao - 1);
            break;
        case ConsoleKey.Enter:
            checar();
            acoes_Logado();
            break;
    }
}

