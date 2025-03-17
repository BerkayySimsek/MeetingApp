namespace MeetingApp.Models;

public static class Repository
{
    private static List<UserInfo> _users = new();

    static Repository()
    {
        _users.Add(new UserInfo { Id = 1, Name = "Berkay", Email = "berkayysimsekk@gmail.com", Phone = "5384882550", WillAttend = true });
        _users.Add(new UserInfo { Id = 2, Name = "Cansu", Email = "sn.cansu@gmail.com", Phone = "5344882448", WillAttend = true });
        _users.Add(new UserInfo { Id = 3, Name = "Buket", Email = "buket@gmail.com", Phone = "5364882346", WillAttend = true });
        _users.Add(new UserInfo { Id = 4, Name = "Ahmet", Email = "aksakalahmet@gmail.com", Phone = "5365185646", WillAttend = false });


    }

    public static List<UserInfo> Users
    {
        get { return _users; }
    }

    public static void CreateUser(UserInfo user)
    {
        user.Id = Users.Count + 1;
        _users.Add(user);
    }

    public static UserInfo GetById(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }
}
