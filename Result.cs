namespace Snap.Data.Primitive
{
    /// <summary>
    /// 用于包装异步操作的结果
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public record Result<TResult, TValue> where TResult : notnull where TValue : notnull
    {
        public Result(TResult isOk, TValue value)
        {
            this.IsOk = isOk;
            this.Value = value;
        }

        public TResult IsOk { get; }
        public TValue Value { get; }

        /// <summary>
        /// 用于元组析构
        /// </summary>
        /// <param name="isOk"></param>
        /// <param name="value"></param>
        public void Deconstruct(out TResult isOk, out TValue value)
        {
            isOk = this.IsOk;
            value = this.Value;
        }
    }
}
