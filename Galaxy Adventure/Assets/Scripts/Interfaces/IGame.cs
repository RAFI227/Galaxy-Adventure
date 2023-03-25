using System;

namespace Interfaces
{
    public interface IGame
    {
        public event Action<object, double> GameTick;
    }
}