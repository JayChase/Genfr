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
    public class SqlQueryTests
    {
        private const string connectionString = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\FluentRep.mdf;Initial Catalog=FluentRep;Integrated Security=True";
        private Store store;

        public TestContext TestContext { get; set; }

        private class QueryResult
        {
            public string Title { get; set; }
            public string PubName { get; set; }
        }

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
        public async Task AllAsync()
        {
            var result = await store.SqlQuery<QueryResult>("exec testproc @returnCount={0}", 5).ToListAsync();

            Assert.AreEqual(2, result.Count);
        }

        
    }
}
