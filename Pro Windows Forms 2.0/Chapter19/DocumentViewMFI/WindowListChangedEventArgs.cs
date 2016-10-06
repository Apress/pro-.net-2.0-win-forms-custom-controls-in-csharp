using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
    public class WindowListChangedEventArgs : EventArgs 
    {
        private Dictionary<Form, string> windowNames;
        public Dictionary<Form, string> WindowNames
        {
            get { return windowNames; }
        }

        public WindowListChangedEventArgs(Dictionary<Form, string> windowNames)
        {
            this.windowNames = windowNames;
        }
    }
}
