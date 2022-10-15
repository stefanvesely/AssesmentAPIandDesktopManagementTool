using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAdminApp.DockingForms;

namespace WinFormsAdminApp.UniveralClasses
{
    internal class LoadingClass
    {
        LoadingForm loading;
        public void ShowLoading()
        {
            loading = new LoadingForm();
            loading.BringToFront();
            loading.Show();
        }

        public void CloseLoading()
        {
            loading.Close();
        }
        
        
    }
}
