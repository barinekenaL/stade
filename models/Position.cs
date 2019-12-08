using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal static class Position {

		public static Dictionary<string, string> SensV() {
			Dictionary<string, string> result = new Dictionary<string, string>();
			result.Add("hb", "H en B");
			result.Add("bh", "B en H");
			return result;
		}

		public static Dictionary<string, string> SensH() {
			Dictionary<string, string> result = new Dictionary<string, string>();
			result.Add("gd", "G a D");
			result.Add("dg", "D a G");
			return result;
		}

		public static Dictionary<string, string> Dir() {
			Dictionary<string, string> result = new Dictionary<string, string>();
			result.Add("Gd", "G a D");
			result.Add("Dg", "D a G");
			result.Add("Bh", "B en H");
			result.Add("Hb", "H en B");
			return result;
		}
	}
}