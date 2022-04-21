namespace StateMachine;
public abstract class State<TStateMachine>
{
    protected State(TStateMachine stateMachine)
    {
        StateMachine = stateMachine;
    }

    protected TStateMachine StateMachine { get; }

    protected virtual void OnEntry() { }
}
