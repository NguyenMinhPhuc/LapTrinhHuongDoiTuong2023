using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_NguyenTacSOLID.NguyenTac05_ThongThong
{
    internal class Dung
    {
        Notification notification;
        public Dung()
        {
            notification = new Notification();
            notification.GoiPhuongThucGuiThongBao(new Email());
        }
    }
}
