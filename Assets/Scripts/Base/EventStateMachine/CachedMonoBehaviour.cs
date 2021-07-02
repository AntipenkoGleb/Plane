﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Base.EventStateMachine
{
    public class CachedMonoBehaviour : MonoBehaviour
    {
        private readonly Dictionary<Type, Component> _cachedComponents = new Dictionary<Type, Component>();

        public new bool TryGetComponent<T>(out T component) where T : Component
        {
            var type = typeof(T);
            if (!_cachedComponents.TryGetValue(type, out var value))
            {
                if (base.TryGetComponent(out component))
                    _cachedComponents.Add(type, component);

                return component != null;
            }

            component = (T) value;
            return true;
        }
    }
}