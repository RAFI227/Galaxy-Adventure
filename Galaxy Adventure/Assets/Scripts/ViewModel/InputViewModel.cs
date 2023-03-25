using Interfaces;

namespace ViewModel
{
    class InputViewModel
    {
        public InputViewModel(IInput input)
        {
            input.OnInput += OnInput;
        }

        private void OnInput(object sender, string keyKode)
        {

        }
    }
}