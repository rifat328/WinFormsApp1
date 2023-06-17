namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textName = new TextBox();
            textEmail = new TextBox();
            textContact = new TextBox();
            name = new Label();
            email = new Label();
            contact = new Label();
            btn_submit = new Button();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(340, 161);
            textName.Name = "textName";
            textName.Size = new Size(215, 27);
            textName.TabIndex = 0;
            textName.TextChanged += textName_TextChanged;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(338, 212);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(217, 27);
            textEmail.TabIndex = 1;
            textEmail.TextChanged += textEmail_TextChanged;
            // 
            // textContact
            // 
            textContact.Location = new Point(340, 276);
            textContact.Name = "textContact";
            textContact.Size = new Size(215, 27);
            textContact.TabIndex = 2;
            textContact.TextChanged += textContact_TextChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(265, 168);
            name.Name = "name";
            name.Size = new Size(52, 20);
            name.TabIndex = 3;
            name.Text = "Name:";
            name.Click += label1_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(265, 215);
            email.Name = "email";
            email.Size = new Size(49, 20);
            email.TabIndex = 4;
            email.Text = "Email:";
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Location = new Point(265, 283);
            contact.Name = "contact";
            contact.Size = new Size(63, 20);
            contact.TabIndex = 5;
            contact.Text = "Contact:";
            // 
            // btn_submit
            // 
            btn_submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_submit.Location = new Point(340, 331);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(215, 29);
            btn_submit.TabIndex = 6;
            btn_submit.Text = "Save";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btn_submit);
            Controls.Add(contact);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(textContact);
            Controls.Add(textEmail);
            Controls.Add(textName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private TextBox textEmail;
        private TextBox textContact;
        private Label name;
        private Label email;
        private Label contact;
        private Button btn_submit;
    }
}