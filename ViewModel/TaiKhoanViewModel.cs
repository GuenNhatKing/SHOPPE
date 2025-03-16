using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoppe.Model.Entities;
using Shoppe.Model.Repositories;

namespace Shoppe.ViewModel
{
    public class TaiKhoanViewModel : INotifyPropertyChanged
    {
        private TaiKhoanRepository _repository;
        private List<TaiKhoan> _DSTaiKhoan;
        public List<TaiKhoan> DSTaiKhoan
        {
            get => _DSTaiKhoan;
            set
            {
                _DSTaiKhoan = value;
                OnPropertyChanged(nameof(DSTaiKhoan));
            }
        }
        public TaiKhoanViewModel()
        {
            _repository = new TaiKhoanRepository();
            DSTaiKhoan = _repository.LayDSTaiKhoan();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
