using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// This class is designed to perform a basic logging function.
    /// In the future, we might want to expand our logging capabilities. 
    /// 
    /// Currently, this class doesn't follow SOLID and would require too much modification to extext. 
    /// It violates the Open Close Principle. 
    /// 
    /// Please refactor this method and provide tests in Services.UnitTests.LoggerTests.LogShould.
    /// 
    /// 
    /// Hint:
    /// 
    /// public class ConsoleLogger : IMessageLogger {}
    /// public class QueueLogger : IMessageLogger {}
    /// </summary>
    // public class Logger
    // {
    //     public void Log(string message, LogType logType)
    //     {
    //          switch (logType)
    //          {
    //              case LogType.Console:
    //                  Console.WriteLine(message);
    //                  break;
    //  
    //              case LogType.Queue:
    //                  // Code to send message to printer
    //                  break;
    //          }
    //      }
    //  }


    //   public enum LogType
    //  {
    //      Console,
    //      Queue
    //  }

    
    // “public class Logger” has two issues which doesn’t comply with principles and best practices:
    //        1. Adding new LogType needs to modify LogType enum.
    //        2. Adding new LogType needs also needs to modify “log” method and switch case to handle
    //           logging based on newly added LogType.
    
    
    // For addressing this issues some changes are needed:
    //        1. Instead of using enum for LogType, we can use “ILogType” as an interface which every logger
    //             type should implement it. ILogType will be used as variable for log method. So in the case of
    //             adding any new LogType, as long as new LogType implements “ILogType”, “Logger” class and
    //             “log” method doesn’t need to change:
    
    
    public interface ILogType
        {
            void Log(string message);
        }
    
    
    public class ConsoleLogType : ILogType
        {
            public void Log(string message)
                {     
                    Console.WriteLine(message);
                }
        }
        
    
    public class QueueLogType : ILogType
        {
            public void Log(string message)
                {
                    // Code to send message to printer
                }
        }
    
    
      //      2. “Logger” class and its “Log” method should change to rely on “ILogType” interface. So the class
      //          needs a constructor to inject interface to class: 
        
    public class Logger
        {
            ILogType logType;
            public Logger(ILogType iLogType)
                {
                    logType = iLogType;
                }
        
            public void Log(string message)
                {
                    logType.Log(message);
                }
        }
    
}
    
    
    
    
