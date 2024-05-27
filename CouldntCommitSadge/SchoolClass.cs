using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouldntCommitSadge
{
    public class SchoolClass
    {
        public string Evfolyam { get; set; } = "";
        public int BefizetendoOsztalypenz { get; set; } = 0;
        public int DiakokSzama { get; set; } = 30;

        public int TeljesTanevbenBefizetettOsztalypenz
        {
            get
            {
                return BefizetendoOsztalypenz * DiakokSzama * 10;
            }
        }

        public SchoolClass() {}

        public void WhatClassPaidMore(SchoolClass otherClass)
        {
            if (BefizetendoOsztalypenz > otherClass.BefizetendoOsztalypenz)
            {
                Console.WriteLine($"{Evfolyam} osztály diákjai  havonta {BefizetendoOsztalypenz-otherClass.BefizetendoOsztalypenz} forinttal többet fizetnek osztálypénzbe, mint {otherClass.Evfolyam} osztály tanulói.");
            }
            else if (otherClass.BefizetendoOsztalypenz > BefizetendoOsztalypenz)
            {
                Console.WriteLine($"{otherClass.Evfolyam} osztály diákjai  havonta {otherClass.BefizetendoOsztalypenz - BefizetendoOsztalypenz} forinttal többet fizetnek osztálypénzbe, mint {Evfolyam} osztály tanulói.");
            }
            else
            {
                Console.WriteLine($"{Evfolyam} és {otherClass.Evfolyam} osztály tanulói ugyan annyit fizetnek osztálypénzbe! havonta.");
            }
        }

        public override string ToString()
        {
            return $"{Evfolyam} ({BefizetendoOsztalypenz} Ft)"; 
        }
    }
}
