using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genfr.Data.Entities
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        [Key]
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
