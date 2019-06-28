﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Model
{
    public class TagPosts
    {
        public virtual int TagId { get; set; }
        public virtual Tag tag { get; set; }
        public virtual int PostId { get; set; }
        public virtual Post post { get; set; }
    }
}
