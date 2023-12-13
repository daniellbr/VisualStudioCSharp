using SpaUserControl.Domain.Models;

var user = new User("Daniel","teste@teste.com.br");

try
{
    user.SetPassword("testeDaniell", "testeDaniell");
}
catch (Exception ex)
{

	Console.WriteLine(ex.Message);    
}

user.Validate();

Console.WriteLine(user.Name);
Console.WriteLine(user.Passord);
