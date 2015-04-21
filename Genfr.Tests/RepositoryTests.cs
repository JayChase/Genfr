using Genfr.Data.Context;
using Genfr.Data.Entities;
using Genfr.EntityFramework;
using Genfr.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq;

namespace FluentRepository.Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private const string connectionString = @"Data Source=(LocalDb)\mssqllocaldb;AttachDbFilename=|DataDirectory|\FluentRep.mdf;Initial Catalog=FluentRep;Integrated Security=True";
        private Store store;

        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //drop and recreate the test Db everytime the tests are run. 
            AppDomain.CurrentDomain.SetData("DataDirectory", testContext.TestDeploymentDir);

            using (var context = new SampleContext(connectionString))
            {
                System.Data.Entity.Database.SetInitializer<SampleContext>(new SampleInitializer());
                context.Database.Initialize(true);
            }
        }

        [TestInitialize]
        public void Init()
        {                 
            this.store = new Store(new SampleContext(connectionString));
        }

        [TestMethod]
        public void QueryAuthorsToListReturnsAllAuthors()
        {
            var authors = store.Query<Author>().ToList();

            Assert.AreEqual(4, authors.Count);
        }

        [TestMethod]
        public async Task QueryAuthorsToListAsyncReturnsAllAuthors()
        {
            var authors = await store.Query<Author>().ToListAsync();

            Assert.AreEqual(4, authors.Count);
        }

        [TestMethod]
        public void FilteredQueryAuthorsToListReturnsSomeAuthors()
        {
            var authors = store.Query<Author>().Where(a => a.Name != "Orwell").ToList();

            Assert.AreEqual(3, authors.Count);
        }

        [TestMethod]
        public async Task FilteredQueryAuthorsToListAsyncReturnsSomeAuthors()
        {
            var authors = await store.Query<Author>().Where(a => a.Name != "Orwell").ToListAsync();

            Assert.AreEqual(3, authors.Count);
        }

        [TestMethod]
        public void UnfilteredFirstOrDefaultResultNotNull()
        {
            var author = store.Query<Author>().FirstOrDefault();

            Assert.IsNotNull(author);
        }

        [TestMethod]
        public async Task UnfilteredFirstOrDefaultAsyncResultNotNull()
        {
            var author = await store.Query<Author>().FirstOrDefaultAsync();

            Assert.IsNotNull(author);
        }

        [TestMethod]
        public void FilteredFirstOrDefaultResultIsCorrect()
        {
            var author = store.Query<Author>().Where(a => a.Name == "Orwell").FirstOrDefault();

            Assert.AreEqual("Orwell", author.Name);
        }

        [TestMethod]
        public async Task FilteredFirstOrDefaultAsyncResultIsCorrect()
        {
            var author = await store.Query<Author>().Where(a => a.Name == "Orwell").FirstOrDefaultAsync();

            Assert.AreEqual("Orwell", author.Name);
        }

        [TestMethod]
        public async Task WithoutIncludePublisherNavPropIsNotLoaded()
        {
            var book = await store.Query<Book>()
                                .Where(b => b.Title == "The Wasp Factory")
                                .FirstOrDefaultAsync();

            Assert.IsNull(book.Publisher);
        }

        [TestMethod]
        public async Task WithIncludePublisherNavPropIsLoaded()
        {
            var book = await store.Query<Book>()
                                .Where(b => b.Title == "The Wasp Factory")
                                .Include(b => b.Publisher)
                                .FirstOrDefaultAsync();

            Assert.IsNotNull(book.Publisher);
        }

        [TestMethod]
        public async Task WithoutIncludeAuthorsNavColIsNotLoaded()
        {
            var book = await store.Query<Book>().Where(b => b.Title == "The Wasp Factory").FirstOrDefaultAsync();

            Assert.AreEqual(0,book.Authors.Count);
        }

        [TestMethod]
        public async Task WithIncludeAuthorsNavColIsLoaded()
        {
            var book = await store.Query<Book>().Where(b => b.Title == "The Wasp Factory").Include(b => b.Authors).FirstOrDefaultAsync();

            Assert.AreEqual(1,book.Authors.Count);
        }

        [TestMethod]
        public async Task AuthorsOrderByNameIsOrderedAZ()
        {
            var authors = await  store.Query<Author>().OrderBy(b => b.Name).ToListAsync();

            Assert.IsTrue(authors[0].Name == "Banks" & authors[1].Name == "Gibson" & authors[2].Name == "Orwell" & authors[3].Name == "Stirling");
        }

        [TestMethod]
        public async Task AuthorsOrderByDescendingNameIsOrderedZA()
        {
            var authors = await  store.Query<Author>().OrderByDescending(b => b.Name).ToListAsync();

            Assert.IsTrue(authors[3].Name == "Banks" & authors[2].Name == "Gibson" & authors[1].Name == "Orwell" & authors[0].Name == "Stirling");
        }

        [TestMethod]
        public async Task AuthorsOrderByPropertyNameIsOrderedAZ()
        {
            var authors = await store.Query<Author>().OrderBy<Author>("Name").ToListAsync();

            Assert.IsTrue(authors[0].Name == "Banks" & authors[1].Name == "Gibson" & authors[2].Name == "Orwell" & authors[3].Name == "Stirling");
        }

        [TestMethod]
        public async Task AuthorsOrderByDescendingPropertyNameIsOrderedZA()
        {
            var authors = await store.Query<Author>().OrderByDescending<Author>("Name").ToListAsync();

            Assert.IsTrue(authors[3].Name == "Banks" & authors[2].Name == "Gibson" & authors[1].Name == "Orwell" & authors[0].Name == "Stirling");
        }

        [TestMethod]
        public async Task AuthorsPagingWorksPage1()
        {
            var authors = await  store.Query<Author>().OrderBy(b => b.Name).Page(0,2).ToListAsync();

            Assert.IsTrue(authors.Count == 2 & authors[0].Name == "Banks" & authors[1].Name == "Gibson");
        }

        [TestMethod]
        public async Task AuthorsPagingWorksPage2()
        {
            var authors = await  store.Query<Author>().OrderBy(b => b.Name).Page(1, 2).ToListAsync();

            Assert.IsTrue(authors.Count == 2 & authors[0].Name == "Orwell" & authors[1].Name == "Stirling");
        }

        [TestMethod]
        public async Task CreateNewAuthorAddsAuthor()
        {
            var authorCount = await store.Query<Author>().CountAsync();

            var author = new Author
            {
                Name = "Ballard"
            };

            await store.CreateAsync(author);

            var newAuthorCount = await store.Query<Author>().CountAsync();

            Assert.AreEqual(authorCount + 1, newAuthorCount);
        }

        [TestMethod]
        public async Task UpdateAuthorPersistsChange()
        {
            var author = await store.Query<Author>().Where(a => a.Name == "Orwell").FirstOrDefaultAsync();

            author.Name = "Orwell2";

            await store.UpdateAsync<Author>(author);

            var count = await store.Query<Author>().Where(a => a.Name == "Orwell2").CountAsync();

            Assert.AreEqual(1,count);
        }

        [TestMethod]
        public async Task DeleteAuthorWorks()
        {
            var author = await store.Query<Author>().Where(a => a.Name == "Orwell2").FirstOrDefaultAsync();            

            await store.DeleteAsync<Author>(author);

            var count = await store.Query<Author>().Where(a => a.Name == "Orwell2").CountAsync();

            Assert.AreEqual(0, count);
        }
        
    }
}
