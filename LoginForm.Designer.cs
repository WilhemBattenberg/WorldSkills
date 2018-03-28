namespace WindowsFormsApplication2
{
    partial class LoginForm
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
            this.loginbutton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.logintext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Check__in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginbutton.Location = new System.Drawing.Point(16, 76);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(147, 32);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Вход";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exit.Location = new System.Drawing.Point(169, 75);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(145, 33);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // logintext
            // 
            this.logintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logintext.Location = new System.Drawing.Point(100, 12);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(214, 26);
            this.logintext.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password.Location = new System.Drawing.Point(100, 44);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(214, 26);
            this.password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // Check__in
            // 
            this.Check__in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Check__in.Location = new System.Drawing.Point(16, 114);
            this.Check__in.Name = "Check__in";
            this.Check__in.Size = new System.Drawing.Size(298, 33);
            this.Check__in.TabIndex = 6;
            this.Check__in.Text = "Регистрация";
            this.Check__in.UseVisualStyleBackColor = true;
            this.Check__in.Click += new System.EventHandler(this.Check__in_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 153);
            this.Controls.Add(this.Check__in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.loginbutton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox logintext;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Check__in;
    }
}

