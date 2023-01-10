//using Solıd06_DependencyInversion.Before;
using Solıd06_DependencyInversion.After;

namespace Solıd06_DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before

            //MailService mailService = new MailService();
            //mailService.SendMail(new GmailServer());

            #endregion

            #region After

            MailService mailService= new MailService();
            mailService.SendMail(new GmailServer(), "engin@gmail.com", "selam;" +
                "selam");
            mailService.SendMail(new HotmailServer(),"eginnazi@omtilmia.com","selammmmmmmmmm");


            #endregion
        }
    }
}