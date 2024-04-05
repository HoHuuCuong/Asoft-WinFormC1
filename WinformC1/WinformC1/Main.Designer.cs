namespace WinformC1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.testDataSet = new WinformC1.testDataSet();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new WinformC1.testDataSetTableAdapters.TestTableAdapter();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1ContextMenu1 = new C1.Win.C1Command.C1ContextMenu();
            this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
            this.Delete = new C1.Win.C1Command.C1Command();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command3 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command5 = new C1.Win.C1Command.C1Command();
            this.Create = new C1.Win.C1Command.C1CommandLink();
            this.insert = new C1.Win.C1Command.C1Command();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.update = new C1.Win.C1Command.C1CommandControl();
            this.c1CommandMenu1 = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command4 = new C1.Win.C1Command.C1Command();
            this.c1Button2 = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).BeginInit();
            this.SuspendLayout();
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "Test";
            this.testBindingSource.DataSource = this.testDataSet;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // c1Button1
            // 
            this.c1Button1.Location = new System.Drawing.Point(495, 410);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(101, 44);
            this.c1Button1.TabIndex = 1;
            this.c1Button1.Text = "Đóng";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.UseVisualStyleForeColor = true;
            this.c1Button1.Click += new System.EventHandler(this.Exit);
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataSource = this.testBindingSource;
            this.c1FlexGrid1.Location = new System.Drawing.Point(27, 12);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Size = new System.Drawing.Size(569, 354);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 2;
            this.c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Black;
            // 
            // c1ContextMenu1
            // 
            this.c1ContextMenu1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink5,
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.Create});
            this.c1ContextMenu1.Name = "c1ContextMenu1";
            this.c1ContextMenu1.ShortcutText = "";
            this.c1ContextMenu1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Silver;
            this.c1ContextMenu1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Silver;
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.Delete;
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ShortcutText = "";
            this.Delete.Text = "Delete";
            this.Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command2_Click);
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.c1Command3;
            this.c1CommandLink1.SortOrder = 1;
            // 
            // c1Command3
            // 
            this.c1Command3.Image = ((System.Drawing.Image)(resources.GetObject("c1Command3.Image")));
            this.c1Command3.Name = "c1Command3";
            this.c1Command3.ShortcutText = "";
            this.c1Command3.Text = "Edit";
            this.c1Command3.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command3_Click);
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.c1Command5;
            this.c1CommandLink2.SortOrder = 2;
            // 
            // c1Command5
            // 
            this.c1Command5.Image = ((System.Drawing.Image)(resources.GetObject("c1Command5.Image")));
            this.c1Command5.Name = "c1Command5";
            this.c1Command5.ShortcutText = "";
            this.c1Command5.Text = "View";
            this.c1Command5.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command5_Click);
            // 
            // Create
            // 
            this.Create.Command = this.insert;
            this.Create.SortOrder = 3;
            // 
            // insert
            // 
            this.insert.Image = ((System.Drawing.Image)(resources.GetObject("insert.Image")));
            this.insert.Name = "insert";
            this.insert.ShortcutText = "";
            this.insert.Text = "Insert";
            this.insert.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command1_Click);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1ContextMenu1);
            this.c1CommandHolder1.Commands.Add(this.update);
            this.c1CommandHolder1.Commands.Add(this.insert);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMenu1);
            this.c1CommandHolder1.Commands.Add(this.Delete);
            this.c1CommandHolder1.Commands.Add(this.c1Command3);
            this.c1CommandHolder1.Commands.Add(this.c1Command4);
            this.c1CommandHolder1.Commands.Add(this.c1Command5);
            this.c1CommandHolder1.Owner = this;
            // 
            // update
            // 
            this.update.Name = "update";
            this.update.ShortcutText = "";
            this.update.Text = "Sửa";
            // 
            // c1CommandMenu1
            // 
            this.c1CommandMenu1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink4});
            this.c1CommandMenu1.Name = "c1CommandMenu1";
            this.c1CommandMenu1.ShortcutText = "";
            this.c1CommandMenu1.Text = "&Edit";
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Text = "New Command";
            // 
            // c1Command4
            // 
            this.c1Command4.Name = "c1Command4";
            this.c1Command4.ShortcutText = "";
            this.c1Command4.Text = "New Command";
            // 
            // c1Button2
            // 
            this.c1Button2.Location = new System.Drawing.Point(349, 410);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(101, 44);
            this.c1Button2.TabIndex = 3;
            this.c1Button2.Text = "Thực Hiện";
            this.c1Button2.UseVisualStyleBackColor = true;
            this.c1Button2.UseVisualStyleForeColor = true;
            this.c1Button2.Click += new System.EventHandler(this.ShowAction);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 497);
            this.Controls.Add(this.c1Button2);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.c1Button1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource testBindingSource;
        private testDataSetTableAdapters.TestTableAdapter testTableAdapter;
        private C1.Win.C1Input.C1Button c1Button1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1Command.C1ContextMenu c1ContextMenu1;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Command.C1CommandControl update;
        private C1.Win.C1Input.C1Button c1Button2;
        private C1.Win.C1Command.C1CommandMenu c1CommandMenu1;
        private C1.Win.C1Command.C1CommandLink c1CommandLink4;
        private C1.Win.C1Command.C1CommandLink c1CommandLink5;
        private C1.Win.C1Command.C1Command Delete;
        private C1.Win.C1Command.C1CommandLink Create;
        private C1.Win.C1Command.C1Command insert;
        private C1.Win.C1Command.C1CommandLink c1CommandLink1;
        private C1.Win.C1Command.C1Command c1Command3;
        private C1.Win.C1Command.C1Command c1Command4;
        private C1.Win.C1Command.C1CommandLink c1CommandLink2;
        private C1.Win.C1Command.C1Command c1Command5;
    }
}

