namespace StateSample.States;
public class PlayingState : State
{
    public PlayingState(AudioPlayer player) : base(player) { }

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
        player.StopPlayback();
        player.ChangeState(new ReadyState(player));
    }
    public override void ClickPrevious()
    {
        player.PreviousSong();
    }

}
