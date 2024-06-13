using domain.Entities;
using domain.Models.Response.TaskAttachment;
using domain.Models.Response.TaskComments;

namespace domain.Models.Response.Task;

public class TaskInfos
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
    public DateTime Deadline { get; set; }
    public IEnumerable<TaskAttachmentInfos> TaskAttachments { get; set; }
    public IEnumerable<TaskCommentInfo> TaskComments { get; set; }
}
