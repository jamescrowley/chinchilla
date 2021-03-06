using System;

namespace Chinchilla
{
    /// <summary>
    /// A subscription is a handle to a subscribed action
    /// </summary>
    public interface ISubscription : IDisposable
    {
        /// <summary>
        /// The name of this subscription
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The queues that are being subscribed to by this subscription
        /// </summary>
        IDeliveryQueue[] Queues { get; }

        /// <summary>
        /// Indicates whether or not this subscription can be started
        /// </summary>
        bool IsStartable { get; }

        /// <summary>
        /// Indicates whether or not this subscription has been started
        /// </summary>
        bool IsStarted { get; }

        /// <summary>
        /// Gets the current subscription state
        /// </summary>
        SubscriptionState State { get; }

        /// <summary>
        /// Gets a workers controller for this subscription
        /// </summary>
        IWorkersController Workers { get; }

        /// <summary>
        /// Starts the subscription
        /// </summary>
        void Start();
    }
}