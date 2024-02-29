using System;


namespace interFaces
{

    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
            //Console.Read();

            // ./code/c_sharp/c_sharp_int_mosh/inter/interFaces/bin/Debug/net6.0/log.txt
            var fileMigrator = new DbMigrator(new FileLogger("log.txt"));
            fileMigrator.Migrate();

        }
    }

}