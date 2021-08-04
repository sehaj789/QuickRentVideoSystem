using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickRentVideoSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        int bID,vID,cID;
        int cost;
        String type;
        private void Dashboard_Load(object sender, EventArgs e)
        {
            type = "booking";
            titleLbl.Text = "Booking Details";
            insertBtn.Text = "Add Booking";
            SqlOperation.ViewBooking(dataGV);
            SqlOperation.LoadStat(type,stat1Lbl, stat2Lbl, stat3Lbl);
            bID = -1;
            vID = -1;
            cID = -1;
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (type=="booking")
            {
                RentalForm b = new RentalForm("Issue", 0, 0, 0, 0, "", "", DateTime.Now.ToString(), DateTime.Now.ToString());
                b.Show();
            }
            else if(type=="video")
            {
                VideoForm v = new VideoForm("Add", 0, "", "", "", "", "", DateTime.Now);
                v.Show();
            }
            else if(type=="customer")
            {
                CustomerForm c = new CustomerForm("Add", 0, "", "", "", DateTime.Now.ToString());
                c.Show();
            }
        }
        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex!=-1 && e.RowIndex != -1)
            {
                if (type == "booking")
                {
                    DataGridViewRow row = dataGV.Rows[e.RowIndex];
                    bID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    if (e.ColumnIndex == dataGV.Columns["deleteColumn"].Index)
                    {
                        SqlOperation.RemoveBooking(bID);
                        SqlOperation.ViewBooking(dataGV);
                        SqlOperation.LoadStat(type,stat1Lbl, stat2Lbl, stat3Lbl);
                    }
                }
                else if (type == "customer")
                {
                    DataGridViewRow row = dataGV.Rows[e.RowIndex];
                    cID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    if (e.ColumnIndex == dataGV.Columns["deleteColumn"].Index)
                    {
                        SqlOperation.RemoveCustomer(cID);
                        SqlOperation.ViewCustomer(dataGV);
                        SqlOperation.LoadStat(type,stat1Lbl, stat2Lbl, stat3Lbl);
                    }
                }
                else if (type == "video")
                {
                    DataGridViewRow row = dataGV.Rows[e.RowIndex];
                    vID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    if (e.ColumnIndex == dataGV.Columns["deleteColumn"].Index)
                    {
                        SqlOperation.RemoveVideo(vID);
                        SqlOperation.ViewVideos(dataGV);
                        SqlOperation.LoadStat(type,stat1Lbl, stat2Lbl, stat3Lbl);
                    }
                }
            }
        }
        private void DataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                DataGridViewRow row = dataGV.Rows[e.RowIndex];
                if (type == "booking")
                {
                    bID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    RentalForm b = new RentalForm("Return", Convert.ToInt32(dataGV.Rows[e.RowIndex].Cells["ID"].Value.ToString()), Convert.ToInt32(dataGV.Rows[e.RowIndex].Cells["CID"].Value.ToString()), Convert.ToInt32(dataGV.Rows[e.RowIndex].Cells["VID"].Value.ToString()), Convert.ToInt32(dataGV.Rows[e.RowIndex].Cells["Cost"].Value.ToString()), dataGV.Rows[e.RowIndex].Cells["Customer"].Value.ToString(), dataGV.Rows[e.RowIndex].Cells["Video"].Value.ToString(), dataGV.Rows[e.RowIndex].Cells["Booking Date"].Value.ToString(), dataGV.Rows[e.RowIndex].Cells["Return Date"].Value.ToString());
                    b.Show();
                }
                else if (type == "customer")
                {
                    cID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    CustomerForm c = new CustomerForm("Edit", Convert.ToInt32(dataGV.Rows[e.RowIndex].Cells["ID"].Value.ToString()), dataGV.Rows[e.RowIndex].Cells["Name"].Value.ToString(), dataGV.Rows[e.RowIndex].Cells["Phone"].Value.ToString(), dataGV.Rows[e.RowIndex].Cells["Address"].Value.ToString(), dataGV.Rows[e.RowIndex].Cells["JoinDate"].Value.ToString());
                    c.Show();
                }
                else if (type == "video")
                {
                    vID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    String a = dataGV.Rows[e.RowIndex].Cells["Cost"].Value.ToString();
                    VideoForm v = new VideoForm("Edit", Convert.ToInt32(dataGV.Rows[e.RowIndex].Cells["ID"].Value.ToString()), dataGV.Rows[e.RowIndex].Cells["Title"].Value.ToString(), dataGV.Rows[e.RowIndex].Cells["Cost"].Value.ToString().Remove(a.Length - 2, 2), dataGV.Rows[e.RowIndex].Cells["Copies"].Value.ToString(), dataGV.Rows[e.RowIndex].Cells["Genre"].Value.ToString(), dataGV.Rows[e.RowIndex].Cells["Language"].Value.ToString(), new DateTime(Convert.ToInt32(dataGV.Rows[e.RowIndex].Cells["Year"].Value.ToString()), 1, 1));
                    v.Show();
                }
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void videoBtn_Click(object sender, EventArgs e)
        {
            stat1TitleLbl.Text = "Total Video";
            stat2TitleLbl.Text = "Popular Video";
            stat3TitleLbl.Text = "Total Copies";
            type = "video";
            titleLbl.Text = "Video Details";
            insertBtn.Text = "Add Video";
            SqlOperation.ViewVideos(dataGV);
            SqlOperation.LoadStat(type, stat1Lbl, stat2Lbl, stat3Lbl);
            vID = -1;
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            stat1TitleLbl.Text = "Total Customer";
            stat2TitleLbl.Text = "Top Customer";
            stat3TitleLbl.Text = "Newly Joined";
            type = "customer";
            titleLbl.Text = "Customer Details";
            insertBtn.Text = "Add Customer";
            SqlOperation.ViewCustomer(dataGV);
            SqlOperation.LoadStat(type, stat1Lbl, stat2Lbl, stat3Lbl);
            cID = -1;
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            stat1TitleLbl.Text = "Total Booking";
            stat2TitleLbl.Text = "Total Sales";
            stat3TitleLbl.Text = "Pending Amount";
            type = "booking";
            titleLbl.Text = "Booking Details";
            insertBtn.Text = "Add Booking";
            SqlOperation.ViewBooking(dataGV);
            SqlOperation.LoadStat(type, stat1Lbl, stat2Lbl, stat3Lbl);
            bID = -1;
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            if (type == "booking")
            {
                SqlOperation.ViewBooking(dataGV);
                SqlOperation.LoadStat(type,stat1Lbl, stat2Lbl, stat3Lbl);
            }
            else if (type == "customer")
            {
                SqlOperation.ViewCustomer(dataGV);
                SqlOperation.LoadStat(type,stat1Lbl, stat2Lbl, stat3Lbl);
            }
            else if (type == "video")
            {
                SqlOperation.ViewVideos(dataGV);
                SqlOperation.LoadStat(type,stat1Lbl, stat2Lbl, stat3Lbl);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}