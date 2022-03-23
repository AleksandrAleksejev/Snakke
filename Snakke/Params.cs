using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Snakke
{
	public class Params // Класс для того чтобы читать файл парамс и воспроиводилась музыка 
	{
		private string resourcesFoler;
		public Params()
		{
			var ind = Directory.GetCurrentDirectory().ToString().IndexOf("bin", StringComparison.Ordinal);

			string binFolder =
				Directory.GetCurrentDirectory().ToString().Substring(0, ind).ToString();

			resourcesFoler = binFolder + "resources//";
		}
		public string GetResourceFolder()
		{
			return resourcesFoler;
		}
	}
}