using CsharpOOP_Course.OOP.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using WorldNamespace;

namespace CsharpOOP_Course.OOP
{
    public class Country : World
    {
        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
        private string capital;

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }
        private CountryLanguages countryLanguages;

        public CountryLanguages CountryLanguages
        {
            get { return countryLanguages; }
            set { countryLanguages = value; }
        }
        private Currencies currency;

        public Currencies Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public Country(string countryName, string capital)
        {
            this.countryName = countryName;
            this.capital = capital;
        }

        public void SayHi()
        {
            Console.WriteLine("Hi!");
        }

        public void SayHi(Country country)
        {
            Console.WriteLine($"Hi! from planet {country.PlanetName} and continent {country.Continents}. The details of the country are : " +
                $"{country.CountryName}, {country.Capital}, with languages : {country.countryLanguages.FirstLanguage} and {country.countryLanguages.SecondLanguage}" +
                $" with currency : {country.Currency}");
        }

    }

     public struct CountryLanguages
    {
        private Languages firstLanguage;

        public Languages FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }
        private Languages secondLanguage;

        public Languages SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }


    }
}
