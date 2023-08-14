using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Tables
{
    public interface IFileStorage
    {
        void CreateFile(string UserName, string Email, string PassWord);

    }
}
