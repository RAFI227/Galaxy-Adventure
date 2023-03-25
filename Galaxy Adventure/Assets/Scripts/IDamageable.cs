using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public interface IDamageable {
    public void ApplyDamage(float damage);
}

public class IDamageableViewModel: MonoBehaviour {
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
