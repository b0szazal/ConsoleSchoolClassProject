using Microsoft.VisualStudio.TestTools.UnitTesting;
using CouldntCommitSadge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouldntCommitSadge.Tests
{
    [TestClass()]
    public class ScoolClassRepoMostPaydSchoolClassTests
    {
        [TestMethod()]
        public void MostPaydSchoolClassTestEmptyList()
        {
            ScoolClassRepo arrange = new ScoolClassRepo()
            {
                SchoolClasses = new List<SchoolClass>()
            };

            string actual = arrange.MostPaydSchoolClass();
            string expected=string.Empty;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPaydSchoolClassTestOneClass()
        {
            ScoolClassRepo arrange = new ScoolClassRepo()
            {
                SchoolClasses = new List<SchoolClass>()
                {
                    new()
                    {
                      Evfolyam="11. a",
                      BefizetendoOsztalypenz=7000
                    }
                }
            };

            string actual = arrange.MostPaydSchoolClass();
            string expected = "11. a";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPaydSchoolClassTestTwoClassesOnePaysMore()
        {
            ScoolClassRepo arrange = new ScoolClassRepo()
            {
                SchoolClasses = new List<SchoolClass>()
                {
                    new()
                    {
                      Evfolyam="11. a",
                      BefizetendoOsztalypenz=7000
                    },
                    new()
                    {
                      Evfolyam="12. b",
                      BefizetendoOsztalypenz=9000
                    },
                }
            };

            string actual = arrange.MostPaydSchoolClass();
            string expected = "12. b";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPaydSchoolClassTestTwoClassesBothPaysSame()
        {
            ScoolClassRepo arrange = new ScoolClassRepo()
            {
                SchoolClasses = new List<SchoolClass>()
                {
                    new()
                    {
                      Evfolyam="11. a",
                      BefizetendoOsztalypenz=7000
                    },
                    new()
                    {
                      Evfolyam="12. b",
                      BefizetendoOsztalypenz=7000
                    },
                }
            };

            string actual = arrange.MostPaydSchoolClass();
            string expected = "11. a, 12. b";

            Assert.AreEqual(expected, actual);
        }
    }
}