using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PiggyFarmy1.Others
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Hàm này được sử dụng để thông báo rằng một thuộc tính đã thay đổi
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Các phương thức để quản lý tài nguyên
        public virtual void Cleanup()
        {
            // Đảm bảo dọn dẹp tài nguyên khi cần thiết
        }
    }
}
