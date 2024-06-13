using domain.Enums;

namespace domain.Models.Response.TaskAttachment;

public class TaskAttachmentInfos
{
    public int Id { get; set; }
    public int ProjectTaskId { get; set; }
    public string Name { get; set; }
    public string Attachment { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; }
    public TypeUserEnum UserType { get; set; }

    public DateTime Created { get; set; }
}
