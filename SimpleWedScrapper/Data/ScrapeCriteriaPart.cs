using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SimpleWedScrapper.Data
{
	class ScrapeCriteriaPart()
	{
		#region Constructor
        public ScrapeCriteriaPart()
        {
            RegexOption = RegexOptions.None;
        }
        #endregion

        #region Properties
                public string Regex { get; set; }
                public RegexOptions RegexOption { get; set; }
        #endregion

        
        public string Scrape(string data)
        {
            MatchCollection matches = Regex.Matches(data, Regex);
            return matches[0].Groups[1].Value;
        }

	}
}
