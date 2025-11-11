string[] admin_Login = {"Obama", "911"};
string[] gestor_imediato = {"T72", "Diesel"};
string[] diretor_AreaPlaceHolder = {"Maxwell", "CodexUmbra123"};
string[] gerente_financeiro = {"Sim","Nao"};
string[] jaiminho_Aquele_Que_A_Licitacao_Recebe = {"Raúl Padilla Mendoza", "17/6/1918"};

string[,] requisoes_de_compra = {};
bool vivo = true;
void tela_inicial()
{
    Console.WriteLine("Aviso: Escolha de ações neste programa funciona somente através de números. Qualquer outro caractere é desconsiderado.");
    Console.WriteLine("Caso seja sua primeira vez aqui, digite 'h' ou 'H' para acessar o manual de uso.");
    Console.WriteLine("0 - Login");
    Console.WriteLine("1 - Sair");
}
tela_inicial();
//This while statement is so stupidly big, and that's why I love it so much.
while (vivo == true)
{
    string user_input = Console.ReadLine();
    Console.Clear();
    if (user_input == "0") {
        
        Console.WriteLine("Informe vosso Usuário: ");
        string user = Console.ReadLine();
        Console.WriteLine("Informe vossa Senha: ");
        string senha = Console.ReadLine();

        if (user == admin_Login[0]) {
            if (senha == admin_Login[1])
            {
                Console.WriteLine($"Tu logastes como {(admin_Login[0])}");
                Console.WriteLine("0 - Logout");
                Console.WriteLine("1 - Fazer RC");
                Console.WriteLine("2 - Aprovar RC");
                string user_input0 = Console.ReadLine();
                if (user_input0 == "0") { vivo = false; }
                if (user_input0 == "1")
                {

                }
                if (user_input0 == "2")
                {

                }
            }
        }
        else {
            Console.WriteLine("Alguma Credencial foi incorretamente informada;");
            break;
        }
    }
    if (user_input == "1") {vivo = false;}

}

