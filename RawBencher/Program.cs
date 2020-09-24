using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.DatabaseSpecific;

namespace RawBencher
{
	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				BenchController.Run(args);
			}
			catch(Exception ex)
			{
				BencherUtils.DisplayException(ex);
			}
		}
	}
}
