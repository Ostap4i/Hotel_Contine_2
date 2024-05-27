namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            loginName = new TextBox();
            loginPassword = new TextBox();
            button1 = new Button();
            loggedMessage = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(178, 111);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 24);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(178, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 24);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // loginName
            // 
            loginName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginName.Location = new Point(178, 138);
            loginName.Margin = new Padding(4, 3, 4, 3);
            loginName.Name = "loginName";
            loginName.Size = new Size(552, 26);
            loginName.TabIndex = 2;
            // 
            // loginPassword
            // 
            loginPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginPassword.Location = new Point(178, 194);
            loginPassword.Margin = new Padding(4, 3, 4, 3);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(552, 26);
            loginPassword.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(178, 259);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(552, 44);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loggedMessage
            // 
            loggedMessage.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loggedMessage.Location = new Point(178, 364);
            loggedMessage.Margin = new Padding(4, 3, 4, 3);
            loggedMessage.Name = "loggedMessage";
            loggedMessage.Size = new Size(552, 68);
            loggedMessage.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(412, 27);
            label3.Name = "label3";
            label3.Size = new Size(131, 50);
            label3.TabIndex = 6;
            label3.Text = "Log In";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(label3);
            Controls.Add(loggedMessage);
            Controls.Add(button1);
            Controls.Add(loginPassword);
            Controls.Add(loginName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginName;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox loggedMessage;
        private Label label3;
    }
}

