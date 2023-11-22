using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTac5
{
    internal class Notification
    {
        IMessager myMessager;
        public IMessager MyMessager
        {
            get; set;
        }

        public Notification()
        {

        }

        public void CallNotification(IMessager messager)
        {
            messager.SendMessager();
        }
    }
}
