using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid01_SingleResponsibility.Before
{
    public class Customer
    {
        void Login(string username, string password)
        {
            //Login işlemleri için ilgili kodlar.
        }

        void Register(string username, string password, string email)
        {
            //Register işlemleri
        }

        void SendMail(string text)
        {
            //Öail gönderme ile ilgili işlemler.
        }
    }
}
