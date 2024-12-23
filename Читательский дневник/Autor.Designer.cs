namespace Читательский_дневник
{
    partial class Autor
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(220, 36);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(10, 189);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // button1
            // 
            button1.Location = new Point(157, 232);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(84, 136);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(167, 27);
            LoginTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(84, 186);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(167, 27);
            PasswordTextBox.TabIndex = 5;
            // 
            // Autor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 302);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Autor";
            Text = "Autor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
    }
}