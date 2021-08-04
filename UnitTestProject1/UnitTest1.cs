using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickRentVideoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckConnection()
        {
            SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-3P69FP5\\SQLEXPRESS;Initial Catalog=QuickRentDB;Integrated Security=True");
            try
            {
                myCon.Open();
                Assert.IsTrue(true);
                myCon.Close();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false, ex.Message);
            }
        }
        [TestMethod]
        public void CheckBookingDuration()
        {
            bool c = true;
            string query = "select Start,Due FROM RentalData;";
            SqlDataReader dr;
            try
            {
                SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-3P69FP5\\SQLEXPRESS;Initial Catalog=QuickRentDB;Integrated Security=True");
                SqlCommand myCmd = new SqlCommand(query, myCon);
                myCon.Open();
                dr = myCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        c = true;
                        if (DateTime.Compare(Convert.ToDateTime(dr.GetValue(0).ToString()), Convert.ToDateTime(dr.GetValue(1).ToString())) > 0)
                        {
                            c = false;
                            break;
                        }
                    }
                    if (c)
                        Assert.IsTrue(true);
                    else
                        Assert.IsTrue(false, "Invalid Booking Date ! Renturn Date should not be later than Booking Date");
                    dr.Close();
                }
                myCon.Close();
            }
            catch (Exception exp)
            {
                Assert.IsTrue(false, exp.Message);
            }
        }
    }
}
