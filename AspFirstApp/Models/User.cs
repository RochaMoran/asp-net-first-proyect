using System;
using System.Collections.Generic;

namespace AspFirstApp.Models
{
    public partial class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }

        public string Name { get; set; } = null!;
        public int Id { get; set; }
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
