using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS11_NguyenTac_SOLID.DependencyInversion
{
    public class Notification
    {
        private IMessenger iMessenger;
        public Notification(){


        public void PromotionNotification(IMessenger messenger){
          messenger.SendMessenger();
        }
    }

        public IMessenger IMessenger {
            private get;
            set{
                iMessenger=value;
            }
         }
    }