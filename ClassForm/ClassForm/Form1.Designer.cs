namespace ClassForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreate = new Button();
            dgvArray = new DataGridView();
            txtMinValue = new TextBox();
            numericSize = new NumericUpDown();
            button1 = new Button();
            numericMinIndex = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvArray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMinIndex).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 35);
            label1.Name = "label1";
            label1.Size = new Size(218, 23);
            label1.TabIndex = 7;
            label1.Text = "Введите размер массива";
            // 
            // label2
            // 
            label2.Location = new Point(0, 116);
            label2.Name = "label2";
            label2.Size = new Size(234, 23);
            label2.TabIndex = 5;
            label2.Text = "Введите минимальный индекс";
            // 
            // label3
            // 
            label3.Location = new Point(0, 170);
            label3.Name = "label3";
            label3.Size = new Size(245, 23);
            label3.TabIndex = 3;
            label3.Text = "Введите минимальное значение";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(174, 73);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(84, 28);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Создать";
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvArray
            // 
            dgvArray.ColumnHeadersHeight = 29;
            dgvArray.Location = new Point(482, 12);
            dgvArray.Name = "dgvArray";
            dgvArray.RowHeadersWidth = 51;
            dgvArray.Size = new Size(611, 109);
            dgvArray.TabIndex = 0;
            // 
            // txtMinValue
            // 
            txtMinValue.Location = new Point(279, 170);
            txtMinValue.Name = "txtMinValue";
            txtMinValue.Size = new Size(125, 27);
            txtMinValue.TabIndex = 10;
            // 
            // numericSize
            // 
            numericSize.Location = new Point(279, 33);
            numericSize.Name = "numericSize";
            numericSize.Size = new Size(150, 27);
            numericSize.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(174, 224);
            button1.Name = "button1";
            button1.Size = new Size(97, 28);
            button1.TabIndex = 16;
            button1.Text = "Рассчитать";
            button1.Click += btnCalculate_Click;
            // 
            // numericMinIndex
            // 
            numericMinIndex.Location = new Point(279, 112);
            numericMinIndex.Name = "numericMinIndex";
            numericMinIndex.Size = new Size(150, 27);
            numericMinIndex.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 569);
            Controls.Add(numericMinIndex);
            Controls.Add(button1);
            Controls.Add(numericSize);
            Controls.Add(txtMinValue);
            Controls.Add(dgvArray);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Lab_7";
            ((System.ComponentModel.ISupportInitialize)dgvArray).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMinIndex).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCreate;
        private DataGridView dgvArray;
        private TextBox txtMinValue;
        private NumericUpDown numericSize;
        private Button button1;
        private NumericUpDown numericMinIndex;
    }
}
