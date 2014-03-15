using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genfr.Data.Entities
{
    public class Book
    {
        public Book()
        {
            Authors = new List<Author>();
        }

        [Key]
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual int? EditionIntN { get; set; }

        public virtual int EditionInt { get; set; }

        public virtual double? EditionDoubleN { get; set; }

        public virtual double EditionDouble { get; set; }

        public virtual decimal? EditionDecimalN { get; set; }

        public virtual decimal EditionDecimal { get; set; }

        public virtual float? EditionFloatN { get; set; }

        public virtual float EditionFloat { get; set; }

        public virtual long? EditionLongN { get; set; }

        public virtual long EditionLong { get; set; }

        public int PublisherId { get; set; }

        [Required]
        public Publisher Publisher { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
