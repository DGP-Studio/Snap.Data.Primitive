using System.Collections.Generic;

namespace Snap.Data.Primitive
{
    public class Indexed<TIndex, TListElement>
    {
        public Indexed(TIndex index, IList<TListElement> list)
        {
            this.Index = index;
            this.List = list;
        }

        public TIndex Index { get; set; }
        public IList<TListElement> List { get; set; }
    }
}
