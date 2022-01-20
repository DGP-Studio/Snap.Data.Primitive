using System;

namespace Snap.Data.Primitive
{
    /// <summary>
    /// 封装带有名称描述的值
    /// 在绑定枚举变量时非常有用
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NamedValue<T> : IEquatable<NamedValue<T>>
    {
        public NamedValue(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public T Value { get; set; }

        public bool Equals(NamedValue<T>? other)
        {
            return Name == other?.Name;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as NamedValue<T>);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
