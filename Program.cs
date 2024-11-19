User a = new User("bob", "123");
a = new User("alex", "456");
a = new User("dima", "789");
a = new User();

class User
{
    string username;
    int password;
    static List<User> userlist = new List<User>();
    public User()
    {
        GetLogin(this);
        if (CheckPassword(this))
            Console.WriteLine("Успешный вход!");
        else
            Console.WriteLine("Неверный пароль!");
    }
    public User(string a, string b)
    {
        username = a;
        password = b.GetHashCode();
        userlist.Add(this);
    }
    static public void GetLogin(User user)
    {
        Console.WriteLine("Логин: ");
        string? login = Console.ReadLine();
        foreach (User usr in userlist)
        {
            if (usr.username == login)
            {
                user.username = usr.username;
                user.password = usr.password;
                return;
            }
        }
        Console.WriteLine("Не существует пользователя с таким логином");
        Environment.Exit(0);
    }
    public bool CheckPassword(User user)
    {
        Console.WriteLine("Пароль: ");
        if (Console.ReadLine().GetHashCode() != user.password)
            return false;
        return true;
    }
}