using System.Diagnostics.CodeAnalysis;

namespace Snap.Data.Primitive
{
    public record Result<TResult, TValue> where TResult : notnull where TValue : notnull
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
}
