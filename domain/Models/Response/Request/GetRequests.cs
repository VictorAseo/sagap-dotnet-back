using domain.Models.Response.Project;

namespace domain.Models.Response.Request;

public class GetRequests
{
    public int Id { get; set; }
    public string ProjectName { get; set; }
    public string Description { get; set; }
    public string RequestType { get; set; }
    public IEnumerable<UserInfos> Students { get; set; }
}
