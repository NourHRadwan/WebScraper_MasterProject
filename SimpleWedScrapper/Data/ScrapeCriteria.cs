using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWedScrapper.Data
{
	class ScrapeCriteria()
	{
		#region Constructor
		public ScrapeCriteria()
		{
			Parts = new List<ScrapeCriteriaPart> ( )	
		}
		#endregion

		#region Properties
				public string Data { get; set; }
				public string Regex { get; set; }
				public RegexOptions RegexOption { get; set; }
				public List<ScrapeCriteriaPart> Parts{ get; set; }
		#endregion

		

	}
}
