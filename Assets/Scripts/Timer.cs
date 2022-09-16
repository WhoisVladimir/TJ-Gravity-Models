using System;
using System.Threading;
using System.Threading.Tasks;

public class Timer : ITimer, ITicker
{
    public event Action Tick;
    private int milliseconds;
    private bool isTimerActive;
    private CancellationToken token;
    private CancellationTokenSource tokenSource;

    public Timer(int millisecondsTick)
    {
        milliseconds = millisecondsTick;
        tokenSource = new CancellationTokenSource();
    }
    ~Timer()
    {
        tokenSource.Cancel();
    }

    public async void StartTimer()
    {
        isTimerActive = true;
        token = tokenSource.Token;
        while (isTimerActive)
        {
            await Task.Delay(milliseconds, token);
            Tick?.Invoke();
        }
    }

    public void StopTimer()
    {
        tokenSource.Cancel();
        isTimerActive = false;
    }
}
