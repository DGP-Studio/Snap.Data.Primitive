using System.Collections.Generic;

namespace Snap.Data.Primitive
{
    public class IndexedListWrapper<T>
    {
        public IndexedListWrapper(int index, IEnumerable<T> list)
        {
            Index = index;
            List = list;
        }

        public int Index { get; set; }
        public IEnumerable<T> List { get; set; }
    }

    public class IndexedListWrapper<TIndex, T>
    {
        public IndexedListWrapper(TIndex index, IEnumerable<T> list)
        {
            Index = index;
            List = list;
        }

        public TIndex Index { get; set; }
        public IEnumerable<T> List { get; set; }
    }
}
