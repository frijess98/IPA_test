using Microsoft.EntityFrameworkCore;
using SCE.ServicingPartnerInfoCheck.DAL.Configurations;

namespace SCE.ServicingPartnerInfoCheck.DAL
{
    /// <summary>
    /// DB Context
    /// </summary>
    public class SpInfoCheckContext : DbContext
    {
        private const string SchemaName = "spInfoCheck";
        private readonly string connectionString;

        /// <summary>
        /// Parameterless Constructor with specified ConnectionString
        /// </summary>
        public SpInfoCheckContext()
        {
            this.connectionString = @"Server=.\;initial catalog=ADFS_DAM_SCE_DEV;persist security info=True;Integrated Security=true;Connection Timeout=30;MultipleActiveResultSets=True;";
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connectionString">Connection String</param>
        public SpInfoCheckContext(string connectionString) : base()
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Configuration
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ToDo: Move this out to DI when migrated to Core completely
            optionsBuilder
                .UseSqlServer(connectionString,
                    // Migration History table
                    x => x.MigrationsHistoryTable("__MigrationsHistory", SchemaName));
        }


        /// <summary>
        /// ModelCreation
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(SchemaName);

            modelBuilder.ApplyConfiguration(new SpInfoCheckConfiguration());
        }
    }
}
