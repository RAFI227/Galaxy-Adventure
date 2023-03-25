using View;

namespace Service
{
    public abstract class Factory
    {
        public abstract Ship CreateShip(Side side);
    }
}
