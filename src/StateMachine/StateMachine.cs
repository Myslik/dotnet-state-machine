namespace StateMachine;
public abstract class StateMachine<TState>
{
    public TState State { get; }

    protected StateMachine(TState initialState)
    {
        State = initialState;
    }
}