using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuickRentVideoSystem
{
    public class SqlOperation
    {

        // set your own connection
        private static SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-PO69FP5\\SQLEXPRESS;Initial Catalog=QuickRentDB;Integrated Security=True");
        static SqlCommand myCmd;
        public static List<String> customerList = new List<String>();
        public static List<String> cidList = new List<String>();
        public static List<String> videoList = new List<String>();
        public static List<String> vidList = new List<String>();
        public static void LoadList()
        {
            cidList.Clear();
            vidList.Clear();
            customerList.Clear();
            videoList.Clear();
            string query1 = "select ID,Title FROM VideoData;";
            string query2 = "select ID,Name FROM CustomerData;";
            SqlDataReader dr1, dr2;
            try
            {
                myCmd = new SqlCommand(query1, myCon);
                myCon.Open();
                dr1 = myCmd.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        vidList.Add(dr1.GetValue(0).ToString());
                        videoList.Add(dr1.GetString(1));
                    }
                    dr1.Close();
                }
                myCon.Close();

                myCmd = new SqlCommand(query2, myCon);
                myCon.Open();
                dr2 = myCmd.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        cidList.Add(dr2.GetValue(0).ToString());
                        customerList.Add(dr2.GetString(1));
                    }
                    dr2.Close();
                }
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        // view custoer function
        public static void ViewCustomer(DataGridView gv)
        {
            gv.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter("getCustomerData", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            gv.DataSource = dataTable;

            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "deleteColumn";
            column.HeaderText = "";
            gv.Columns.Add(column);
            for (int row = 0; row < gv.Rows.Count ; row++)
            {
                var img = IconChar.TimesCircle.ToBitmap(IconFont.Auto, color: Color.DimGray, size: 35);
                ((DataGridViewImageCell)gv.Rows[row].Cells["deleteColumn"]).Value = img; 
            }
            gv.Columns["deleteColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gv.ClearSelection();

        }

        // view video function 
        public static void ViewVideos(DataGridView gv)
        {
            gv.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter("getVideoData", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            gv.DataSource = dataTable;

            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "deleteColumn";
            column.HeaderText = "";
            gv.Columns.Add(column);
            for (int row = 0; row < gv.Rows.Count ; row++)
            {
                var img = IconChar.TimesCircle.ToBitmap(IconFont.Auto, color: Color.DimGray, size: 35);
                ((DataGridViewImageCell)gv.Rows[row].Cells["deleteColumn"]).Value = img;
            }
            gv.Columns["deleteColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gv.ClearSelection();

        }
        public static void ViewBooking(DataGridView gv)
        {
            gv.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter("getRentalData", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            gv.DataSource = dataTable;
            gv.Columns["CID"].Visible = false;
            gv.Columns["VID"].Visible = false;
            gv.Columns["Cost"].Visible = false;
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "deleteColumn";
            column.ImageLayout = DataGridViewImageCellLayout.Zoom;
            column.HeaderText = "";
            gv.Columns.Add(column);
            for (int row = 0; row < gv.Rows.Count ; row++)
            {
                var img = IconChar.TimesCircle.ToBitmap(IconFont.Auto, color: Color.DimGray, size: 35);
                ((DataGridViewImageCell)gv.Rows[row].Cells["deleteColumn"]).Value = img;
            }
            gv.Columns["deleteColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gv.ClearSelection();
        }

        // remove customer

        public static void RemoveCustomer(int customerID)
        {
            string query = "delete from CustomerData where ID=" + customerID + "; ";
            try
            {
                myCon.Open();
                myCmd = new SqlCommand(query, myCon);
                myCmd.ExecuteReader();
                myCon.Close();
                MessageBox.Show("Customer Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public static void RemoveVideo(int videoID)
        {
            string query = "delete from VideoData where ID=" + videoID + "; ";
            try
            {
                myCon.Open();
                myCmd = new SqlCommand(query, myCon);
                myCmd.ExecuteReader();
                myCon.Close();
                MessageBox.Show("Video Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // removce booking 

        public static void RemoveBooking(int bookingID)
        {
            string query = "delete from RentalData where ID=" + bookingID + "; ";
            try
            {
                myCon.Open();
                myCmd = new SqlCommand(query, myCon);
                myCmd.ExecuteReader();
                myCon.Close();
                MessageBox.Show("Booking Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public static void InsertData(TextBox a, TextBox b, TextBox c,DateTimePicker d)
        {
            string query = "insert into CustomerData(Name,Phone,Address,JoinDate,TotalPurchase) values('" + a.Text + "','" + b.Text + "','" + c.Text + "','" + d.Text + "',0);";
            try
            {
                myCon.Open();
                myCmd = new SqlCommand(query, myCon);
                myCmd.ExecuteReader();
                myCon.Close();
                MessageBox.Show(a.Text + " Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.Text = "";
                b.Text = "";
                c.Text = "";
                d.Value = DateTime.Now;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                myCon.Close();
            }
        }

        // insert data 
        public static void InsertData(ComboBox a, ComboBox b, DateTimePicker c, DateTimePicker d)
        {
            int count = 0;
            int cost = 0;
            string q = "select Copies,Cost from VideoData where ID=" + Convert.ToInt32(b.Tag) + ";";
            SqlDataReader dataReader;
            try
            {
                myCon.Open();
                myCmd = new SqlCommand(q, myCon);
                dataReader = myCmd.ExecuteReader();
                dataReader.Read();
                count = dataReader.GetInt32(0);
                cost = Convert.ToInt32(dataReader.GetValue(1).ToString());
                dataReader.Close();
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                myCon.Close();
            }
            if (count != 0)
            {
                int amt = cost * Convert.ToInt32((d.Value - c.Value).TotalDays);
                if (amt == 0)
                    amt = cost;
                string query = "insert into RentalData(Customer_ID,Video_ID,Start,Due,Status,Cost) values(" + Convert.ToInt32(a.Tag) + "," + Convert.ToInt32(b.Tag) + ",'" + c.Value.ToString("dd MMMM yy") + "','" + d.Value.ToString("dd MMMM yy") + "','Issue',"+amt+"); update VideoData set Copies=Copies-1 where ID=" + Convert.ToInt32(b.Tag) + "; ";
                try
                {
                    myCon.Open();
                    myCmd = new SqlCommand(query, myCon);
                    myCmd.ExecuteReader();
                    myCon.Close();
                    MessageBox.Show("Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    myCon.Close();
                }
            }
            else
            {
                MessageBox.Show("Video Copies Not Available...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void InsertData(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, DateTimePicker f)
        {
            string query = "insert into VideoData(Title,Genre,Cost,Language,Copies,Year) values('" + a.Text + "','" + b.Text + "','" + Convert.ToInt32(c.Text) + "','" + d.Text + "'," + Convert.ToInt32(e.Text) + ",'" + f.Text + "');";
            try
            {
                myCon.Open();
                myCmd = new SqlCommand(query, myCon);
                myCmd.ExecuteReader();
                myCon.Close();
                MessageBox.Show(a.Text + " Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.Text = "";
                b.Text = "";
                c.Text = "";
                d.Text = "";
                e.Text = "";
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public static void UpdateData(TextBox a, TextBox b, TextBox c, DateTimePicker d, string id)
        {
            string query = "update CustomerData set Name='" + a.Text + "',Phone='" + b.Text + "', Address='" + c.Text + "',JoinDate='" + d.Text + "' where ID=" + Convert.ToInt32(id) + "; ";
            try
            {
                myCon.Open();
                myCmd = new SqlCommand(query, myCon);
                myCmd.ExecuteReader();
                myCon.Close();
                MessageBox.Show(a.Text + " Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.Text = "";
                b.Text = "";
                c.Text = "";
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public static void UpdateData(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, DateTimePicker f, String id)
        {
            string query = "update VideoData set Title='" + a.Text + "', Genre='" + b.Text + "', Cost='" + Convert.ToInt32(c.Text) + "', Language='" + d.Text + "', Copies=" + Convert.ToInt32(e.Text) + ",Year='" + f.Text + "'  where ID=" + Convert.ToInt32(id) + "; ";
            try
            {
                myCon.Open();
                myCmd = new SqlCommand(query, myCon);
                myCmd.ExecuteReader();
                myCon.Close();
                MessageBox.Show(a.Text + " Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.Text = "";
                b.Text = "";
                d.Text = "";
                e.Text = "";
                c.Text = "";
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public static void UpdateData(ComboBox a, ComboBox b, DateTimePicker c, DateTimePicker d, String id, int i)
        {
            string query = "update RentalData set Customer_ID=" + Convert.ToInt32(a.Tag) + ",Cost="+i+", Video_ID=" + Convert.ToInt32(b.Tag) + ", Start='" + c.Value.ToString("dd MMMM yy") + "',Due='" + d.Value.ToString("dd MMMM yy") + "',Status='Return' where ID=" + Convert.ToInt32(id) + "; update VideoData set Copies=Copies+1 where ID=" + b.Tag + ";update CustomerData set TotalPurchase=TotalPurchase+" + i+" where ID=" + a.Tag + "; ";
            try
            {
                myCon.Open();
                myCmd = new SqlCommand(query, myCon);
                myCmd.ExecuteReader();
                myCon.Close();
                MessageBox.Show("Total Rent Cost is " + i.ToString() + "$", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public static void LoadStat(String type,Label a, Label b, Label c)
        {
            if (type == "booking")
                b.Font = new Font("Segoe UI Semibold", 23, FontStyle.Bold);
            else
                b.Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold);

            string query1 = "";
            string query2 = "";
            string query3 = "";

            if (type == "booking")
            {
                query1 = "select count(ID) FROM RentalData;";
                query2 = "select ISNULL(sum(Cost),0) from RentalData ;";
                query3 = "select ISNULL(sum(Cost),0) FROM RentalData where Status='Issue' ; ";
            }
            else if(type=="video")
            {
                query1 = "select count(ID) FROM VideoData;";
                query2 = "select Top 1 v.Title FROM RentalData b,VideoData v where b.Video_ID=v.ID group by b.Video_ID,v.Title ;";
                query3 = "select sum(Copies) FROM VideoData; ";
            }
            else if(type=="customer")
            {
                query1 = "select count(ID) FROM CustomerData;";
                query2 = "select Top 1 Name from CustomerData order by TotalPurchase desc ;";
                query3 = "select count(ID) FROM CustomerData where JoinDate like '%"+DateTime.Now.ToString("MMM-yy")+"%'; ";
            }
            SqlDataReader dr1, dr2,dr3;
            try
            {
                myCmd = new SqlCommand(query1, myCon);
                myCon.Open();
                dr1 = myCmd.ExecuteReader();
                if (dr1.HasRows)
                {
                    dr1.Read();
                    a.Text = dr1.GetValue(0).ToString();
                    dr1.Close();
                }
                myCon.Close();

                myCmd = new SqlCommand(query2, myCon);
                myCon.Open();
                dr2 = myCmd.ExecuteReader();
                if (dr2.HasRows)
                {
                    dr2.Read();
                    if(type=="booking")
                        b.Text = "$" + dr2.GetValue(0).ToString();
                    else
                        b.Text = dr2.GetValue(0).ToString();
                    dr2.Close();
                }
                myCon.Close();

                myCmd = new SqlCommand(query3, myCon);
                myCon.Open();
                dr3 = myCmd.ExecuteReader();
                if (dr3.HasRows)
                {
                    dr3.Read();
                    if (type == "booking")
                        c.Text ="$"+ dr3.GetValue(0).ToString();
                    else
                        c.Text = dr3.GetValue(0).ToString();
                    dr3.Close();
                }
                myCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}