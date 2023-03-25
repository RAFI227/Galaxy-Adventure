using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IShooter {
    public void Shoot();
}

class IShooterViewModel: MonoBehaviour {
    public IShooterViewModel Instance;
    public IShooterViewModel() {
        if(Instance == null)
            Instance = this;
        else 
            Destroy(this);
    }

    public void Shoot(IShooter shooter) {
        shooter.Shoot();
    }
}
