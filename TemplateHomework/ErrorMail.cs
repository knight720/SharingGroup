using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHomework
{
    public class ErrorMail : TemplateMail
    {

        public ErrorMail(string title, string receiver, bool noticeSupervisor = false)
        {
            _title = title;
            _receiver = receiver;
            _noticeSupervisor = noticeSupervisor;
        }

        protected override void AddReceiverSupervisor()
        {
            _receiver += "xxx@gmail.com;";
            Console.WriteLine("收件人:" + _receiver);
        }

        protected override void MakeMailBody()
        {
            Console.WriteLine("開始寫信 - 內容");
            this._body = "這是一封警告信";
            Console.WriteLine("信件內容:" + this._body);
        }

    }
}
