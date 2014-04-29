using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homepage.MVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Homepage.MVC.Models.Tests
{
    [TestClass()]
    public class EmailTests
    {
        [TestMethod()]
        public void sendMailTest()
        {
            Email mail = new Email("asssunto", "mensagem de teste de envio de email","daniel@daniel.com");
            mail.sendMail();
        }
    }
}
