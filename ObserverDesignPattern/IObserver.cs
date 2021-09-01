using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
   public interface IObserver
    {
        void update(string availability);
    }
}
