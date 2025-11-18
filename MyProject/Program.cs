using RejectMicrosoft.Sql;
using System.IO;
using System.Linq;


public class Programa
{
    static void starter_screen()
    {
        Console.WriteLine("Aviso: Escolha de ações neste programa funciona somente através de números. Qualquer outro caractere é desconsiderado.");
        Console.WriteLine("0 - Login");
        Console.WriteLine("1 - Sair");
    }
    
   static void wait_and_inspect()
    {
        bool vivo = false;
        while(vivo == false)
        {
            string fileLocation = "userData.txt";

            string user_input = Console.ReadLine();
            if (user_input == "0")
            {
                int line_index = 0;
                Console.WriteLine("Informe vosso usuário: ");
                string user = Console.ReadLine();
                Console.WriteLine("Informe vossa senha: ");
                string password = Console.ReadLine();
                Console.WriteLine("Informe seu código de usuário: ");
                string user_code = Console.ReadLine();
            
                if (user_code == "001")
                {
                    line_index = 1;
                    string line_user = File.ReadLines(fileLocation).Skip(line_index - 1).FirstOrDefault();
                    string line_password = File.ReadLines(fileLocation).Skip(line_index).FirstOrDefault();
                    if (line_user == "Obama" && line_password == "911"){Console.WriteLine("Bem vindo de volta Mr.Obama!");}
                    else {
                        Console.WriteLine("SAÍA IMEDIATAMENTE SEU IMPOSTOR!");
                        Console.WriteLine($"\n{line_user}");
                        Console.WriteLine($"\n{line_password}");
                        }
                }
                /*if (user_code == "002")
                {
                    line_index = 2;
                    string line_user = File.ReadLines(fileLocation).Skip;
                }
                if (user_code == "003"){}
                if (user_code == "004"){}
                if (user_code == "005"){}
                */
            }                 
            if (user_input == "1")
            {
                vivo = true;
            }
        }
    }
    public static void Main(string[] args)
    {
        fakeDatabaseHandler.createDatabase();
        starter_screen();
        wait_and_inspect();
    }
}