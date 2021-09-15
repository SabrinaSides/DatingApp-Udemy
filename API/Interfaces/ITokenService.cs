using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        //interfaces don't actually have any implentation, interfaces are a contract between the service and the class using the interface, excels in testing
        //createToken found under services folder
         string CreateToken(AppUser user);
    }
}