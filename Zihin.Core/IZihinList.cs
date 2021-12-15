using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zihin.Core
{
    public interface IZihinList<T> : IList<T>
    {
        void SetShared();
        void SetPrivate();
    }
}
