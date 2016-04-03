using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSearchCombobox
{
    class MainWindowVM: INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            mNames.AddRange(Data.Names);
        }

        public IEnumerable<string> Names
        {
            get { return mNames; }
        }
        List<string> mNames = new List<string>();

        public string CB1SelectedItem
        {
            get { return mCB1SelectedItem; }
            set
            {

                mCB1SelectedItem = value;
                TaskPaneText = string.Format("Selected Item: {0}", mCB1SelectedItem);
                OnPropertyChanged("CB1SelectedItem");
            }
        }
        string mCB1SelectedItem;

        public string CB2SelectedItem
        {
            get { return mCB2SelectedItem; }
            set
            {

                mCB2SelectedItem = value;
                TaskPaneText = string.Format("Selected Item: {0}", mCB2SelectedItem);
                OnPropertyChanged("CB1SelectedItem");
            }
        }
        string mCB2SelectedItem;

        public string TaskPaneText
        {
            get { return mTaskPaneText; }
            set
            {
                mTaskPaneText = value;
                OnPropertyChanged("TaskPaneText");
            }
        }
        string mTaskPaneText;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string value)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(value));
            }
        }
    }
}
