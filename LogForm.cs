using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeMaiFaci
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        public ListView LogItemsListView
        {
            get
            {
                return lvLog;
            }
        }

        public RichTextBox LogItemsRichTextBox
        {
            get
            {
                return rtLog;
            }
        }

        private void rtLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;
            if (key == '\u001b')
                Close();
        }
    }
}
