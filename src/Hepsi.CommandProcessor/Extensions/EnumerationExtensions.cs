﻿using System;
using System.Collections.Generic;

namespace Hepsi.CommandProcessor.Extensions
{
    public static class EnumerationExtensions
    {
        public static void Each<T>(this IEnumerable<T> collection, Action<T> doThis)
        {
            foreach (var item in collection)
            {
                doThis(item);
            }
        }
    }
}
