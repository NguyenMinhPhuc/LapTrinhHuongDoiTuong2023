using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_NguyenTacSOLID.NguyenTac05_ThongThong
{
    internal class Notification
    {
        IMessages messages;
        public IMessages Messages
        {
            //get { return messages; } 
            set { messages = value; }
        }
        public Notification() { }
        public Notification(IMessages messages)
        {
            this.messages = messages;
        }

        public void GoiPhuongThucGuiThongBao(IMessages _messages)
        {
            _messages.SendMessage("phuc@lhu.edu.vn", "Test");
        }
    }
}
