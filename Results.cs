namespace Snap.Data.Primitive
{
    public static class Results
    {
        public static Result<bool, T> Condition<T>(bool condition, T trueValue, T falseValue) where T : notnull
        {
            return new(condition, condition ? trueValue : falseValue);
        }
    }
}
