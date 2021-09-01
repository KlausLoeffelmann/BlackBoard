using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace BlackboardWinForms
{
    public partial class BlackBoardControl : UserControl
    {
        private ObservableCollection<BlackBoardEntry> _blackboardEntries;

        public BlackBoardControl()
        {
            InitializeComponent();
            _blackboardEntries=new ObservableCollection<BlackBoardEntry>();
        }

        public ObservableCollection<BlackBoardEntry> BlackboardEntries
            => _blackboardEntries;

        public class BlackBoardEntry
        {
            public BlackBoardEntry(string entry, string entryFrom)
            {
                Entry = entry;
                EntryFrom = entryFrom;
                EntryDate = DateTimeOffset.Now;
            }

            public BlackBoardEntry(string entry, string entryFrom, DateTimeOffset entryDate)
            {
                Entry = entry;
                EntryFrom = entryFrom;
                EntryDate = entryDate;
            }

            public string Entry { get; set; }
            public DateTimeOffset EntryDate { get; set; }
            public string EntryFrom { get; set; }
        }
    }
}
