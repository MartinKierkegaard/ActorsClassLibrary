using ActorsClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorsClassLibraryTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ActorsRepositoryTests
    {
        //her bruges interfacet IActorsRepository
        private static IActorsRepository _repository;

        /// <summary>
        /// opsætter object der skal testes på. 
        /// Bemærk at typen af _repository er et interface 
        /// nemlig IActorsRepository
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            //her initialiseres repository med klassen som som arbejder på en liste,
            //dette kunne byttes ud med det repository som arbejder på databasen

            _repository = new ActorsRepositoryList();

            //I Init kan der også tilføjes testdata til listen så du ved hvad du tester på ! 

        }

        /// <summary>
        /// tester at GetAll metoden virker
        /// </summary>
        [TestMethod(), Priority(1)]
        [DoNotParallelize]
        public void TestGetAllInterface()
        {

            //Act
            //IActorsRepository _repository = _repository;

            //arrange
            var result = _repository.GetAll();

            //assert
            Assert.AreEqual(4, result.Count);
        }


        /// <summary>
        /// tester at connection virker for GetById metoden
        /// </summary>
        [TestMethod(), Priority(2)]
        [DoNotParallelize]

        public void TestGetByIdOkInterface()
        {

            //Act
            //IActorsRepository _repository = _repository;

            //arrange
            Actor result = _repository.GetById(1);

            //assert
            Assert.AreEqual("Bent", result.Name);
        }

        [TestMethod(), Priority(3)]
        [DoNotParallelize]

        public void TestGetFiltreringBirthYear()
        {

            //Act
            //IActorsRepository _repository = _repository;

            //arrange
            IEnumerable<Actor> result = _repository.Get(1999, null);

            //assert
            Assert.AreEqual(2, result.Count());
        }

    }
}
