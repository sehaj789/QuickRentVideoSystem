using System;
using System.Windows.Forms;

namespace QuickRentVideoSystem
{
    public partial class CustomerForm : Form
    {
        int customerID;
        public CustomerForm(String type,int id,String name, String cnct, String add, String date)
        {
            InitializeComponent();
            nameTxt.Text = name;
            contactTxt.Text =cnct;
            addTxt.Text =add;
            joinPK.Text =date;
            enterBtn.Text = type;
            titleLbl.Text = type + " Customer";
            customerID = id;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text != "" && contactTxt.Text != "" && addTxt.Text != "")
            {
                if (enterBtn.Text == "Add")
                    SqlOperation.InsertData(nameTxt, contactTxt, addTxt, joinPK);
                else
                    SqlOperation.UpdateData(nameTxt, contactTxt, addTxt, joinPK, customerID.ToString());
            }
        }
    }
}