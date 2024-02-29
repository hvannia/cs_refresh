using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inter
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // inheritance basics 
            var text = new Text();
            text.Width = 100;
            text.Copy();
            // end inheritance basics 

            // composition
            /*
             * BbMIgrator and Installer classes have a composition type relationship with Logger class,
             * they both use Logger. The related field (Logger) in the composite class is private. 
             */

            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
