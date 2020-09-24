using Microsoft.EntityFrameworkCore;

namespace EFCore.Bencher
{
	public partial class AWDataContext
	{
		private string _connectionString = string.Empty;
		private int _batchSize = 0;


		public AWDataContext(string connectionString, int batchSize=0)
		{
			_connectionString = connectionString;
			_batchSize = batchSize;
		}
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_connectionString, b =>
														   {
															   if (_batchSize != 0)
															   {
																   b.MaxBatchSize(_batchSize);
															   }
														   });
			base.OnConfiguring(optionsBuilder);
		}
	}
}