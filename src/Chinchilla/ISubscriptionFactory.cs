using System;
using RabbitMQ.Client;

namespace Chinchilla
{
    public interface ISubscriptionFactory
    {
        ISubscription Create<TMessage>(
            IModel model,
            ISubscriptionConfiguration configuration,
            Action<TMessage> processor);
    }
}