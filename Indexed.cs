using System.Collections.Generic;

namespace Snap.Data.Primitive
{
    public class Indexed<TIndex, TListElement>
    {
        public Indexed(TIndex index, IEnumerable<TListElement> list)
        {
            Index = index;
            List = list;
        }

        public TIndex Index { get; set; }
        public IEnumerable<TListElement> List { get; set; }
    }
}
