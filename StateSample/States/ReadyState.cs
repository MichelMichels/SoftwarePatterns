namespace StateSample.States;
public class ReadyState : State
{
    public ReadyState(AudioPlayer context) : base(context) { }

    public override void ClickLock()
    {
        player.ChangeState(new LockedState(player));
    }
    public override void ClickNext()
    {
        player.NextSong();
    }
    public override void ClickPlay()
    {
        player.StartPlayback();
        player.ChangeState(new PlayingState(player));
    }
    public override void ClickPrevious()
    {
        player.PreviousSong();
    }
}
