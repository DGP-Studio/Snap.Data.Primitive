namespace Snap.Data.Primitive
{
    /// <summary>
    /// 包装两个相同类型的对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Two<T>
    {
        public Two(T first, T second)
        {
            this.First = first;
            this.Second = second;
        }

        /// <summary>
        /// 第一个对象
        /// </summary>
        public T First { get; init; }
        /// <summary>
        /// 第二个对象
        /// </summary>
        public T Second { get; init; }
    }
}
