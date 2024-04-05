using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinformC1
{
    public partial class Main : Form
    {
      
        public string userID;
        public string userName;
        public string tel;
        public string email;
        public string passWord;
        public enum ActionMode
        {
            Create,
            Update,
            Delete,
            View
        }
      
        public Main()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.testDataSet.Test);
            
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {


        }
        private void c1Command2_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            //delete

            // Lấy chỉ mục của dòng được chọn
            int selectedRowIndex = c1FlexGrid1.RowSel;

            // Kiểm tra xem có dòng nào được chọn không
            if (selectedRowIndex > 0)
            {
                // Lấy giá trị cột userID từ dòng được chọn
                string userID = c1FlexGrid1[selectedRowIndex, "userID"].ToString();

                // Tìm dòng tương ứng trong bảng DataSet
                DataRow[] rows = testDataSet.Test.Select("userID = '" + userID + "'");

                // Kiểm tra xem dòng có tồn tại không
                if (rows.Length > 0)
                {
                    // Xóa dòng từ bảng DataSet
                    rows[0].Delete();

                    // Cập nhật cơ sở dữ liệu
                    testTableAdapter.Update(testDataSet.Test);
                    MessageBox.Show("Xóa thành công.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void ShowAction(object sender, EventArgs e)
        {
            c1ContextMenu1.ShowContextMenu(c1Button2, new Point(50, 50));
        }

        private void c1Command1_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            //create
            ActionMode flag = ActionMode.Create;
            Action action = new Action(this,flag);
            action.ShowDialog();
        }
    

        private void c1Command3_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            //update
            ActionMode flag = ActionMode.Update;
            int selectedRowIndex = c1FlexGrid1.RowSel;
             userID = c1FlexGrid1[selectedRowIndex, "userID"].ToString();
            if (selectedRowIndex > 0)
            {
                DataRow[] rows = testDataSet.Test.Select("userID = '" + userID + "'");
                userName = rows[0]["userName"].ToString();
                email = rows[0]["email"].ToString();
                tel = rows[0]["tel"].ToString();
                passWord = rows[0]["password"].ToString();
                Action action = new Action(this, userID, userName, email, tel, passWord,flag);
                action.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
          
          
        }

        private void c1Command5_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            //View
            ActionMode flag = ActionMode.View;
            int selectedRowIndex = c1FlexGrid1.RowSel;
            userID = c1FlexGrid1[selectedRowIndex, "userID"].ToString();
            if (selectedRowIndex > 0)
            {
                DataRow[] rows = testDataSet.Test.Select("userID = '" + userID + "'");
                userName = rows[0]["userName"].ToString();
                email = rows[0]["email"].ToString();
                tel = rows[0]["tel"].ToString();
                passWord = rows[0]["password"].ToString();
                Action action = new Action(this, userID, userName, email, tel, passWord, flag);
                action.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xem.");
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
