using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary.EventArguments;

namespace FunctionLibrary.Interfaces
{
    public interface IDisplaySubscriptionService
    {
        void Subscribe(EventHandler<DisplayArgs> eventHandler);

        void Unsubscribe(EventHandler<DisplayArgs> eventHandler);
    }
}
