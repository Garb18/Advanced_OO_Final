using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary.EventArguments;

namespace FunctionLibrary.Interfaces
{
    /// <summary>
    /// Subscription service provider for Collection class
    /// 
    /// Author: Benedict Gardner
    /// </summary>
    public interface ICollectionSubscriptionService
    {
        void Subscribe(EventHandler<CollectionArgs> eventHandler);

        void Unsubscribe(EventHandler<CollectionArgs> eventHandler);
    }
}
