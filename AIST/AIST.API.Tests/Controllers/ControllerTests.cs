using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AIST.API.Controllers;
using AIST.DataAccess.AISTDatabaseContext;
using Microsoft.EntityFrameworkCore;
using AIST.DataAccess.AISTModel;
using AIST.DataAccess.Repository;

namespace AIST.API.SystemTests.Controllers
{
    [TestClass]
    public class ControllerTests
    {
        private AISTController _controller;
        private DbContextOptionsBuilder<DataAccessDbContext> optionsBuilder;
        private DataAccessDbContext context;
        private AISTRepository _testAistRepository;
        private string connectionString = "Server=???;Database=AISTDB_TEST;User Id=???; Password=???;Trusted_Connection=True;MultipleActiveResultSets=true";

        //SEE: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing

        [TestInitialize]
        public void FixtureSetup()
        {
            // Arrange
                        optionsBuilder = new DbContextOptionsBuilder<DataAccessDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            context = new DataAccessDbContext(optionsBuilder.Options);
            _controller = new AISTController(context);
            _testAistRepository = new AISTRepository(context);

            context.Database.ExecuteSqlCommand("Delete PagesData");
        }

        [TestMethod]
        public void PostAddRecord()
        {
            // Act
            var pageData = new PagesData()
            {
                Url = "URL TEST 2",
                HtmlString = "HTML TEST 2",
                PageType = "Page Type Test 2"
            };

            _controller.Put(pageData);
            var response = _controller.Get();

            // Assert
            Assert.AreEqual(1, response.Count());
        }

        [TestMethod]
        public void GetRecodsReturnPagesDataList()
        {
            // Act
            _controller.Put(new PagesData() { Url = "URL TEST 1", HtmlString = "HTML TEST 1", PageType = "Page Type Test 1" });
            _controller.Put(new PagesData() { Url = "URL TEST 2", HtmlString = "HTML TEST 2", PageType = "Page Type Test 2" });

            var response = _controller.Get();

            // Assert
            Assert.AreEqual(response.Count, 2);
        }
    }
}