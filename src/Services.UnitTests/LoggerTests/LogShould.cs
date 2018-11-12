using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Services.UnitTests.LoggerTests
{
    public class LogShould
    {
        private readonly ILogType LogType;
        private readonly Logger logger;
        
        public LogShould()
        {
            LogType = new Mock<ConsoleLogType>();
            logger = new Logger(LogType);
        }
        
        [Fact]
        public void Call_Log_with_message()
        {
            logger.Log("hello world");           
        }
    }
}
