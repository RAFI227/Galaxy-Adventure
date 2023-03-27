using Interfaces;
using UnityEngine;


namespace ViewModel {
    public class IDamageableViewModel : MonoBehaviour {
        public IDamageableViewModel Instance;
        public IDamageableViewModel() {
            if (Instance == null)
                Instance = this;
            else
                Destroy(this);
        }

        public void ApplyDamage(IDamageable damageable, float damage) {
            damageable.ApplyDamage(damage);
        }
    }
}
