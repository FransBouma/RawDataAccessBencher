using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher
{
	public static class BencherUtils
	{
		public static Version GetVersion(Type type)
		{
			return BencherUtils.GetAssembly(type).GetName().Version;
		}


		public static Assembly GetAssembly(Type type)
		{
			return type.Assembly;
		}


		public static void DisplayException(Exception toDisplay)
		{
			if (toDisplay == null)
			{
				return;
			}

			Console.WriteLine("Exception caught of type: {0}", toDisplay.GetType().FullName);
			Console.WriteLine("Message: {0}", toDisplay.Message);
			Console.WriteLine("Stack trace:\n{0}", toDisplay.StackTrace);
			Console.WriteLine("Inner exception:");
			BencherUtils.DisplayException(toDisplay.InnerException);
		}
	}
}
