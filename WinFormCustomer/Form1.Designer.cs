using CustomerInterface;

namespace WinFormCustomer
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.leadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_BillAmount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_BillDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.customerBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer",
            "Lead"});
            this.comboBox1.Location = new System.Drawing.Point(99, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadBindingSource, "CustomerName", true));
            this.textBox_CustomerName.Location = new System.Drawing.Point(415, 18);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(181, 20);
            this.textBox_CustomerName.TabIndex = 1;
            this.textBox_CustomerName.Text = "hla";
            this.textBox_CustomerName.TextChanged += new System.EventHandler(this.textBox_CustomerName_TextChanged);
            // 
            // leadBindingSource
            // 
            this.leadBindingSource.DataSource = typeof(CustomerInterface.ICustomer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone Number";
            // 
            // textBox1_PhoneNumber
            // 
            this.textBox1_PhoneNumber.Location = new System.Drawing.Point(415, 66);
            this.textBox1_PhoneNumber.Name = "textBox1_PhoneNumber";
            this.textBox1_PhoneNumber.Size = new System.Drawing.Size(181, 20);
            this.textBox1_PhoneNumber.TabIndex = 3;
            this.textBox1_PhoneNumber.Text = "8787878787";
            this.textBox1_PhoneNumber.TextChanged += new System.EventHandler(this.textBox1_PhoneNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bill Amount";
            // 
            // textBox1_BillAmount
            // 
            this.textBox1_BillAmount.Location = new System.Drawing.Point(415, 117);
            this.textBox1_BillAmount.Name = "textBox1_BillAmount";
            this.textBox1_BillAmount.Size = new System.Drawing.Size(181, 20);
            this.textBox1_BillAmount.TabIndex = 5;
            this.textBox1_BillAmount.TextChanged += new System.EventHandler(this.textBox1_BillAmount_TextChanged);
            // 
            // dateTimePicker1_BillDate
            // 
            this.dateTimePicker1_BillDate.Location = new System.Drawing.Point(415, 165);
            this.dateTimePicker1_BillDate.Name = "dateTimePicker1_BillDate";
            this.dateTimePicker1_BillDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1_BillDate.TabIndex = 7;
            this.dateTimePicker1_BillDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_BillDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bill Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // textBox1_Address
            // 
            this.textBox1_Address.Location = new System.Drawing.Point(415, 219);
            this.textBox1_Address.Name = "textBox1_Address";
            this.textBox1_Address.Size = new System.Drawing.Size(181, 20);
            this.textBox1_Address.TabIndex = 9;
            this.textBox1_Address.TextChanged += new System.EventHandler(this.textBox1_Address_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerBaseBindingSource
            // 
            this.customerBaseBindingSource.DataSource = typeof(CustomerInterface.ICustomer);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 178);
            this.dataGridView1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1_BillDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1_BillAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_PhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CustomerName);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_PhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_BillAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_BillDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource customerBaseBindingSource;
        private System.Windows.Forms.BindingSource leadBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}

