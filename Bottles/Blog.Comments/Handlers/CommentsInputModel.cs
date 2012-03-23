namespace Blog.Comments
{
  public class CommentsInputModel
  {
      private string _uri;
      public string Uri
      {
          get { return string.Format("article/{0}", _uri); }
          set { _uri = value; }
      }
  }
}