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
    /// <summary>
    /// Testing all IQueryBuilder methods (skipping cancellation token overloads).
    /// </summary>
    [TestClass]
    public class QueryBuilderTests
    {
        private const string connectionString = @"Data Source=(LocalDb)\mssqllocaldb;AttachDbFilename=|DataDirectory|\FluentRep.mdf;Initial Catalog=FluentRep;Integrated Security=True";
        //private Store store;

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
            //this.store = new Store(new SampleContext(connectionString));
        }


        [TestMethod]
        public async Task AllAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {                
                var result = await store.Query<Author>().AllAsync(a => a.Id < 9999);
            }
        }

        [TestMethod]
        public async Task AverageAsyncDecimalNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                decimal? expected = 3M;
                decimal? result = await store.Query<Book>().Select(b => b.EditionDecimalN).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncDecimal()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                decimal expected = 3M;
                decimal result = await store.Query<Book>().Select(b => b.EditionDecimal).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncDecimalNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                decimal? expected = 3M;
                decimal? result = await store.Query<Book>().AverageAsync(b =>  b.EditionDecimalN);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncDecimalSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                decimal expected = 3M;
                decimal result = await store.Query<Book>().AverageAsync(b => b.EditionDecimal);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncDoubleNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double? expected = 3d;
                double? result = await store.Query<Book>().Select(b => b.EditionDoubleN).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncDouble()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double expected = 3d;
                var res = await store.Query<Book>().Select(b => b.EditionDouble).ToListAsync();
                double result = await store.Query<Book>().Select(b => b.EditionDouble).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncDoubleNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double? expected = 3d;
                double? result = await store.Query<Book>().AverageAsync(b => b.EditionDoubleN);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncDoubleSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double expected = 3d;
                double result = await store.Query<Book>().AverageAsync(b => b.EditionDouble);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncFloatNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                float? expected = 3;
                float? result = await store.Query<Book>().Select(b => b.EditionFloatN).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncFloat()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                float expected = 3;
                float result = await store.Query<Book>().Select(b => b.EditionFloat).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncFloatNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                float? expected = 3;
                float? result = await store.Query<Book>().AverageAsync(b => b.EditionFloatN);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncFloatSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                float expected = 3;
                float result = await store.Query<Book>().AverageAsync(b => b.EditionFloat);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncIntNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double? expected = 3;
                double? result = await store.Query<Book>().Select(b => b.EditionIntN).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncInt()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double expected = 3;
                double result = await store.Query<Book>().Select(b => b.EditionInt).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncIntNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double? expected = 3;
                double? result = await store.Query<Book>().AverageAsync(b => b.EditionIntN);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncIntSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double expected = 3;
                double result = await store.Query<Book>().AverageAsync(b => b.EditionInt);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncLongNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double? expected = 3;
                double? result = await store.Query<Book>().Select(b => b.EditionLongN).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncLong()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double expected = 3;
                double result = await store.Query<Book>().Select(b => b.EditionLong).AverageAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncLongNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double expected = 3;
                double result = await store.Query<Book>().AverageAsync(b => b.EditionLong);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task AverageAsyncLongSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double expected = 3;
                double result = await store.Query<Book>().AverageAsync(b => b.EditionLong);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task ContainsAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {                
                bool result = await store.Query<Book>().Select(b => b.EditionInt).ContainsAsync(2);

                Assert.IsTrue(result);
            }
        }

        [TestMethod]
        public async Task CountAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                int count = await store.Query<Book>().CountAsync();

                Assert.AreEqual(2, count);
            }
        }

        [TestMethod]
        public async Task CountAsyncPredicate()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                int count = await store.Query<Book>().CountAsync(b => b.Title == "The Wasp Factory");

                Assert.AreEqual(1, count);
            }
        }

        [TestMethod]
        public async Task FirstAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().FirstAsync();

                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public async Task FirstAsyncPredicate()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().FirstAsync(b => b.Title == "The Wasp Factory");

                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public async Task FirstOrDefaultAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().FirstOrDefaultAsync();

                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public async Task FirstOrDefaultAsyncPredicate()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().FirstOrDefaultAsync(b => b.Title == "The Wasp Factory");

                Assert.IsNotNull(result);
            }
        }

        //[TestMethod]
        //public async Task ForEachAsyncT()
        //{
        //    using (var store = new Store(new SampleContext(connectionString)))
        //    {

        //    }
        //}

        //[TestMethod]
        //public async Task ForEachAsyncObject()
        //{
        //    using (var store = new Store(new SampleContext(connectionString)))
        //    {

        //    }
        //}

        [TestMethod]
        public async Task IncludePathSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().Include(b => b.Publisher).FirstOrDefaultAsync();

                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public async Task IncludePathString()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().Include("Publisher").FirstOrDefaultAsync();

                Assert.IsNotNull(result.Publisher);
            }
        }

        [TestMethod]
        public async Task LongCountAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().Include(b => b.Publisher).FirstOrDefaultAsync();

                Assert.IsNotNull(result.Publisher);
            }
        }

        [TestMethod]
        public async Task LongCountAsyncPredicate()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().LongCountAsync();

                Assert.AreEqual(2, result);
            }
        }

        [TestMethod]
        public async Task MaxAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().Select(b => b.EditionInt).MaxAsync();

                Assert.AreEqual(4, result);
            }
        }

        [TestMethod]
        public async Task MaxAsyncSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().MaxAsync(b => b.EditionInt);

                Assert.AreEqual(4, result);
            }
        }

        [TestMethod]
        public async Task MinAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().Select(b => b.EditionInt).MinAsync();

                Assert.AreEqual(2, result);
            }
        }

        [TestMethod]
        public async Task MinAsyncSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().MinAsync(b => b.EditionInt);

                Assert.AreEqual(2, result);
            }
        }

        [TestMethod]
        public async Task SingleAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().Where(b => b.Title == "The Wasp Factory").SingleAsync();

                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public async Task SingleAsyncSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().SingleAsync(b => b.Title == "The Wasp Factory");

                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public async Task SingleOrDefaultAsync()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().Where(b => b.Title == "The Wasp Factory").SingleOrDefaultAsync();

                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public async Task SingleOrDefaultAsyncPredicate()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().SingleOrDefaultAsync(b => b.Title == "The Wasp Factory");

                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public async Task SkipCountAccessor()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().OrderBy(b => b.Id).Skip(() => 1).ToListAsync();

                Assert.AreEqual(1,result.Count);
            }
        }

        [TestMethod]
        public async Task SkipInt()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var result = await store.Query<Book>().OrderBy(b => b.Id).Skip(1).ToListAsync();

                Assert.AreEqual(1, result.Count);
            }
        }

        [TestMethod]
        public async Task SumAsyncDecimalNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                decimal? expected = 6M;
                decimal? result = await store.Query<Book>().Select(b => b.EditionDecimalN).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncDecimal()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                decimal expected = 6M;
                decimal result = await store.Query<Book>().Select(b => b.EditionDecimal).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncDoubleNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double? expected = 6d;
                double? result = await store.Query<Book>().Select(b => b.EditionDoubleN).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncDouble()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double expected = 6d;
                double result = await store.Query<Book>().Select(b => b.EditionDouble).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncFloatNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                float? expected = 6;
                float? result = await store.Query<Book>().Select(b => b.EditionFloatN).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncFloat()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                float expected = 6;
                float result = await store.Query<Book>().Select(b => b.EditionFloat).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncIntNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                int? expected = 6;
                int? result = await store.Query<Book>().Select(b => b.EditionIntN).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncInt()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                int expected = 6;
                int result = await store.Query<Book>().Select(b => b.EditionInt).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncLongNullable()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                long? expected = 6;
                long? result = await store.Query<Book>().Select(b => b.EditionLongN).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncLong()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                long expected = 6;
                long result = await store.Query<Book>().Select(b => b.EditionLong).SumAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncDecimalNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                decimal? expected = 6M;
                decimal? result = await store.Query<Book>().SumAsync(b => b.EditionDecimalN);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncDecimalSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                decimal expected = 6M;
                decimal result = await store.Query<Book>().SumAsync(b => b.EditionDecimal);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncDoubleNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double? expected = 6d;
                double? result = await store.Query<Book>().SumAsync(b => b.EditionDoubleN);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncDoubleSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                double expected = 6d;
                double result = await store.Query<Book>().SumAsync(b => b.EditionDouble);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncFloatNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                float? expected = 6;
                float? result = await store.Query<Book>().SumAsync(b => b.EditionFloatN);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncFloatSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                float expected = 6;
                float result = await store.Query<Book>().SumAsync(b => b.EditionFloat);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncIntNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                int? expected = 6;
                int? result = await store.Query<Book>().SumAsync(b => b.EditionIntN);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncIntSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                int expected = 6;
                int result = await store.Query<Book>().SumAsync(b => b.EditionInt);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncLongNullableSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                long? expected = 6;
                long? result = await store.Query<Book>().SumAsync(b => b.EditionLongN);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task SumAsyncLongSelector()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                long expected = 6;
                long result = await store.Query<Book>().SumAsync(b => b.EditionLong);

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task Page()
        {
            using (var store = new Store(new SampleContext(connectionString)))
            {
                var expected = 1;
                var result = await store.Query<Book>().OrderBy(b => b.Title).Page(0,1).CountAsync();

                Assert.AreEqual(expected, result);
            }
        }
    }
}
