using Genfr.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genfr.Data.Context
{
    public class SampleInitializer : DropCreateDatabaseAlways<SampleContext>
    {
        protected override void Seed(SampleContext context)
        {
            context.Authors.AddRange(new List<Author>
            {
                new Author{ Name="Orwell"},
                new Author{ Name="Banks"},
                new Author{ Name="Gibson"},
                new Author{ Name="Stirling"}
            });

            context.Publishers.AddRange(new List<Publisher> { 
                new Publisher { Name="Penguin"},
                new Publisher { Name="Frobisher"}
            });

            var TheWaspFactory = new Book
            {
                Title="The Wasp Factory",
                Publisher = context.Publishers.Local.Single(p => p.Name == "Penguin"),
                EditionInt = 2,
                EditionIntN = 2,
                EditionDouble = 2d,
                EditionDoubleN = 2d,
                EditionDecimal = 2M,
                EditionDecimalN = 2M,
                EditionFloat = 2,
                EditionFloatN = 2,
                EditionLong = 2,
                EditionLongN = 2
            };

            TheWaspFactory.Authors.Add(context.Authors.Local.Single(a => a.Name=="Banks"));

            var TheDifferenceEngine = new Book
            {
                Title = "The Difference Engine",
                Publisher = context.Publishers.Local.Single(p => p.Name == "Penguin"),
                EditionInt = 4,
                EditionIntN = 4,
                EditionDouble = 4d,
                EditionDoubleN = 4d,
                EditionDecimal = 4M,
                EditionDecimalN = 4M,
                EditionFloat = 4,
                EditionFloatN = 4,
                EditionLong = 4,
                EditionLongN = 4
            };

            TheDifferenceEngine.Authors.Add(context.Authors.Local.Single(a => a.Name == "Banks"));
            TheDifferenceEngine.Authors.Add(context.Authors.Local.Single(a => a.Name == "Stirling"));

            context.Books.AddRange(new List<Book> { 
                TheWaspFactory,
                TheDifferenceEngine
            });
        }
    }
}
