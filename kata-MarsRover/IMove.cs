namespace kata_MarsRover
{
    public interface IMove
    {
        Location Forward();
        Location Backward();

        Location Left();

        Location Right();
    }
}