using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static WinformC1.Main;

namespace WinformC1
{
    public partial class Action : Form
    {
        private Main main;


        public string userID;
        public string userName;
        public string tel;
        public string email;
        public string passWord;
        public string conFirmPassWord;
        public ActionMode flag;


        public Action()
        {
            InitializeComponent();

        }
        public Action(Main main)
        {
            InitializeComponent();
            this.main = main;
        }
        public Action(Main main, string userID, string userName, string email, string tel, string password, ActionMode flag)
        {
            InitializeComponent();
            this.main = main;
            this.userID = userID;
            this.userName = userName;
            this.email = email;
            this.tel = tel;
            this.passWord = password;
            this.flag = flag;
            loadData();
        }
        private void ActionMode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.testDataSet.Test);

        }
        public Action(Main main, ActionMode flag)
        {
            InitializeComponent();
            this.main = main;
            this.flag = flag;
        }
       
        private void loadData()
        {
            switch (flag)
            {
                case ActionMode.Create:

                    break;
                case ActionMode.Update:
                    txtID.Text = userID;
                    txtID.ReadOnly = true;
                    txtName.Text = userName;
                    txtEmail.Text = email;
                    txtTel.Text = tel;
                    txtPass.Text = passWord;
                    txtConfirmPass.Text = passWord;
                    btnNhapTiep.Visible = false;
                    break;
                case ActionMode.View:
                    txtID.Text = userID;
                    txtID.ReadOnly = true;
                    txtName.Text = userName;
                    txtName.ReadOnly = true;
                    txtEmail.Text = email;
                    txtEmail.ReadOnly = true;
                    txtTel.Text = tel;
                    txtTel.ReadOnly = true;
                    txtPass.Text = passWord;
                    lbConfirmPass.Visible = false;
                    txtPass.ReadOnly = true;
                    txtConfirmPass.Visible = false;                 
                    btnLuu.Visible = false;
                    btnNhapTiep.Visible = false;
                    break;
                default:

                    break;
            }

        }
        private void Save(object sender, EventArgs e)
        {
            userID = txtID.Text;
            userName = txtName.Text;
            tel = txtTel.Text;
            email = txtEmail.Text;
            passWord = txtPass.Text;
            conFirmPassWord = txtConfirmPass.Text;
            switch (flag)
            {
                case ActionMode.Create:


                    if (string.IsNullOrEmpty(userID))
                    {
                        MessageBox.Show("Vui lòng nhập mã người dùng.");
                        return;
                    }

                    // Kiểm tra trùng mã người dùng trong cơ sở dữ liệu (giả sử có hàm kiểm tra trong database)
                    if (CheckUserID(userID))
                    {
                        MessageBox.Show("Mã người dùng đã tồn tại. Vui lòng chọn mã khác.");
                        return;
                    }

                    // Kiểm tra bắt buộc nhập Tên người dùng
                    if (string.IsNullOrEmpty(userName))
                    {
                        MessageBox.Show("Vui lòng nhập tên người dùng.");
                        return;
                    }

                    // Kiểm tra mật khẩu và xác nhận mật khẩu trùng nhau
                    if (!string.IsNullOrEmpty(passWord) && !string.IsNullOrEmpty(conFirmPassWord))
                    {
                        if (passWord != conFirmPassWord)
                        {
                            MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                            return;
                        }
                    }
                    else if (string.IsNullOrEmpty(passWord) && !string.IsNullOrEmpty(conFirmPassWord))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu.");
                        return;
                    }
                    else if (!string.IsNullOrEmpty(passWord) && string.IsNullOrEmpty(conFirmPassWord))
                    {
                        MessageBox.Show("Vui lòng xác nhận mật khẩu.");
                        return;
                    }

                    // Kiểm tra và xử lý email hợp lệ
                    if (!string.IsNullOrEmpty(email))
                    {
                        if (!IsValidEmail(email))
                        {
                            MessageBox.Show("Email không hợp lệ.");
                            return;
                        }
                    }
                    DataRow newRow = testDataSet.Test.NewRow();
                    newRow["userID"] = userID;
                    newRow["userName"] = userName;
                    newRow["email"] = email;
                    newRow["tel"] = tel;
                    newRow["Disable"] = 0;
                    testDataSet.Test.Rows.Add(newRow);
                    testTableAdapter.Update(testDataSet.Test);
                    MessageBox.Show("Thêm thành công");
                    main.Form1_Load(sender, e);
                    this.Close();
                    break;

                case ActionMode.Update:
                    DataRow[] rows = testDataSet.Tables["Test"].Select("userID = '" + userID + "'");
                    if (rows.Length > 0)
                    {
                        rows[0]["userName"] = userName;
                        rows[0]["email"] = email;
                        rows[0]["tel"] = tel;
                        rows[0]["password"] = passWord;
                        testTableAdapter.Update(testDataSet.Test);
                        MessageBox.Show("Cập nhật thành công");
                        main.Form1_Load(sender, e);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");

                    }
                        break;
                    

            }
        } 

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool CheckUserID(string userID)
        {
            bool check = false;
            DataRow[] rows = testDataSet.Tables["Test"].Select("userID = '" + userID + "'");
            if (rows.Length > 0)
            {
                check = true;
            }
            return check;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtPass.Clear();
            txtConfirmPass.Clear();
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
