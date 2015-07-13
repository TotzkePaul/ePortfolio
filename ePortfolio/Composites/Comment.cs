using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ePortfolio.Composites
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int? ParentId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public int CommentTypeId { get; set; }
        public int Vote { get; set; }
        public string CommentText { get; set; }
        public List<Comment> ChildComments { get; set; }

        public static List<Comment> CreateTree(List<Comment> list)
        {
            foreach (Comment comment in list)
            {
                comment.ChildComments =
                  list.Where(c => c.ParentId == comment.CommentId).ToList();
            }
            return list.Where(c => c.ParentId == 0).ToList();
        }
    }
}