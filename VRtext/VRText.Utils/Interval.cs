using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VRText.Utils
{
    public class Interval
    {
        public System.Timers.Timer Set(System.Action action, int interval)
        {
            var timer = new System.Timers.Timer(interval);
            timer.Elapsed += (s, e) => {
                timer.Enabled = false;
                action();
                timer.Enabled = true;
            };
            timer.Enabled = true;
            return timer;
        }

        public void Stop(System.Timers.Timer timer)
        {
            if (timer == null)
            {
                return;
            }

            timer.Stop();
            timer.Dispose();
        }

        public void setTimeout(Action TheAction, int Timeout)
        {
            Thread t = new Thread(
                () =>
                {
                    Thread.Sleep(Timeout);
                    TheAction.Invoke();
                }
            );
            t.Start();
        }
    }
}
