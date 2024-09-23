using ActorsClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorsClassLibraryTests
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class RepositoryDBTest
    {
        /// <summary>
        /// tester at connection virker for GetAll metoden
        /// </summary>
        [TestMethod()]
        public void TestGetAllConnectionOkDB()
        {

            //Act
            ActorsRepositoryDB db = new ActorsRepositoryDB();

            //arrange
            var result = db.GetAll();

            //assert
            Assert.AreEqual(4, result.Count);
        }


        /// <summary>
        /// tester at connection virker for GetById metoden
        /// </summary>
        [TestMethod()]
        public void TestGetByIdDBConnectionOk()
        {

            //Act
            ActorsRepositoryDB db = new ActorsRepositoryDB();

            //arrange
            Actor result = db.GetById(1);

            //assert
            Assert.AreEqual(1, result.Id);
        }


    }
}
