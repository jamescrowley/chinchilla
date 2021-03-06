using System;

namespace Chinchilla.Topologies.Model
{
    public interface IQueue : IBindable
    {
        Durability Durability { get; set; }

        bool IsAutoDelete { get; set; }

        bool IsExclusive { get; set; }

        TimeSpan? MessageTimeToLive { get; set; }

        TimeSpan? QueueAutoExpire { get; set; }

        string DeadLetterExchange { get; set; }
    }
}