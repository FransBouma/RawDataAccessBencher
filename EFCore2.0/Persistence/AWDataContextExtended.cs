using Microsoft.EntityFrameworkCore;

namespace EFCore20.Bencher
{
	public partial class AWDataContext
	{
		private string _connectionString = string.Empty;


		public AWDataContext(string connectionString)
		{
			_connectionString = connectionString;
		}
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_connectionString);
			base.OnConfiguring(optionsBuilder);
		}
	}
}