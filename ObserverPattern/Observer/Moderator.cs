using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class Moderator : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Moderators needs to review the video.");
        }
    }
}
