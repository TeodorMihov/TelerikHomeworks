using System.Collections.Generic;
namespace School
{
    public interface ICommentable
    {
        List<string> comments { get; }
        void AddComment(string comment);
    }
}
