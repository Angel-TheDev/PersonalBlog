﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Post post { get; set; }
        public virtual List<TagPosts> TagPosts { get; set; }

    }
}
