namespace SimulationGasWFApp
{
    public class LocationEventArgs
    {
        public LocationSide LocationSide;

        public LocationEventArgs(LocationSide locationSide)
        {
            LocationSide = locationSide;
        }
    }
}