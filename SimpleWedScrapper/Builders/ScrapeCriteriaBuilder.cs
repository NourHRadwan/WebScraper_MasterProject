using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SimpleWedScrapper.Data;
 
namespace SimpleWedScrapper.Builders
{
    class ScrapeCriteriaBuilder
    {

        #region Required Data
        //The data that is required to create a builder is the following
        private string _data;
        private string _regex;
        private RegexOptions _regexOption;
        private List<ScrapeCriteriaPart> _parts;
        #endregion

        #region Constructor
        public ScrapeCriteriaBuilder()
        {
            SetDefaults();
        }

        //SetDefaults Methods is going to set the default values for the data
        private void SetDefaults()
        {
            //We are going to set the default value for the data to empty string
            _data = string.Empty;

            //We are going to set the default value for the regex to empty string
            _regex = string.Empty;
            
            //We are going to set the default value for the regexOption to None
            _regexOption = RegexOptions.None;
            
            //We are going to create a new list of ScrapeCriteriaPart
            _parts = new List<ScrapeCriteriaPart>(); 
        }
        #endregion

        #region Methods
        // The methods that allow us to set each and every of the fields
        public ScrapeCriteriaBuilder WithData(string data)
        {
            this.data = data;
            return this;
        }
 
        public ScrapeCriteriaBuilder WithRegex(string regex)
        {
            this.regex = regex;
            return this;
        }
 
        public ScrapeCriteriaBuilder WithRegexOption(RegexOptions regexOption)
        {
            this.regexOption = regexOption;
            return this;
        }
 
        public ScrapeCriteriaBuilder WithParts(List<ScrapeCriteriaPart> parts)
        {
            this.parts = parts;
            return this;
        }
 
        public ScrapeCriteria Build()
        {
            ScrapeCriteria scrapeCriteria = new ScrapeCriteria();
            scrapeCriteria.Data = data;
            scrapeCriteria.Regex = regex;
            scrapeCriteria.RegexOption = regexOption;
            scrapeCriteria.Parts = parts;
 
            return scrapeCriteria;
        }
        #endregion
    }
}
{
	public Class1()
	{

    }
}
