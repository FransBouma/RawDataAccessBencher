using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;
using RawBencher.BenchmarkDotNet;

namespace RawBencher
{
	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				// old runner
				//OriginalController.Run(args);

				// BenchmarkDotNet runner
				var summary = BenchmarkRunner.Run<BenchmarkDotNetController>();
			}
			catch(Exception ex)
			{
				BencherUtils.DisplayException(ex);
			}
		}
	}
}
