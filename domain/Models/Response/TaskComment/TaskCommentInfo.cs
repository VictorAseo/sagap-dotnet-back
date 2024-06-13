using domain.Enums;

namespace domain.Models.Response.TaskComments;

public class TaskCommentInfo
{
    public int Id { get; set; }
    public int TaskId { get; set; }
    public string Comment { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; }
    public TypeUserEnum UserType { get; set; }
    public DateTime Created { get; set; }
}
