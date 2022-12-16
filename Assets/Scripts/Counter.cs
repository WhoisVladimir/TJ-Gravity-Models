using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Counter : IInitializable<ITicker>, ITicker
{
    public event Action Tick;

    private bool isCounted;
    private List<ITicker> countUpdaters;
    private CancellationTokenSource tokenSource;

    public Counter(DataStorage storage, string name)
    {
        isCounted = false;
        countUpdaters = new List<ITicker>();

        RegisterCounter(storage, name);
        tokenSource = new CancellationTokenSource();
    }

    public void InitializeCounter(ITicker ticker)
    {
        ticker.Tick += OnUpdate;
        countUpdaters.Add(ticker);
    }

    private void RegisterCounter(DataStorage storage, string counterName)
    {
        var hashName = counterName.GetHashCode();
        storage.Tickers.Add(hashName, this);
    }

    private async void OnUpdate()
    {
        if (!isCounted)
        {
            isCounted = true;
            Tick?.Invoke();
            await Task.Delay(100, tokenSource.Token);
            isCounted = false;
        }
    }
}
