﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PizzaPlace.Shared
{
    public static class IEnumerableExtensions
    {
        public static bool Any(this IEnumerable enumerable) 
            => enumerable.GetEnumerator().MoveNext() == true;
    }
}
