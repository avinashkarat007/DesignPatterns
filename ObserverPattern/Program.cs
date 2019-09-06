using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern
{
    class Program
    {
        /*
        
            The Observer Pattern defines a one-to-many
                dependency between objects so that when one
                object changes state, all of its dependents are
                notified and updated automatically. 
             
            This is a BEHAVIOURAL pattern.
        */
        static void Main(string[] args)
        {
            YoutubeChannel channel = new YoutubeChannel();   // created new channel.

            ISubscriber Joey = new User();
            ISubscriber Harry = new User();
            ISubscriber Mathew = new Moderator();


            channel.Subscribe(Joey);
            channel.Subscribe(Harry);
            channel.Subscribe(Mathew);

            channel.NotifySubscribers();

            Console.WriteLine(" ");
            channel.UnSubscribe(Joey);

            channel.NotifySubscribers();

            Console.ReadLine();
        }
    }
}
