using View;

namespace Service
{
    public class ShipFactory : Factory
    {
        public override Ship CreateShip(Side side)
        {
            return new Ship(side);
        }
    }
}