using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMoveableViewModel : MonoBehaviour {
    public static IMoveableViewModel Instance;
    public void Awake() {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    public void MoveObject(IMoveable moveable, Vector3 direction, int speed = 1) {
        moveable.Move(direction, speed);
    }
}
