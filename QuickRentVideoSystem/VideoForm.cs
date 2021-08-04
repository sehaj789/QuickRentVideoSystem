using System;
using System.Windows.Forms;

namespace QuickRentVideoSystem
{
    public partial class VideoForm : Form
    {
        int videoID;
        public VideoForm(String type,int id, String title,String cost,String copies,String genre,String language, DateTime year)
        {
            InitializeComponent();
            videoID = id;
            enterBtn.Text = type;
            nameTxt.Text = title;
            priceTxt.Text = cost;
            copyTxt.Text = copies;
            genreTxt.Text = genre;
            langTxt.Text = language;
            yearPK.Value = year;
            titleLbl.Text = type + " Video";
        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text != "" && genreTxt.Text != "" && langTxt.Text != "" && priceTxt.Text != "")
            {
                if (enterBtn.Text == "Add")
                    SqlOperation.InsertData(nameTxt, genreTxt, priceTxt, langTxt, copyTxt, yearPK);
                else
                    SqlOperation.UpdateData(nameTxt, genreTxt, priceTxt, langTxt, copyTxt, yearPK,videoID.ToString());
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
