using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlog_lab
{
    class NLog
    {
        private static Logger log = LogManager.GetCurrentClassLogger();

        public void StartProgram()
        {
            log.Info("Программа вроде работает...");
        }

        public void ErrorParse()
        {
            log.Error("Данные были введены неверно! (((");
        }

        public void StopProgram()
        {
            log.Info("Программа закончила пахать на тебя!");
        }

       
    }
}
