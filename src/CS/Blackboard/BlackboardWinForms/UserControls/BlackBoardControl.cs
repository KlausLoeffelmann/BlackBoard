using BlackBoard.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace BlackboardWinForms
{
    public partial class BlackBoardControl : UserControl
    {
        public event EventHandler? BlackBoardChanged;

        private ObservableCollection<Entry>? _blackboardEntries;

        public BlackBoardControl()
        {
            InitializeComponent();
        }

        public ObservableCollection<Entry>? BlackboardEntries
        { 
            get => _blackboardEntries;
            set
            {
                if (value != _blackboardEntries)
                {
                    _blackboardEntries = value;
                    OnBlackboardEntriesChanged();
                }
            }
        }

        public void OnBlackboardEntriesChanged()
        {
            BlackBoardChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
