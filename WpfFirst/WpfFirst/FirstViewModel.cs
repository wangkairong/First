using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfFirst
{
    class FirstViewModel
    {
        public DelegateCommand CopyCmd { get; set; }
        public InfoModel model { get; set; }

        public FirstViewModel()
        {
            this.model = new InfoModel();
            this.CopyCmd = new DelegateCommand();
            this.CopyCmd.ExecuteCommand = new Action<object>(this.model.Copy);
        }
    }
}
