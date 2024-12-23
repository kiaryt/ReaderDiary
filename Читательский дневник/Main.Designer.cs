namespace Читательский_дневник
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            button5 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(645, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(760, 37);
            button1.Name = "button1";
            button1.Size = new Size(28, 29);
            button1.TabIndex = 1;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Location = new Point(645, 72);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 2;
            button2.Text = "Прочитано";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Salmon;
            button3.Location = new Point(645, 107);
            button3.Name = "button3";
            button3.Size = new Size(143, 29);
            button3.TabIndex = 3;
            button3.Text = "Хочу прочитать";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Salmon;
            button4.Location = new Point(645, 142);
            button4.Name = "button4";
            button4.Size = new Size(143, 29);
            button4.TabIndex = 4;
            button4.Text = "Рекомендации";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(24, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(585, 342);
            dataGridView1.TabIndex = 6;
            // 
            // button6
            // 
            button6.Location = new Point(760, 37);
            button6.Name = "button6";
            button6.Size = new Size(28, 29);
            button6.TabIndex = 7;
            button6.Text = "...";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Salmon;
            button5.Location = new Point(645, 177);
            button5.Name = "button5";
            button5.Size = new Size(143, 28);
            button5.TabIndex = 8;
            button5.Text = "Читаю сейчас";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 14);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 9;
            label2.Text = "Читаю сейчас";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 14);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 10;
            label3.Text = "Прочитано";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 14);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 11;
            label4.Text = "Хочу прочитать";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 14);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 12;
            label5.Text = "Рекомендации";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button6;
        private Button button5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}