using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace LogicDeskAdmin.Forms.Bases
{
    public partial class ListaBase : MdiChildBase, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        int _marcados;
        protected BindingSource Bs;
        public int Count { get => Bs.Count; }
        public int Marcados
        {
            get => _marcados;
            set
            {
                if (_marcados != value)
                {
                    _marcados = value;
                    OnPropertyChanged();
                }
            }
        }
        public ListaBase()
        {
            Bs = new();
        }


        protected virtual void RefreshData() { }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Bs.ListChanged += (a, e) => {
                if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.Reset)
                    OnPropertyChanged("Count");
            };
            RefreshData();
        }

        
    }
}
