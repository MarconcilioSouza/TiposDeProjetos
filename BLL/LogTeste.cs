using Infrastructure.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LogTeste : ServiceBase
    {
        public void Logs()
        {
            Log.Information("Teste werwerewrwerewrwer");

            LoggerExtensions.Information(Log, "Teste sdargverhtfgh");
        }
    }
}
