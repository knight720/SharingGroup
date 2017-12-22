using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHomework
{
    public class NotifyMail
    {
        private string _receiver;
        private string _title;
        private string _body;
        private bool _noticeSupervisor;

        public NotifyMail(string title, string receiver)
        {
            _title = title;
            _receiver = receiver;
        }

        public void MakeMailTitle()
        {
            Console.WriteLine("標題:" + _title);
        }

        public void MakeMailReceiver()
        {
            Console.WriteLine("收件人:" + _receiver);
        }

        public void MakeMailBody()
        {
            Console.WriteLine("開始寫信 - 內容");
            this._body = "這是一封通知信";
            Console.WriteLine("信件內容:" + this._body);
        }

        public void Send()
        {
            Console.WriteLine("寄信完成");
        }
    }
}
