using domain.Enums;
using domain.Models.Request.User;

namespace domain.Validations.Request;

public static class CreateUserValidation
{
    public static bool ValidateCreateUserBody(CreateUserModel body)
    {
        if (string.IsNullOrEmpty(body.Name)) return false;
        if (string.IsNullOrEmpty(body.Enrollment)) return false;
        if (string.IsNullOrEmpty(body.Password)) return false;

        return true;
    }
}
