using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveable {
    public void Move(Vector3 direction, int speed = 1);
}
