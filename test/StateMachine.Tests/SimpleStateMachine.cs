using StateMachine;

namespace StateMachine.Tests;

internal class SimpleStateMachineState : State<SimpleStateMachine>
{
    public SimpleStateMachineState(SimpleStateMachine stateMachine) : base(stateMachine)
    {
    }
}

internal class SimpleStateMachine : StateMachine<SimpleStateMachineState>
{
    public SimpleStateMachine(SimpleStateMachineState initialState) : base(initialState)
    {
    }
}