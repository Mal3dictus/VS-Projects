namespace Task_Phone_Book
{
    partial class PhoneBook
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
            NewB = new Button();
            Email = new TextBox();
            Pnumber = new TextBox();
            Lname = new TextBox();
            Fname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SaveB = new Button();
            LoadB = new Button();
            DeleteB = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NewB
            // 
            NewB.Location = new Point(645, 409);
            NewB.Name = "NewB";
            NewB.Size = new Size(143, 29);
            NewB.TabIndex = 0;
            NewB.Text = "New Contact";
            NewB.UseVisualStyleBackColor = true;
            NewB.Click += NewB_Click;
            // 
            // Email
            // 
            Email.Location = new Point(526, 376);
            Email.Name = "Email";
            Email.Size = new Size(262, 27);
            Email.TabIndex = 1;
            // 
            // Pnumber
            // 
            Pnumber.Location = new Point(526, 343);
            Pnumber.Name = "Pnumber";
            Pnumber.Size = new Size(262, 27);
            Pnumber.TabIndex = 2;
            // 
            // Lname
            // 
            Lname.Location = new Point(526, 310);
            Lname.Name = "Lname";
            Lname.Size = new Size(262, 27);
            Lname.TabIndex = 3;
            // 
            // Fname
            // 
            Fname.Location = new Point(526, 277);
            Fname.Name = "Fname";
            Fname.Size = new Size(262, 27);
            Fname.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 280);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 5;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 313);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 346);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 7;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 379);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // SaveB
            // 
            SaveB.Location = new Point(496, 409);
            SaveB.Name = "SaveB";
            SaveB.Size = new Size(143, 29);
            SaveB.TabIndex = 9;
            SaveB.Text = "Save Contact";
            SaveB.UseVisualStyleBackColor = true;
            SaveB.Click += SaveB_Click;
            // 
            // LoadB
            // 
            LoadB.Location = new Point(347, 409);
            LoadB.Name = "LoadB";
            LoadB.Size = new Size(143, 29);
            LoadB.TabIndex = 10;
            LoadB.Text = "Load Contact";
            LoadB.UseVisualStyleBackColor = true;
            LoadB.Click += LoadB_Click;
            // 
            // DeleteB
            // 
            DeleteB.Location = new Point(198, 409);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(143, 29);
            DeleteB.TabIndex = 11;
            DeleteB.Text = "Delete Contact";
            DeleteB.UseVisualStyleBackColor = true;
            DeleteB.Click += DeleteB_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(386, 399);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(509, 101);
            label5.Name = "label5";
            label5.Size = new Size(222, 49);
            label5.TabIndex = 13;
            label5.Text = "PHONE BOOK";
            // 
            // PhoneBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteB);
            Controls.Add(LoadB);
            Controls.Add(SaveB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Fname);
            Controls.Add(Lname);
            Controls.Add(Pnumber);
            Controls.Add(Email);
            Controls.Add(NewB);
            Name = "PhoneBook";
            Text = "PhoneBook";
            Load += PhoneBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewB;
        private TextBox Email;
        private TextBox Pnumber;
        private TextBox Lname;
        private TextBox Fname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SaveB;
        private Button LoadB;
        private Button DeleteB;
        private DataGridView dataGridView1;
        private Label label5;
    }
}