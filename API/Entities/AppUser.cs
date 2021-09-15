namespace API.Entities
{
    public class AppUser
    {
        //can be "get" or "set" from other classes in the app
       public int Id { get; set; } 

       public string UserName { get; set; }

       public byte[] PasswordHash { get; set; }

       public byte[] PasswordSalt { get; set; }
       
    }
}