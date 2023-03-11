namespace tokohp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.jenis = new System.Windows.Forms.TextBox();
            this.id_hp = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_simpan_click = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.nama);
            this.panel1.Controls.Add(this.jenis);
            this.panel1.Controls.Add(this.id_hp);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btn_simpan_click);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 1019);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "jenis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "id";
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(14, 439);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(334, 31);
            this.stock.TabIndex = 10;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(14, 313);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(334, 31);
            this.nama.TabIndex = 9;
            this.nama.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // jenis
            // 
            this.jenis.Location = new System.Drawing.Point(14, 380);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(334, 31);
            this.jenis.TabIndex = 8;
            // 
            // id_hp
            // 
            this.id_hp.Location = new System.Drawing.Point(14, 251);
            this.id_hp.Name = "id_hp";
            this.id_hp.Size = new System.Drawing.Size(334, 31);
            this.id_hp.TabIndex = 7;
            this.id_hp.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Desktop;
            this.button6.Location = new System.Drawing.Point(14, 599);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(334, 75);
            this.button6.TabIndex = 6;
            this.button6.Text = "update";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_simpan_click
            // 
            this.btn_simpan_click.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_simpan_click.Location = new System.Drawing.Point(14, 508);
            this.btn_simpan_click.Name = "btn_simpan_click";
            this.btn_simpan_click.Size = new System.Drawing.Size(334, 75);
            this.btn_simpan_click.TabIndex = 5;
            this.btn_simpan_click.Text = "save";
            this.btn_simpan_click.UseVisualStyleBackColor = false;
            this.btn_simpan_click.Click += new System.EventHandler(this.btn_simpan_click_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(365, -1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1087, 1003);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 269);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(665, 31);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.search);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "search";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(120, 108);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(241, 96);
            this.phone.TabIndex = 15;
            this.phone.Text = "phone";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 128);
            this.label6.TabIndex = 16;
            this.label6.Text = "parel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 1001);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Button button6;
        private Button btn_simpan_click;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox stock;
        private TextBox nama;
        private TextBox jenis;
        private TextBox id_hp;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label5;
        private Label phone;
        private Label label6;
    }
}