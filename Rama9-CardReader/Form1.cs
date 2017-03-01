using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiNationalIDCard;



namespace Rama9_CardReader
{
    public partial class frmMain : Form
    {
        private ThaiIDCard idcard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idcard = new ThaiIDCard();
            lbLibVersion.Text = "LibThaiIDCard version: " + idcard.Version();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();

            timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 10000; // in miliseconds
            timer2.Start();

            

            clearDefault();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*webBrowser1.Navigate(new Uri("https://stscholar.nstda.or.th/HMKingRama9/km9-list-page.php"));*/
            /*webBrowser1.Refresh();*/
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshSendButton();
        }

        public void clearDefault()
        {
            tb_fullname.Text = "";
            lb_cid.Text = "";
            btnRefreshReaderList.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tb_fullname.Text = "Reading....";
                idcard.eventPhotoProgress += new handlePhotoProgress(photoProgress);
                Personal personal = idcard.readAllPhoto();
                
                if (personal == null)
                {
                    tb_fullname.Text = "Please Insert Thai National Personal ID SmartCard";
                    return;
                }

                pictureBox1.Image = personal.PhotoBitmap;
                string picture_path = Environment.CurrentDirectory + "\\" + personal.Citizenid + ".jpg";
                String picture_name = personal.Citizenid + ".jpg";

                var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bitmap, pictureBox1.ClientRectangle);
                bitmap.Save(picture_name, ImageFormat.Jpeg);

                lb_cid.Text = personal.Citizenid;
                tb_fullname.Text = personal.Th_Prefix + personal.Th_Firstname + " " + personal.Th_Lastname;
                AddDatabase(personal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRefreshReaderList_Click(object sender, EventArgs e)
        {
            cbxReaderList.Items.Clear();
            cbxReaderList.SelectedIndex = -1;
            cbxReaderList.SelectedText = String.Empty;
            cbxReaderList.Text = string.Empty;
            cbxReaderList.Refresh();

            try
            {
                ThaiIDCard idcard = new ThaiIDCard();
                string[] readers = idcard.GetReaders();
                if (readers == null) return;

                foreach (string r in readers)
                {
                    cbxReaderList.Items.Add(r);
                }
                cbxReaderList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void refreshSendButton()
        {
            if (tb_fullname.TextLength > 0)
            {
                if (PingHost("www.nnr.nstda.or.th", 80) == true)
                {
                    btn_send.Enabled = true;
                }
                else
                {
                    btn_send.Enabled = false;
                }
            }
            else
            {
                btn_send.Enabled = false;
            }
        }

        public static bool PingHost(string _HostURI, int _PortNumber)
        {
            try
            {
                TcpClient client = new TcpClient(_HostURI, _PortNumber);
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error pinging host:'" + _HostURI + ":" + _PortNumber.ToString() + "'");
                return false;
            }
        }

        public static class dbTT
        {
            public static string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=scard_local.mdb";
        }

        public void AddDatabase(Personal personal)
        {
            //Read Card to DB
            //Connect to DB
            //if (comboBox1.Text == "") return;

            OleDbConnection myAccessConn = null;
            try
            {
                myAccessConn = new OleDbConnection(dbTT.strAccessConn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
                return;
            }

            OleDbCommand sql = new OleDbCommand();
            sql.CommandType = CommandType.Text;
            sql.CommandText = "INSERT INTO tbl_namecard_scard ([pid],[birthday],[sex],[th_title],[th_fname],[th_lname],[en_title],[en_fname],[en_lname],[issue],[expire],[address],[address_number],[address_moo],[address_lane],[address_road],[address_tambon],[address_amphur],[address_province]) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
            sql.Parameters.AddWithValue("@pid", personal.Citizenid);
            sql.Parameters.AddWithValue("@birthday", personal.Birthday.ToString("yyyy-MM-dd"));
            sql.Parameters.AddWithValue("@sex", personal.Sex);
            sql.Parameters.AddWithValue("@th_title", personal.Th_Prefix);
            sql.Parameters.AddWithValue("@th_fname", personal.Th_Firstname);
            sql.Parameters.AddWithValue("@th_lname", personal.Th_Lastname);
            sql.Parameters.AddWithValue("@en_title", personal.En_Prefix);
            sql.Parameters.AddWithValue("@en_fname", personal.En_Firstname);
            sql.Parameters.AddWithValue("@en_lname", personal.En_Lastname);
            sql.Parameters.AddWithValue("@issue", personal.Issue.ToString("yyyy-MM-dd"));
            sql.Parameters.AddWithValue("@expire", personal.Expire.ToString("yyyy-MM-dd"));
            sql.Parameters.AddWithValue("@address", personal.Address);
            sql.Parameters.AddWithValue("@address_number", personal.addrHouseNo);
            sql.Parameters.AddWithValue("@address_moo", personal.addrVillageNo);
            sql.Parameters.AddWithValue("@address_lane", personal.addrLane);
            sql.Parameters.AddWithValue("@address_road", personal.addrRoad);
            sql.Parameters.AddWithValue("@address_tambon", personal.addrTambol);
            sql.Parameters.AddWithValue("@address_amphur", personal.addrAmphur);
            sql.Parameters.AddWithValue("@address_province", personal.addrProvince);

            sql.Connection = myAccessConn;
            myAccessConn.Open();
            sql.ExecuteNonQuery();
            myAccessConn.Close();

        }

        private void photoProgress(int value, int maximum)
        {
            if (PhotoProgressBar1.Maximum != maximum)
                PhotoProgressBar1.Maximum = maximum;

            // fix progress bar sync.
            if (PhotoProgressBar1.Maximum > value)
                PhotoProgressBar1.Value = value + 1;

            PhotoProgressBar1.Value = value;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            btn_send.Enabled = false;
            String url = "https://stscholar.nstda.or.th/HMKingRama9/submit_preview.php";
            String Response;

            Response = postHtml(url, "flname", tb_fullname.Text.ToString());
            Response = Response.Replace("src=\"","src = \"https://stscholar.nstda.or.th/HMKingRama9/");
            //Response = Response.Replace("src: url('", "src: url('https://stscholar.nstda.or.th/HMKingRama9/");
            Response = Response.Replace("img.src = \"", "img.src = \"https://stscholar.nstda.or.th/HMKingRama9/");
            //System.IO.File.Delete(lb_cid.Text + ".html");

            String htmlFileName = "";
            if (lb_cid.Text == "")
            {
                
                DateTime date1 = DateTime.Now;
                htmlFileName = date1.ToString("yyyyMMddHHmmss") + ".html";
            }
            else
            {
                htmlFileName = lb_cid.Text + ".html";
            }

            System.IO.File.WriteAllText(htmlFileName, Response);
            /*
            string curDir = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(String.Format("file:///{0}/" + htmlFileName,curDir));
            */
            webBrowser1.Navigate(new Uri("https://stscholar.nstda.or.th/HMKingRama9/km9-list-page.php"));
            /*webBrowser1.Refresh();*/


            btn_send.Enabled = true;
        }

        private void tb_fullname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private String postHtml(string url, string field_name, string field_value)
        {
            NameValueCollection data = new NameValueCollection();
            data[field_name] = field_value;
            data["lang"] = "th";

            //data.Add("field_name", field_value);
            WebClient webClient = new WebClient();
            try
            {
                byte[] responseBytes = webClient.UploadValues(url, data);
                string response = Encoding.UTF8.GetString(responseBytes);
                return response;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
