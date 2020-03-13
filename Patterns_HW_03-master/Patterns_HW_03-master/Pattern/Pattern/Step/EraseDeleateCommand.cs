using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Step
{
    public class EraseDeleateCommand
    {
        public ViewModel ViewModel { get; set; }
        public DelegateCommand Command { get; set; }
        public EraseDeleateCommand()
        {
            this.Command = new DelegateCommand(ExecuteErase, CanErase);
        }
        public void ExecuteErase(object unused)
        {
            this.ViewModel.Address = string.Empty;
            this.ViewModel.Day = 1;
            this.ViewModel.Month = 1;
            this.ViewModel.Year = 1990;
            this.ViewModel.IsMale = true;
            this.ViewModel.Name = string.Empty;
            this.ViewModel.Email = "user@example.com";
            this.ViewModel.PhoneNumber = "000-00-00";
        }
        public bool CanErase(object unused)
        {
            return true;
        }
    }
}
