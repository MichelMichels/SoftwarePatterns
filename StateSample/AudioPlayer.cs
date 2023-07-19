using StateSample.States;

namespace StateSample;
public class AudioPlayer
{
    private State state;

    public AudioPlayer()
    {
        state = new ReadyState(this);
    }

    public bool IsPlaying { get; set; }

    public void ChangeState(State state)
    {
        this.state = state;
        Console.WriteLine($"State changed to {state.GetType().Name}.");
    }

    public void ClickLock() => state.ClickLock();
    public void ClickPlay() => state.ClickPlay();
    public void ClickNext() => state.ClickNext();
    public void ClickPrevious() => state.ClickPrevious();

    public void StartPlayback()
    {
        IsPlaying = true;
    }

    public void StopPlayback()
    {
        IsPlaying = false;
    }
    public void NextSong()
    {

    }
    public void PreviousSong()
    {

    }
    public void FastForward(int seconds)
    {

    }
    public void Rewind(int seconds)
    {

    }
}
