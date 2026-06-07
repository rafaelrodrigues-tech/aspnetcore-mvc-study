using System;

namespace SalesWebMvc2.Services.Exceptions
{
    public class IntegretyException:ApplicationException
    {
        public IntegretyException(string message) : base(message)
        { 
        
        }
    }
}
