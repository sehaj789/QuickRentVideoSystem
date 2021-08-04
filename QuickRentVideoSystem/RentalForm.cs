using System;
using System.Windows.Forms;

namespace QuickRentVideoSystem
{
    public partial class RentalForm : Form
    {
        int bookingID, cost;

        public RentalForm(String type, int id, int cid, int vid, int price, String customer, String video, String startVal, String dueVal)
        {
            SqlOperation.LoadList();
            InitializeComponent();
            foreach (var a in SqlOperation.customerList)
                custCB.Items.Add(a);
            foreach (var a in SqlOperation.videoList)
                vidCB.Items.Add(a);
            bookingID = id;
            cost = price;
            enterBtn.Text = type;
            custCB.Tag = cid;
            vidCB.Tag = vid;
            startDatePK.Text = startVal;
            endDatePK.Text = dueVal;
            titleLbl.Text = type + " Video";
            if (bookingID == 0)
            {
                custCB.SelectedIndex = -1;
                vidCB.SelectedIndex = -1;
            }
            else
            {
                custCB.SelectedItem = customer;
                vidCB.SelectedItem = video;
            }
        }
            private void enterBtn_Click(object sender, EventArgs e)
            {
            if (custCB.SelectedIndex != -1)
            {
                if (enterBtn.Text == "Return")
                {
                    int a = cost * Convert.ToInt32((endDatePK.Value - startDatePK.Value).TotalDays);
                    if (a == 0)
                        a = cost;
                    SqlOperation.UpdateData(custCB, vidCB, startDatePK, endDatePK, bookingID.ToString(), a);
                }
                else
                {
                    if (custCB.SelectedIndex != -1)
                    {
                        SqlOperation.InsertData(custCB, vidCB, startDatePK, endDatePK);
                        custCB.SelectedIndex = -1;
                        vidCB.SelectedIndex = -1;
                        startDatePK.Value = DateTime.Now;
                        endDatePK.Value = DateTime.Now;
                    }
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void custCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (custCB.SelectedIndex != -1)
            {
                custCB.Tag = SqlOperation.cidList[custCB.SelectedIndex];
            }
        }

        private void vidCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vidCB.SelectedIndex != -1)
            {
                vidCB.Tag = SqlOperation.vidList[vidCB.SelectedIndex];
            }
        }
    }
}
