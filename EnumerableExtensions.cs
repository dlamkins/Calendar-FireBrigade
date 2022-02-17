using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarFireBrigade {
    public static class EnumerableExtensions {

        public static X MinOrDefault<T, X>(this IEnumerable<T> that, Func<T, X> minXp, X defaultValue) {
            return that.Any()
                       ? that.Min(minXp)
                       : defaultValue;
        }

    }
}
