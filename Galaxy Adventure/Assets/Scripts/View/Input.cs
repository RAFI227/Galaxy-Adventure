using Interfaces;
using System;
using UnityEngine;
using ViewModel;

namespace View
{
    public class InputView : MonoBehaviour, IInput
    {
        public event Action<object, string> OnInput;

        void Awake()
        {
            new InputViewModel(this);
        }

        private void Update()
        {
            if (Input.anyKey)
            {
                OnInput(this, Input.inputString);
            }
        }
    }
}