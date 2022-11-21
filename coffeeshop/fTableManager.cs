using coffeeshop.Controller;
using coffeeshop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop
{
    public partial class fTableManager : Form
    { 
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }
        #region Method
        void LoadTable()
        {
            var table = new Table();
            List<Table> tables = TableController.Instance.LoadTableController();
            foreach(Table elm in tables)
            {
                Button button = new Button();
                button.Text = elm.Id.ToString();

                flpShowTable.Controls.Add(button);
            }
        }
        #endregion
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        

    }
}
