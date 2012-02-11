using System.Collections.Generic;

namespace Blog.Comments
{
  public class CommentsViewModel
  {
    public IEnumerable<CommentViewModel> Comments { get; set; }
  }
}