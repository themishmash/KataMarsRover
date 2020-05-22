namespace kata_MarsRover
{
    public interface IMove
    {
        Position Forward();
        Position Backward();

        Position Left();

        Position Right();
    }
}