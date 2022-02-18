namespace Snap.Data.Primitive
{
    /// <summary>
    /// 封装带有名称描述的值
    /// 在绑定枚举变量时非常有用
    /// </summary>
    /// <typeparam name="T">包含值的类型</typeparam>
    public record NamedValue<T>
    {
        public NamedValue(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public T Value { get; }
    }
}
