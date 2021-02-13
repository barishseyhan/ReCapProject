using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        private string carAdded;

        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public Result(string carAdded)
        {
            this.carAdded = carAdded;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
