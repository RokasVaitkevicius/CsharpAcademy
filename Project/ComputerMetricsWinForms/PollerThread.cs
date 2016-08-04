using System;
using System.Threading;

namespace ComputerMetricsWinForms
{
    public class PollerThread
    {
        private readonly Thread _thread;
        private readonly SynchronizationContext _syncContext;
        private volatile bool _shouldStop;

        public event EventHandler UpdateFinished;

        public PollerThread()
        {
            _syncContext = SynchronizationContext.Current;

            ThreadStart threadStart = ThreadStartMethod;
            _thread = new Thread(threadStart)
            {
                Name = "UpdateThread",
                IsBackground = true,
                Priority = ThreadPriority.Normal
            };
        }

        public void Start()
        {
            if ((_thread.ThreadState & ThreadState.Unstarted) == ThreadState.Unstarted)
                _thread.Start();
            else
                throw new Exception("Thread has already been started and may have completed already.");
        }

        public void ThreadStartMethod()
        {
            try
            {
                while (true)
                {
                    // Go get the new data from the SQL server  

                    OnUpdateFinished(); // Notify all subscribers (on their own threads)  
                    Thread.Sleep(1000); // 10 sec wait before the next update  
                }
            }
            catch (ThreadAbortException)
            {
                // The thread was aborted... ignore this exception if it's safe to do so  
            }
        }

        public void RestartThread()
        {
            _shouldStop = false;
            ThreadStartMethod();
        }

        public void ThreadStopMethod()
        {
            _shouldStop = true;

        }

        protected virtual void OnUpdateFinished()
        {
            if (UpdateFinished != null)
            {
                var method = new SendOrPostCallback(
                delegate
                {
                    UpdateFinished(this, EventArgs.Empty);
                });
                _syncContext.Send(method, null);
            }
        }
    }
}
