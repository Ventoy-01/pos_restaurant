namespace Pos_Restaurant.Models;

public class UsersModel
{
    private int id;
    private string username;
    private string password;
    private string role;

    public UsersModel()
    {
        
    }

    public UsersModel(int id, string username, string password, string role)
    {
        this.id = id;
        this.username = username;
        this.password = password;
        this.role = role;
    }

    public int Id
    {
        get { return id; }
        set{ id = value; }
    }

    public string Username
    {
        get { return username; }
        set { username = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    
    public string Role
    {
        get { return role; }
        set { role = value; }
    }

    public bool IsAdmin()
    {
        return Role == "admin";
    }

}