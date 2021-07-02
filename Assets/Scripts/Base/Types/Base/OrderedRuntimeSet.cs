using System.Collections.Generic;
using UnityEngine;

namespace Base.Types.Base
{
    public abstract class OrderedRuntimeSet<TKey, TValue> : ScriptableObject
    {
        public SortedList<TKey, TValue> items = new SortedList<TKey, TValue>();

        protected abstract TKey GetOrder(TValue item);

        public void Add(TValue item)
        {
            var key = GetOrder(item);

            if (!items.ContainsKey(key))
                items.Add(key, item);
        }

        public void Remove(TValue item)
        {
            var key = GetOrder(item);

            if (items.ContainsKey(key))
                items.Remove(key);
        }
    }
}