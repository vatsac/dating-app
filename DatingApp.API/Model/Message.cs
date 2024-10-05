﻿using System;
using System.Collections.Generic;

namespace DatingApp.API.Model
{
    public partial class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; }
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }

        public virtual Users Recipient { get; set; }
        public virtual Users Sender { get; set; }
    }
}
