namespace elibrary_system
{
    partial class ReturnBookds
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.borrower_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "RETURNING BOOK";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 25);
            this.textBox1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID NUMBER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrower_name,
            this.transaction_id,
            this.borrower,
            this.book_name,
            this.book_id,
            this.number_of_copies,
            this.return_date,
            this.borrow_date,
            this.fines});
            this.dataGridView1.Location = new System.Drawing.Point(43, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 348);
            this.dataGridView1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 32;
            this.button1.Text = "RETURN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 37);
            this.button2.TabIndex = 33;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 37);
            this.button3.TabIndex = 34;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // borrower_name
            // 
            this.borrower_name.HeaderText = "Borrower Name";
            this.borrower_name.Name = "borrower_name";
            this.borrower_name.Width = 97;
            // 
            // transaction_id
            // 
            this.transaction_id.HeaderText = "BOOKS";
            this.transaction_id.Name = "transaction_id";
            this.transaction_id.Width = 69;
            // 
            // borrower
            // 
            this.borrower.HeaderText = "Borrower";
            this.borrower.Name = "borrower";
            this.borrower.Width = 74;
            // 
            // book_name
            // 
            this.book_name.HeaderText = "Book Name";
            this.book_name.Name = "book_name";
            this.book_name.Width = 81;
            // 
            // book_id
            // 
            this.book_id.HeaderText = "Book ID";
            this.book_id.Name = "book_id";
            this.book_id.Width = 66;
            // 
            // number_of_copies
            // 
            this.number_of_copies.HeaderText = "Copies";
            this.number_of_copies.Name = "number_of_copies";
            this.number_of_copies.Width = 64;
            // 
            // return_date
            // 
            this.return_date.HeaderText = "Return Date";
            this.return_date.Name = "return_date";
            this.return_date.Width = 83;
            // 
            // borrow_date
            // 
            this.borrow_date.HeaderText = "Borrow Date";
            this.borrow_date.Name = "borrow_date";
            this.borrow_date.Width = 84;
            // 
            // fines
            // 
            this.fines.HeaderText = "Fines";
            this.fines.Name = "fines";
            this.fines.Width = 57;
            // 
            // ReturnBookds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 551);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBookds";
            this.Text = "ReturnBookds";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrower_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_of_copies;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fines;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}