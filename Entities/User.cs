namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class User
{
    // user model equivalent

    public int Id { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    // keep in mind that this Role variable is an instance of class Role, defined previously in Role.cs. serialized as a string by Program.cs when returned in json format.
    public Role Role { get; set; }

    [JsonIgnore]
    // similar to private. makes it so that password hash doesn't get returned in any json response.
    public string PasswordHash { get; set; }
}