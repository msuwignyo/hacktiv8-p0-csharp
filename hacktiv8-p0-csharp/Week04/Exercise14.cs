// Week 04 - Exercise 14
// Naik Angkot
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-naik-angkot.md

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hacktiv8_p0_csharp.Week04
{
    public class DataPenumpang
    {
        public string Penumpang { get; set; }
        public string NaikDari { get; set; }
        public string Tujuan { get; set; }
        public decimal Bayar { get; set; }
    }

    public class Exercise14
    {
        public static List<DataPenumpang> NaikAngkot(List<(string, string, string)> arrPenumpang)
        {
            var rute = new string[] { "A", "B", "C", "D", "E", "F" };

            var result = new List<DataPenumpang>();

            foreach (var (penumpang, naikDari, tujuan) in arrPenumpang)
            {
                result.Add(new DataPenumpang
                {
                    Penumpang = penumpang,
                    NaikDari = naikDari,
                    Tujuan = tujuan,
                    Bayar = (Array.IndexOf(rute, tujuan) - Array.IndexOf(rute, naikDari)) * 2000
                });
            }

            return result;
        }
    }
}
