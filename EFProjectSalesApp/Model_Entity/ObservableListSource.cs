using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjectSalesApp.Model_Entity
{
    class ObservableListSource<T> : ObservableCollection<T>, IListSource where T : BaseModel
    {
        //specific to Windows Forms
        private IBindingList _bindingList;        

        public bool ContainsListCollection => throw new NotImplementedException();  //slightly different from code in video

        public IList GetList()
        {
            throw new NotImplementedException();
        }

        bool IListSource.ContainsListCollection { get { return false; } }

        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}
