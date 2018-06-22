namespace MVC
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
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelTypePr = new System.Windows.Forms.Label();
            this.comboBoxTypePr = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(117, 32);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUser.TabIndex = 0;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(24, 35);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User";
            // 
            // labelTypePr
            // 
            this.labelTypePr.AutoSize = true;
            this.labelTypePr.Location = new System.Drawing.Point(24, 85);
            this.labelTypePr.Name = "labelTypePr";
            this.labelTypePr.Size = new System.Drawing.Size(87, 13);
            this.labelTypePr.TabIndex = 2;
            this.labelTypePr.Text = "Type of products";
            // 
            // comboBoxTypePr
            // 
            this.comboBoxTypePr.FormattingEnabled = true;
            this.comboBoxTypePr.Location = new System.Drawing.Point(117, 77);
            this.comboBoxTypePr.Name = "comboBoxTypePr";
            this.comboBoxTypePr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypePr.TabIndex = 3;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(24, 125);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(44, 13);
            this.labelProduct.TabIndex = 4;
            this.labelProduct.Text = "Product";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(117, 125);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduct.TabIndex = 5;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(24, 170);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "Number";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(117, 163);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 7;
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(366, 27);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(307, 32);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.comboBoxTypePr);
            this.Controls.Add(this.labelTypePr);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelTypePr;
        private System.Windows.Forms.ComboBox comboBoxTypePr;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button button1;
    }
}

