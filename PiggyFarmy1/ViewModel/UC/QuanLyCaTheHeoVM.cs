using PiggyFarmy1.Model.DataBase;
using PiggyFarmy1.Model.DataBase.Entity;
using PiggyFarmy1.Others;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyFarmy1.ViewModel.UC
{
    public class QuanLyCaTheHeoVM : BaseViewModel
    {
        public ObservableCollection<HEO> ListHeo { get; set; }

        public QuanLyCaTheHeoVM()
        {
            
            
        }
    }
}
