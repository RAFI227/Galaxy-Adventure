using Interfaces;
using UnityEngine;

namespace ViewModel {
    class IShooterViewModel : MonoBehaviour {
        public IShooterViewModel Instance;
        public IShooterViewModel() {
            if (Instance == null)
                Instance = this;
            else
                Destroy(this);
        }

        public void Shoot(IShooter shooter) {
            shooter.Shoot();
        }
    }
}