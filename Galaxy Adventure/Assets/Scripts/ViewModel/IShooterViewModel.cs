using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
