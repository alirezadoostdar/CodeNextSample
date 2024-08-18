using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorOr
{
    public readonly record struct ErrorOr<TValue>
    {
        private readonly TValue? _value = default;
        private readonly List<Error>? _error = null;
        public bool IsError
            => _error is not null;

        public TValue Value
        {
            get
            {
                return _value;
            }
        }

        private ErrorOr(Error error)
        {
            _error = [error];
        }
        private ErrorOr(TValue value)
        {
            _value = value;
        }
        public static implicit operator ErrorOr<TValue>(TValue value)
        {
            return new ErrorOr<TValue>(value);
        }

        public static implicit operator ErrorOr<TValue>(Error error)
        {
            return new ErrorOr<TValue>(error);
        }
    }
}
