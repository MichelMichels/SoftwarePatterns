namespace StateSample.States;
public abstract class State : IState
{
    protected readonly AudioPlayer player;

    public State(AudioPlayer context)
    {
        this.player = context;
    }

    public abstract void ClickLock();
    public abstract void ClickNext();
    public abstract void ClickPlay();
    public abstract void ClickPrevious();
}
