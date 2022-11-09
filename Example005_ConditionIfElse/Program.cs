Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша".ToLower())
    Console.WriteLine("Ура, это же МАША!");
else
    Console.WriteLine("Привет, " + username);