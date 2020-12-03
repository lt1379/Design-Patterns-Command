using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Command
{
    public interface ICommand
    {
        void ExecuteAction();
        void UndoAction();
    }
}
