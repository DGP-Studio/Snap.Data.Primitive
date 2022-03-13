namespace Snap.Data.Primitive
{
    public interface ICloneable<T>
    {
        /// <summary>
        /// 返回一个克隆的新对象
        /// </summary>
        /// <returns></returns>
        T Clone();
    }
}
