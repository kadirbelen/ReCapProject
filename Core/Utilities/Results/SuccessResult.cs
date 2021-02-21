using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message)
        {
            //iki parametreli olan çalışır
        }
        public SuccessResult():base(true)//base Result işaret eder.
        {
           // tek parametreli olan çalışır
        }
    }
}
