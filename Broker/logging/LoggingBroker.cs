using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CRUD.Broker.logging
{
    internal class LoggingBroker : ILoggingBroker
    {
        public void LogError(string UserMessage)=>
            Console.WriteLine(UserMessage);

        public void LogInformation(string message)=>
            Console.WriteLine(message);
        
    }
}
