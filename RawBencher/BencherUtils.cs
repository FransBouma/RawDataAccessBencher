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
	}
}
