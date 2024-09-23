using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActorsClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace ActorsClassLibrary.Tests
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class ActorTests
    {
        [TestMethod()]

        [DataRow(1820, 1820,1,"Bent")]
        [DataRow(1821, 1821,2, "Lise")]
        public void ActorBirthYear_1820_OK_Test(int expected, int Birthyear,int Id, string Navn)
        {
            //Arrange
            Actor actor = new(Navn,Id, Birthyear);

            //Act
            var result = actor.BirthYear;
            
            //Assert        
            Assert.AreEqual(expected, result);
        }
    }
}