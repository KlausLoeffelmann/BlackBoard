using BlackBoard.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms.Data;

namespace BlackboardWinForms.UserControls
{
    public class ObservableEntriesAdapter
    {
        public BindingList<Entry>? Entries { get; set; }
    }
}
