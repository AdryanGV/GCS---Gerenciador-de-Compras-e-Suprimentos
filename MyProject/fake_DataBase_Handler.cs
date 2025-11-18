using System.IO;

//Makeshift Database - Users and Passwords Section 
//Order of the plain text data, line by line: User; Password; UserCode;
//The UserCode tells this abomination of a dataBase who you are actually trying to login as
namespace RejectMicrosoft.Sql{
    public class fakeDatabaseHandler
    {
        public static void createDatabase()
        {
            string filePath = "userData.txt";
            string contentToWrite = "Obama\n";
            contentToWrite += "911";
            contentToWrite += "001";
            contentToWrite += "T72";
            contentToWrite += "Diesel";
            contentToWrite += "002";
            contentToWrite += "Maxwell";
            contentToWrite += "CodexUmbra";
            contentToWrite += "003";
            contentToWrite += "Gerente";
            contentToWrite += "jerente";
            contentToWrite += "004";
            contentToWrite += "Raúl Padilla Mendonza";
            contentToWrite += "17/6/1918";
            contentToWrite += "005";

            try
            {
                File.WriteAllText(filePath, contentToWrite);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Erro 8.888: {e.Message}");
            }
        }
    }
}


//VsCodium >>> Visual Studio