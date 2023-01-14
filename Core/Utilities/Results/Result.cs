using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //constructor'ların bir kullanım yapısı. aynı kodu tekrar yazmamak için birbirleriyle bağlantılı halde yazılabilir.
        //:this -- buradaki sınıfa atıfta bulunur ve şöyle okunmalıdır. bu sınıftaki tek parametreli olan constructor'a atıf eder.
        //message'ı ayrı success'i ayrı şekilde çalışabilmesine imkan tanır.
       
        public Result(bool success, string message):this(success)
        {
            Message = message;
            
        }
        public Result(bool success)
        {
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
