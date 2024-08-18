using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ErrorOr
{
    public readonly record struct Error
    {
        public string Code { get;  }
        public string Discription { get;  }
        public ErrorType Type { get;  }

        private Error(string code, string discription, ErrorType type)
        {
            Code = code;
            Discription = discription;
            Type = type;
        }
        public static Error Unexpected(string code = "10", string discription = "Unexpected error")
            => new Error(code, discription, ErrorType.Unexpected);

        public static Error Failure(string code = "20", string discription = "Unexpected error")
            => new Error(code, discription, ErrorType.Failure);
    }

    public enum ErrorType
    {
        Failure,
        Unexpected,
        Error,
        BadValue
    }
}
