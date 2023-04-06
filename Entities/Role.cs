namespace WebApi.Entities;

public enum Role
{
    // validations, defines all available roles in the api. only admin and user.
    //this is a separate class from string/int and is written this way to differentiate regular roles from just being strings.
    Admin,
    User
}