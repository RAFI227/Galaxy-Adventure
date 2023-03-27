using UnityEngine;

namespace View
{
    public class Ship : MonoBehaviour
    {
        public Ship(Side side)
        {
            Side = side;
        }

        public Side Side { get; private set; }
    }

    public enum Side
    {
        Good,
        Bad
    }
}