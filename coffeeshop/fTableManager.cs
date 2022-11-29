using coffeeshop.Controller;
using coffeeshop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
            LoadCategory();
            LoadFood();
        }
        #region Method
        void LoadTable()
        {
            var table = new Table();
            List<Table> tables = TableController.Instance.LoadTableController();
            foreach(Table elm in tables)
            {
                Button button = new Button() { Width = TableController.TableWidth, Height = TableController.TableHeight};
                button.Text = elm.Id.ToString() + Environment.NewLine + elm.Status.ToString();
                button.Click += button_Click;
                button.Tag = elm; 

                switch (elm.Status)
                {
                    case "dispo":
                        button.BackColor = Color.Aqua;
                        break;
                    default:
                        button.BackColor = Color.LightPink;
                        break;
                }

                flpShowTable.Controls.Add(button);
            }
        }

        void LoadCategory()
        {
            var category = new Category();
            List<Category> categories = CategoryController.Instance.LoadCategory();

            foreach(Category elm in categories)
            {
                cbCategory.Items.Add(elm.CategoryName);
            }
        }

        void LoadFood()
        {
            var food = new Food();
            List<Food> foods = FoodController.Instance.LoadFood();

            foreach(Food elm in foods)
            {
                cbFood.Items.Add(elm.FoodName);
            }
        }

        void ShowBill(int Id)
        {
            lvBill.Items.Clear();
            tbTotalPrice.Text = "0";
            // GET TABLE ID
            if (TableController.Instance.CheckTableDispo(Id))
            {

                // GET BILL ID
                int BillId = BillController.Instance.GetUncheckBillByTableId(Id);

                //  GET LIST BILL INFO
                List<BillInfo> listBillInfo = BillInfoController.Instance.GetListBillInfo();

                //MenuByTableController.Instance.GetListMenuByTable(TableId);
                List<Food> ListFood = FoodController.Instance.LoadFood();

                var Sum = 0;
                foreach (BillInfo item in listBillInfo)
                {
                    //GET BILL INFO WITH BILL ID
                    if (BillId == item.IdBill)
                    {

                        foreach (Food elm in ListFood)
                        {
                            if (item.IdFood == elm.IdFood)
                            {
                                var TotalPrice = (int)elm.Price * (int)item.Count;
                                Sum += TotalPrice;

                                ListViewItem lvItem = new ListViewItem(elm.FoodName.ToString());
                                lvItem.SubItems.Add(item.Count.ToString());
                                lvItem.SubItems.Add(elm.Price.ToString());
                                lvItem.SubItems.Add(TotalPrice.ToString());

                                lvBill.Items.Add(lvItem);


                            }
                        }
                        CultureInfo culture = new CultureIndfo("fr-FR");
                        //thread.CurrentThread.CurrentCulture = culture;

                        tbTotalPrice.Text = Sum.ToString("c",culture);
                    }

                }
            }

        }
        #endregion

        private void button_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as Table).Id;
            ShowBill(tableId);
        }
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
