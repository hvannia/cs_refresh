using System;

namespace interFaces
{
	public class DbMigrator
	{

		private readonly ILogger _logger;


		// dependency injection -> specify dependency in the constructor
		public DbMigrator(ILogger logger)
		{
			_logger = logger;
		}

		public void Migrate()
		{
			_logger.LogInfo("Migration started at " + DateTime.Now);
            // ...
            _logger.LogInfo("Migration finished at " + DateTime.Now);

        }
    }
}

