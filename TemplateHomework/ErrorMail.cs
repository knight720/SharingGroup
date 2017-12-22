using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHomework
{
    public class ErrorMail
    {
        private string _receiver;
        private string _title;
        private string _body;
        private bool _noticeSupervisor;

        public ErrorMail(string title, string receiver, bool noticeSupervisor = false)
        {
            _title = title;
            _receiver = receiver;
            _noticeSupervisor = noticeSupervisor;
        }

        private void MakeMailTitle()
        {
            Console.WriteLine("標題:" + _title);
        }

        private void MakeMailReceiver()
        {
            Console.WriteLine("收件人:" + _receiver);
        }

        private void AddReceiverSupervisor()
        {
            _receiver += "xxx@gmail.com;";
            Console.WriteLine("收件人:" + _receiver);
        }

        private void MakeMailBody()
        {
            Console.WriteLine("開始寫信 - 內容");
            this._body = "這是一封警告信";
            Console.WriteLine("信件內容:" + this._body);
        }

        private void Send()
        {
            Console.WriteLine("寄信完成");
        }

        public void SendProcess()
        {
            this.MakeMailTitle();
            this.MakeMailReceiver();
            if (this._noticeSupervisor)
            {
                this.AddReceiverSupervisor();
            }

            this.MakeMailBody();
        }
    }
}
