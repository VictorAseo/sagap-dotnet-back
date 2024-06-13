using domain.Entities;

namespace domain.Models.Response.Request;

public class GetOrientationRequestContext
{
    public IEnumerable<SelectListItem> Students { get; set; }
    public IEnumerable<SelectListItem> Teachers { get; set; }
}
