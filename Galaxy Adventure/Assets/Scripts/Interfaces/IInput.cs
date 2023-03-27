using System;

namespace Interfaces
{
    public interface IInput
    {
        public event Action<object, string> OnInput;
    }
}
