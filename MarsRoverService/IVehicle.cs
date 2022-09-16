namespace MarsRoverService
{
    public interface IVehicle
    {

        public string GetCurrentPosition();
        public void PrintCurrentPosition();
        public void SpinLeft();
        public void SpinRight();
    }
}
