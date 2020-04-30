using Models.UIModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMailService
    {

        bool SendMail(SendMailModel mail);
    }
}
