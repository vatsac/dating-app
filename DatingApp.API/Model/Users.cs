using System;
using System.Collections.Generic;

namespace DatingApp.API.Model
{
    public partial class Users
    {
        public Users()
        {
            LikesLikee = new HashSet<Likes>();
            LikesLiker = new HashSet<Likes>();
            MessageRecipient = new HashSet<Message>();
            MessageSender = new HashSet<Message>();
            Photo = new HashSet<Photo>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Likes> LikesLikee { get; set; }
        public virtual ICollection<Likes> LikesLiker { get; set; }
        public virtual ICollection<Message> MessageRecipient { get; set; }
        public virtual ICollection<Message> MessageSender { get; set; }
        public virtual ICollection<Photo> Photo { get; set; }
    }
}
