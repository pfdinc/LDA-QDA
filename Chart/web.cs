using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart
{
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
        }
        private void web_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://www.microsoft.com");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
      
        }
    }
}
