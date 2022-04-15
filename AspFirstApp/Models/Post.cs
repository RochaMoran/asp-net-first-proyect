using System;
using System.Collections.Generic;

namespace AspFirstApp.Models
{
    public partial class Post
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Id { get; set; }
        public int IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; } = null!;
    }
}
