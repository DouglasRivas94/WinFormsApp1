namespace WinFormsApp1
{
    partial class activity
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsafe = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.lsta = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actividad";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 214);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(130, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Añadir Actividad";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsafe
            // 
            this.btnsafe.Location = new System.Drawing.Point(439, 214);
            this.btnsafe.Name = "btnsafe";
            this.btnsafe.Size = new System.Drawing.Size(75, 23);
            this.btnsafe.TabIndex = 4;
            this.btnsafe.Text = "Guardar";
            this.btnsafe.UseVisualStyleBackColor = true;
            this.btnsafe.Click += new System.EventHandler(this.btnsafe_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(551, 214);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(661, 214);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(82, 280);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(654, 23);
            this.txta.TabIndex = 7;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // lsta
            // 
            this.lsta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsta.FormattingEnabled = true;
            this.lsta.ItemHeight = 15;
            this.lsta.Location = new System.Drawing.Point(25, 326);
            this.lsta.Name = "lsta";
            this.lsta.Size = new System.Drawing.Size(711, 154);
            this.lsta.TabIndex = 8;
            // 
            // activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 492);
            this.Controls.Add(this.lsta);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsafe);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "activity";
            this.Text = "Agenda de actividad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.activity_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Button btnadd;
        private Button btnsafe;
        private Button btndelete;
        private Button btncancel;
        private TextBox txta;
        private ListBox lsta;
    }
}