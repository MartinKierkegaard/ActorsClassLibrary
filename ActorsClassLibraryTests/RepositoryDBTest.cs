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

        private static IActorsRepository _actorsRepository;

        /// <summary>
        /// opsætter object der skal testes på. Bemærk at typen af _repository er et interface 
        /// nemlig IActorsRepository
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            _actorsRepository = new ActorsRepositoryDB();

        }

        /// <summary>
        /// tester at connection virker for GetAll metoden
        /// </summary>
        [TestMethod(),Priority(1)]
        [DoNotParallelize]
        public void TestGetAllConnectionOkDB()
        {

            //Act
            IActorsRepository db = _actorsRepository;

            //arrange
            var result = db.GetAll();

            //assert
            Assert.AreEqual(4, result.Count);
        }


        /// <summary>
        /// tester at connection virker for GetById metoden
        /// </summary>
        [TestMethod(),Priority(2)]
        [DoNotParallelize]

        public void TestGetByIdDBConnectionOk()
        {

            //Act
            IActorsRepository db = _actorsRepository;

            //arrange
            Actor result = db.GetById(1);

            //assert
            Assert.AreEqual(1, result.Id);
        }


    }
}
