namespace CookTime
{
    public class Comment
    {
        public string User { get; set; }
        public string comment { get; set; }
        public Comment(string user,string comment)
        {
            this.User = user;
            this.comment = comment;
        }
    }
}