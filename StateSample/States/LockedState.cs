namespace StateSample.States;
public class LockedState : State
{
    public LockedState(AudioPlayer context) : base(context) { }

    public override void ClickLock()
    {
        player.ChangeState(player.IsPlaying ? new PlayingState(player) : new ReadyState(player));
    }
    public override void ClickNext() { }
    public override void ClickPlay() { }
    public override void ClickPrevious() { }
}
