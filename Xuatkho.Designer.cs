
namespace cuoi_ki
{
    partial class Xuatkho
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbDaily = new System.Windows.Forms.ComboBox();
            this.dateXuat = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grdetail = new System.Windows.Forms.GroupBox();
            this.cbMaxuat = new System.Windows.Forms.ComboBox();
            this.cbmasp = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.chitietxuat = new System.Windows.Forms.DataGridView();
            this.grxuat = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManxuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chitietxuat)).BeginInit();
            this.grxuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(740, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbDaily
            // 
            this.cbDaily.FormattingEnabled = true;
            this.cbDaily.Location = new System.Drawing.Point(579, 82);
            this.cbDaily.Name = "cbDaily";
            this.cbDaily.Size = new System.Drawing.Size(195, 24);
            this.cbDaily.TabIndex = 25;
            // 
            // dateXuat
            // 
            this.dateXuat.Location = new System.Drawing.Point(579, 29);
            this.dateXuat.Name = "dateXuat";
            this.dateXuat.Size = new System.Drawing.Size(195, 22);
            this.dateXuat.TabIndex = 23;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(735, 121);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 33);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // grdetail
            // 
            this.grdetail.Controls.Add(this.cbMaxuat);
            this.grdetail.Controls.Add(this.cbmasp);
            this.grdetail.Controls.Add(this.label14);
            this.grdetail.Controls.Add(this.label13);
            this.grdetail.Controls.Add(this.label12);
            this.grdetail.Controls.Add(this.label2);
            this.grdetail.Controls.Add(this.txtsl);
            this.grdetail.Controls.Add(this.txtGia);
            this.grdetail.Controls.Add(this.chitietxuat);
            this.grdetail.Location = new System.Drawing.Point(-1, 229);
            this.grdetail.Name = "grdetail";
            this.grdetail.Size = new System.Drawing.Size(816, 292);
            this.grdetail.TabIndex = 31;
            this.grdetail.TabStop = false;
            this.grdetail.Text = "Chi tiết xuất";
            // 
            // cbMaxuat
            // 
            this.cbMaxuat.FormattingEnabled = true;
            this.cbMaxuat.Location = new System.Drawing.Point(154, 23);
            this.cbMaxuat.Name = "cbMaxuat";
            this.cbMaxuat.Size = new System.Drawing.Size(121, 24);
            this.cbMaxuat.TabIndex = 37;
            // 
            // cbmasp
            // 
            this.cbmasp.FormattingEnabled = true;
            this.cbmasp.Location = new System.Drawing.Point(154, 74);
            this.cbmasp.Name = "cbmasp";
            this.cbmasp.Size = new System.Drawing.Size(121, 24);
            this.cbmasp.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Mã xuất";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Mã sản phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(478, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Số lượng xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Giá";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(605, 78);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(121, 22);
            this.txtsl.TabIndex = 27;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(605, 27);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(121, 22);
            this.txtGia.TabIndex = 26;
            // 
            // chitietxuat
            // 
            this.chitietxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chitietxuat.Location = new System.Drawing.Point(6, 113);
            this.chitietxuat.Name = "chitietxuat";
            this.chitietxuat.RowHeadersWidth = 51;
            this.chitietxuat.RowTemplate.Height = 24;
            this.chitietxuat.Size = new System.Drawing.Size(804, 160);
            this.chitietxuat.TabIndex = 23;
            this.chitietxuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chitietxuat_CellClick);
            // 
            // grxuat
            // 
            this.grxuat.Controls.Add(this.cbDaily);
            this.grxuat.Controls.Add(this.label3);
            this.grxuat.Controls.Add(this.dateXuat);
            this.grxuat.Controls.Add(this.btnCreate);
            this.grxuat.Controls.Add(this.cbManv);
            this.grxuat.Controls.Add(this.label6);
            this.grxuat.Controls.Add(this.label5);
            this.grxuat.Controls.Add(this.txtManxuat);
            this.grxuat.Controls.Add(this.label4);
            this.grxuat.Location = new System.Drawing.Point(-1, 63);
            this.grxuat.Name = "grxuat";
            this.grxuat.Size = new System.Drawing.Size(816, 160);
            this.grxuat.TabIndex = 30;
            this.grxuat.TabStop = false;
            this.grxuat.Text = "Xuất kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã đại lý";
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(154, 82);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(195, 24);
            this.cbManv.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtManxuat
            // 
            this.txtManxuat.Location = new System.Drawing.Point(154, 29);
            this.txtManxuat.Name = "txtManxuat";
            this.txtManxuat.Size = new System.Drawing.Size(195, 22);
            this.txtManxuat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã xuất";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(659, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(578, 527);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Xuất kho";
            // 
            // Xuatkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 579);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdetail);
            this.Controls.Add(this.grxuat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "Xuatkho";
            this.Text = "Xuatkho";
            this.Load += new System.EventHandler(this.Xuatkho_Load);
            this.grdetail.ResumeLayout(false);
            this.grdetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chitietxuat)).EndInit();
            this.grxuat.ResumeLayout(false);
            this.grxuat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbDaily;
        private System.Windows.Forms.TextBox dateXuat;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grdetail;
        private System.Windows.Forms.ComboBox cbMaxuat;
        private System.Windows.Forms.ComboBox cbmasp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DataGridView chitietxuat;
        private System.Windows.Forms.GroupBox grxuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManxuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}