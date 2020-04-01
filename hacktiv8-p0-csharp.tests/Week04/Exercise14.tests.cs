using System.Collections;
using System.Collections.Generic;
using Xunit;
using static hacktiv8_p0_csharp.Week04.Exercise14;
using hacktiv8_p0_csharp.Week04;
using System;
using System.Linq;

namespace hacktiv8_p0_csharp.tests.Week04
{
    public class NaikAngkotTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<(string, string, string)>
                {
                    ("Dimitri", "B", "F"),
                    ("Icha", "A", "B")
                },
                new List<DataPenumpang>
                {
                    new DataPenumpang
                    {
                        Penumpang = "Dimitri",
                        NaikDari = "B",
                        Tujuan = "F",
                        Bayar = 8000M
                    },
                    new DataPenumpang
                    {
                        Penumpang = "Icha",
                        NaikDari = "A",
                        Tujuan = "B",
                        Bayar = 2000M
                    }
                }
            };
            yield return new object[]
            {
                new List<(string, string, string)> { },
                new List<DataPenumpang> { }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Exercise14
    {
        [Theory]
        [ClassData(typeof(NaikAngkotTestData))]
        public void NaikAngkotTest(List<(string, string, string)> arrPenumpang, List<DataPenumpang> expected)
        {
            var actual = NaikAngkot(arrPenumpang);

            Assert.Equal(expected.Count(), actual.Count());

            for (int i = 0; i < expected.Count(); i++)
            {
                Assert.Equal(expected[i].Penumpang, actual[i].Penumpang);
                Assert.Equal(expected[i].NaikDari, actual[i].NaikDari);
                Assert.Equal(expected[i].Tujuan, actual[i].Tujuan);
                Assert.Equal(expected[i].Bayar, actual[i].Bayar);
            }
        }
    }
}