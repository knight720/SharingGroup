using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================通知信============================");
            NotifyMail notifyMail = new NotifyMail("通知信","peterji@gmail.com;");
            notifyMail.SendProcess();
            notifyMail.Send();

            Console.WriteLine("========================警告信============================");
            ErrorMail errorMail = new ErrorMail("警告信", "peterji@gmail.com;");
            errorMail.SendProcess();

            Console.WriteLine("========================警告信============================");
            ErrorMail errorMail2 = new ErrorMail("警告信", "peterji@gmail.com;", true);
            errorMail2.SendProcess();
            Console.ReadLine();
        }
    }
}
