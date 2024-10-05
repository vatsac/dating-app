using System;
using System.Collections.Generic;

namespace DatingApp.API.Model
{
    public partial class Likes
    {
        public int Id { get; set; }
        public int LikerId { get; set; }
        public int LikeeId { get; set; }

        public virtual Users Likee { get; set; }
        public virtual Users Liker { get; set; }
    }
}
