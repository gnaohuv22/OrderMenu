namespace WinFormsApp2
{
    partial class OrderForm
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
            groupBox1 = new GroupBox();
            lbCash = new Label();
            label1 = new Label();
            btnExit = new Button();
            btnCalc = new Button();
            gbAddition = new GroupBox();
            cbxAdd30 = new CheckBox();
            cbxAdd20 = new CheckBox();
            gbDrink = new GroupBox();
            rdbDrink2 = new RadioButton();
            rdbDrink1 = new RadioButton();
            gbFood = new GroupBox();
            nudFood3 = new NumericUpDown();
            nudFood2 = new NumericUpDown();
            nudFood1 = new NumericUpDown();
            cbxFood80 = new CheckBox();
            cbxFood60 = new CheckBox();
            cbxFood70 = new CheckBox();
            groupBox1.SuspendLayout();
            gbAddition.SuspendLayout();
            gbDrink.SuspendLayout();
            gbFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFood3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFood2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFood1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbCash);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnCalc);
            groupBox1.Controls.Add(gbAddition);
            groupBox1.Controls.Add(gbDrink);
            groupBox1.Controls.Add(gbFood);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 428);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // lbCash
            // 
            lbCash.AutoSize = true;
            lbCash.Location = new Point(143, 332);
            lbCash.Name = "lbCash";
            lbCash.Size = new Size(13, 15);
            lbCash.TabIndex = 6;
            lbCash.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 332);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Tổng tiền";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(541, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(167, 375);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Tính";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // gbAddition
            // 
            gbAddition.Controls.Add(cbxAdd30);
            gbAddition.Controls.Add(cbxAdd20);
            gbAddition.Location = new Point(63, 219);
            gbAddition.Name = "gbAddition";
            gbAddition.Size = new Size(655, 84);
            gbAddition.TabIndex = 2;
            gbAddition.TabStop = false;
            gbAddition.Text = "Đồ thêm";
            // 
            // cbxAdd30
            // 
            cbxAdd30.AutoSize = true;
            cbxAdd30.Location = new Point(409, 36);
            cbxAdd30.Name = "cbxAdd30";
            cbxAdd30.Size = new Size(66, 19);
            cbxAdd30.TabIndex = 2;
            cbxAdd30.Text = "lợn (30)";
            cbxAdd30.UseVisualStyleBackColor = true;
            // 
            // cbxAdd20
            // 
            cbxAdd20.AutoSize = true;
            cbxAdd20.Location = new Point(104, 36);
            cbxAdd20.Name = "cbxAdd20";
            cbxAdd20.Size = new Size(63, 19);
            cbxAdd20.TabIndex = 1;
            cbxAdd20.Text = "bò (20)";
            cbxAdd20.UseVisualStyleBackColor = true;
            // 
            // gbDrink
            // 
            gbDrink.Controls.Add(rdbDrink2);
            gbDrink.Controls.Add(rdbDrink1);
            gbDrink.Location = new Point(431, 36);
            gbDrink.Name = "gbDrink";
            gbDrink.Size = new Size(284, 164);
            gbDrink.TabIndex = 1;
            gbDrink.TabStop = false;
            gbDrink.Text = "Đồ uống";
            // 
            // rdbDrink2
            // 
            rdbDrink2.AutoSize = true;
            rdbDrink2.Location = new Point(41, 72);
            rdbDrink2.Name = "rdbDrink2";
            rdbDrink2.Size = new Size(66, 19);
            rdbDrink2.TabIndex = 1;
            rdbDrink2.TabStop = true;
            rdbDrink2.Text = "gnuhn2";
            rdbDrink2.UseVisualStyleBackColor = true;
            // 
            // rdbDrink1
            // 
            rdbDrink1.AutoSize = true;
            rdbDrink1.Location = new Point(41, 34);
            rdbDrink1.Name = "rdbDrink1";
            rdbDrink1.Size = new Size(66, 19);
            rdbDrink1.TabIndex = 0;
            rdbDrink1.TabStop = true;
            rdbDrink1.Text = "gnuhn1";
            rdbDrink1.UseVisualStyleBackColor = true;
            // 
            // gbFood
            // 
            gbFood.Controls.Add(nudFood3);
            gbFood.Controls.Add(nudFood2);
            gbFood.Controls.Add(nudFood1);
            gbFood.Controls.Add(cbxFood80);
            gbFood.Controls.Add(cbxFood60);
            gbFood.Controls.Add(cbxFood70);
            gbFood.Location = new Point(63, 36);
            gbFood.Name = "gbFood";
            gbFood.Size = new Size(283, 164);
            gbFood.TabIndex = 0;
            gbFood.TabStop = false;
            gbFood.Text = "Đồ ăn";
            // 
            // nudFood3
            // 
            nudFood3.Location = new Point(147, 113);
            nudFood3.Name = "nudFood3";
            nudFood3.Size = new Size(120, 23);
            nudFood3.TabIndex = 5;
            // 
            // nudFood2
            // 
            nudFood2.Location = new Point(147, 69);
            nudFood2.Name = "nudFood2";
            nudFood2.Size = new Size(120, 23);
            nudFood2.TabIndex = 4;
            // 
            // nudFood1
            // 
            nudFood1.Location = new Point(147, 30);
            nudFood1.Name = "nudFood1";
            nudFood1.Size = new Size(120, 23);
            nudFood1.TabIndex = 3;
            // 
            // cbxFood80
            // 
            cbxFood80.AutoSize = true;
            cbxFood80.Location = new Point(34, 114);
            cbxFood80.Name = "cbxFood80";
            cbxFood80.Size = new Size(90, 19);
            cbxFood80.TabIndex = 2;
            cbxFood80.Text = "nhung3 (80)";
            cbxFood80.UseVisualStyleBackColor = true;
            cbxFood80.CheckedChanged += cbxFood80_CheckedChanged;
            // 
            // cbxFood60
            // 
            cbxFood60.AutoSize = true;
            cbxFood60.Location = new Point(34, 73);
            cbxFood60.Name = "cbxFood60";
            cbxFood60.Size = new Size(90, 19);
            cbxFood60.TabIndex = 1;
            cbxFood60.Text = "nhung2 (60)";
            cbxFood60.UseVisualStyleBackColor = true;
            cbxFood60.CheckedChanged += cbxFood60_CheckedChanged;
            // 
            // cbxFood70
            // 
            cbxFood70.AutoSize = true;
            cbxFood70.Location = new Point(34, 35);
            cbxFood70.Name = "cbxFood70";
            cbxFood70.Size = new Size(90, 19);
            cbxFood70.TabIndex = 0;
            cbxFood70.Text = "nhung1 (70)";
            cbxFood70.UseVisualStyleBackColor = true;
            cbxFood70.CheckedChanged += cbxFood70_CheckedChanged;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "OrderForm";
            Text = "Order Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbAddition.ResumeLayout(false);
            gbAddition.PerformLayout();
            gbDrink.ResumeLayout(false);
            gbDrink.PerformLayout();
            gbFood.ResumeLayout(false);
            gbFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFood3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFood2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFood1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox gbDrink;
        private GroupBox gbFood;
        private Label lbCash;
        private Label label1;
        private Button btnExit;
        private Button btnCalc;
        private GroupBox gbAddition;
        private CheckBox cbxFood80;
        private CheckBox cbxFood60;
        private CheckBox cbxFood70;
        private CheckBox cbxAdd30;
        private CheckBox cbxAdd20;
        private RadioButton rdbDrink2;
        private RadioButton rdbDrink1;
        private NumericUpDown nudFood3;
        private NumericUpDown nudFood2;
        private NumericUpDown nudFood1;
    }
}
