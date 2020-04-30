using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeProject.Library
{
    public enum Result { OK, Fail };
    public class OperationResult
    {
        public Result Result;
        public string Message;
        public OperationResult(Result result, string message)
        {
            Result = result;
            Message = message;
        }
    }
}
