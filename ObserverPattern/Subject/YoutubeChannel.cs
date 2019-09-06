using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
    public class YoutubeChannel
    {
        private IList<ISubscriber> subscribers = new List<ISubscriber>();


        public void Subscribe(ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            this.subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Notify();
            }
        }
    }
}
