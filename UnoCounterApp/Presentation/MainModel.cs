namespace UnoCounterApp.Presentation;

internal partial record MainModel
{ 
    public IState<Countable> Countable => State.Value(this, () => new Countable(0, 1));
    public ValueTask IncrementCounter() => Countable.UpdateAsync(c => c?.Increment());
    public ValueTask DecrementCounter() => Countable.UpdateAsync(c => c?.Decrement());

}

internal partial record Countable(int Count, int Step)
{
    public Countable Increment() => this with
    {
        Count = Count + Step
    };

    public Countable Decrement() => this with
    {
        Count = Count - Step
    };
}
