using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHomework
{
    public abstract class TemplateMail
    {
        protected string _receiver;
        protected string _title;
        protected string _body;
        protected bool _noticeSupervisor;

        public TemplateMail(string title, string receiver, bool noticeSupervisor = false)
        {
            _title = title;
            _receiver = receiver;
            _noticeSupervisor = noticeSupervisor;
        }

        public void MakeMailTitle()
        {
            Console.WriteLine("標題:" + _title);
        }

        public void MakeMailReceiver()
        {
            Console.WriteLine("收件人:" + _receiver);
        }

        public void Send()
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

        protected abstract void MakeMailBody();
        protected abstract void AddReceiverSupervisor();
    }
}
