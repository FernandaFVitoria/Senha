using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

bool x = true;
if (x)
    {Console.Beep();
     Console.Beep();
}
else 
    {Console.Beep(1500, 100);
     Console.Beep(1500, 100);
}



// See https://aka.ms/new-console-template for more information
Console.Write("Olá, usuário. Por favor, digite sua senha: ");
string senhaDigitada = Console.ReadLine()!;
const string SenhaCorreta = "1234abcd";

if (senhaDigitada == SenhaCorreta)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Acesso Permitido");
   
}
else 
{
    Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Acesso Negado");

}
Console.ResetColor();


