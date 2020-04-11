public abstract class State
{
    protected abstract void Enter();
    protected abstract void Exit();
    public abstract void Update();
    public static State Transition(State from, State to)
    {
        from.Exit();
        to.Enter();
        return to;
    }
}
