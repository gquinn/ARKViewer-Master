﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkSavegameToolkitNet.Types;

namespace ArkSavegameToolkitNet
{
    public class ArkNameCollectionComparer : IEqualityComparer<IList<Types.ArkName>>
    {
        public bool Equals(IList<ArkName> x, IList<ArkName> y)
        {
            if (x == null && y == null) return true;
            else if (x == null) return false;
            else if (y == null) return false;
            else if (x.Count != y.Count) return false;

            for(var i = 0; i < x.Count; i++)
            {
                if (!x[i].Equals(y[i])) return false;
            }

            return true;
        }

        public int GetHashCode(IList<ArkName> obj)
        {
            const int seed = 1;
            const int modifier = 31;

            unchecked
            {
                return obj.Aggregate(seed, (current, item) =>
                    (current * modifier) + item.GetHashCode());
            }
        }
    }
}
