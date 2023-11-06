using PiggyFarmy1.Model.DataBase;
using PiggyFarmy1.Model.DataBase.Entity;
using PiggyFarmy1.Others;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PiggyFarmy1.ViewModel.UC
{
    public class QuanLyCaTheHeoVM : BaseViewModel
    {
        public ObservableCollection<HEO> ListHeo { get; set; }
        public List<string> ListLoaiHeo { get; set; }
        public List<string> ListThuocTinhTimKiem { get; set; }
        public string SelectedGioiTinh { get; set; }
        public string SelectedLoaiHeo { get; set; }
        public string SelectedGiongHeo { get; set; }
        public string SelectedTinhTrang {  get; set; }
        public string SelectedNguonGoc { get; set; }
        public bool isNgaySinhExpanded { get; set; }
        public bool isGioiTinhExpanded {  get; set; }
        public bool isTrongLuongExpanded { get; set; }
        public bool isLoaiHeoExpanded { get; set; }
        public bool isGiongHeoExpanded { get; set; }
        public bool isTinhTrangExpanded { get; set; }
        public bool isNguonGocExpanded { get; set; }    
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public int StartWeight { get; set; }    
        public int EndWeight { get; set; }
        public List<string> ListGiongHeo { get; set; }
        public ICommand FilterCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public QuanLyCaTheHeoVM()
        {
            ListHeo = new ObservableCollection<HEO>(DataProvider.Ins.DB.HEOs);
            ListLoaiHeo = new List<string>();
            var listLoaiHeo = DataProvider.Ins.DB.LOAIHEOs.ToList();
            foreach (var item in listLoaiHeo)
            {
                ListLoaiHeo.Add(item.TenLoaiHeo);
            }
            ListGiongHeo = new List<string>();
            var listGiongHeo = DataProvider.Ins.DB.GIONGHEOs.ToList();
            foreach (var item in listGiongHeo)
            {
                ListGiongHeo.Add(item.TenGiongHeo);
            }

            FilterCommand = new RelayCommand(p =>
            {
                ListHeo = new ObservableCollection<HEO>(DataProvider.Ins.DB.HEOs);
                if (isNgaySinhExpanded)
                {
                    if(StartDay > EndDay && StartDay != null && EndDay != null)
                    {
                        MessageBox.Show("Vui lòng chọn ngày kết thúc lớn hơn ngày bắt đầu");
                        return;
                    }
                    if(StartDay != null)
                    {
                        ListHeo = (ObservableCollection<HEO>)ListHeo.Where((q) => q.NgaySinh > StartDay);
                    }
                    if (EndDay != null)
                    {
                        ListHeo = (ObservableCollection<HEO>)ListHeo.Where((q) => q.NgaySinh < EndDay);
                    }
                }

                if (isGioiTinhExpanded)
                {
                    ListHeo = (ObservableCollection<HEO>)ListHeo.Where(q => q.GioiTinh.Equals(SelectedGioiTinh));
                }
                if (isTrongLuongExpanded)
                {
                    if (StartWeight > EndWeight )
                    {
                        MessageBox.Show("Vui lòng chọn mốc cân nặng lớn nhất lớn hơn mốc cân nặng nhỏ nhất");
                        return;
                    }
                    if (StartDay != null)
                    {
                        ListHeo = (ObservableCollection<HEO>)ListHeo.Where((q) => q.NgaySinh > StartDay);
                    }
                    if (EndDay != null)
                    {
                        ListHeo = (ObservableCollection<HEO>)ListHeo.Where((q) => q.NgaySinh < EndDay);
                    }
                }

            }, p => { return true; });

        }
    }
}
