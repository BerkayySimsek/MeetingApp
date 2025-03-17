namespace MeetingApp.Models;

public static class Repository
{
    private static List<UserInfo> _users = new();

    static Repository()
    {
        _users.Add(new UserInfo { Name = "Berkay", Email = "berkayysimsekk@gmail.com", Phone = "5384882550", WillAttend = true });
        _users.Add(new UserInfo { Name = "Cansu", Email = "sn.cansu@gmail.com", Phone = "5344882448", WillAttend = true });
        _users.Add(new UserInfo { Name = "Buket", Email = "buket@gmail.com", Phone = "5364882346", WillAttend = true });
        _users.Add(new UserInfo { Name = "Ahmet", Email = "aksakalahmet@gmail.com", Phone = "5365185646", WillAttend = false });


    }

    public static List<UserInfo> Users
    {
        get { return _users; }
    }

    public static void CreateUser(UserInfo user)
    {
        _users.Add(user);
    }
}
