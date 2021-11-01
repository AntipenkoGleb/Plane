using System;

namespace Base.Types.Base
{
    [Serializable]
    public abstract class VariableReference<TValue, TVariable> where TVariable : Variable<TValue>
    {
        public bool useConstant = true;
        public TValue constantValue;
        public TVariable variable;

        protected VariableReference()
        {
        }

        protected VariableReference(TValue value)
        {
            useConstant = true;
            constantValue = value;
        }

        public TValue Value
        {
            get => useConstant ? constantValue : variable.runtimeValue;
            set
            {
                if (useConstant)
                    constantValue = value;
                else
                    variable.runtimeValue = value;
            }
        }

        public static implicit operator TValue(VariableReference<TValue, TVariable> reference)
        {
            return reference.Value;
        }
    }
}