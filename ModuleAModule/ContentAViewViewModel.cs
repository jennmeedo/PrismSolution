using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismDemo.Infrastructure;

namespace ModuleAModule
{
    public class ContentAViewViewModel : IContentAViewViewModel
    {
        public IView View { get; set; }

        public ContentAViewViewModel( IContentAView view)
        {
            View = view;
            View.ViewModel = this;
        }
    }
}
