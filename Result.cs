using System.Diagnostics.CodeAnalysis;

namespace Snap.Data.Primitive
{
    public record Result<TResult, TValue>
    {
        public Result(TResult isOk, TValue value)
        {
            IsOk = isOk;
            Value = value;
        }

        [MemberNotNullWhen(true, nameof(Value))]
        public TResult IsOk { get; }
        public TValue Value { get; }

        public void Deconstruct(out TResult isOk, out TValue value)
        {
            isOk = IsOk;
            value = Value;
        }
    }

    public record Result<TValue>:Result<bool,TValue>
    {
        public Result(bool isOk, TValue okValue, TValue notOkValue) : base(isOk, isOk ? okValue : notOkValue)
        {

        }
    }
}
