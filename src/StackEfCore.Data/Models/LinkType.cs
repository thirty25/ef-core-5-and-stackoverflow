﻿using System.Collections.Generic;

#nullable disable

namespace StackEfCore.Data.Models
{
    public partial class LinkType
    {
        public LinkType()
        {
            PostLinks = new HashSet<PostLink>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<PostLink> PostLinks { get; set; }
    }
}
