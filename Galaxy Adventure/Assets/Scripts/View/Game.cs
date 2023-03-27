using System;
using UnityEngine;
using ViewModel;
using Interfaces;

namespace View
{
    class Game : MonoBehaviour, IGame
    {
        public event Action<object, double> GameTick;
        void Awake()
        {
            new GameLoop(this);
        }
        void Update()
        {
            GameTick(this, Time.deltaTime);
        }
    }
}