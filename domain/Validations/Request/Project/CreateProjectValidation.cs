using domain.Models.Request.Project;

namespace domain.Validations.Request.Project;

public static class CreateProjectValidation
{
    public static bool ValidateBody(CreateProjectModel body)
    {
        return true;
    }
}
