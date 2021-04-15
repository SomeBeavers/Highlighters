using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Core
{
    public partial class Form1 : Form
    {
        private object _clickMe;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name =;
            this._clickMe = ClickMe_1;
            var s = "";
        }

        public object ClickMe_1 { get; set; }
    }
}
