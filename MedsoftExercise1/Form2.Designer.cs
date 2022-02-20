
namespace MedsoftExercise1
{
    partial class AddPatientForm
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
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDob = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDob)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(15, 30);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(91, 15);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "გვარი სახელი";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Location = new System.Drawing.Point(12, 180);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(127, 15);
            this.labelDob.TabIndex = 1;
            this.labelDob.Text = "დაბადების თარიღი";
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(185, 180);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(233, 23);
            this.dtpDob.TabIndex = 3;
            this.dtpDob.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDob_Validating);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(15, 80);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(130, 15);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "ტელეფონის ნომერი";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(15, 130);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(74, 15);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "მისამართი";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(185, 30);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(233, 23);
            this.tbFullName.TabIndex = 0;
            this.tbFullName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFullName_Validating);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(185, 80);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(233, 23);
            this.tbPhone.TabIndex = 1;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(185, 130);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(233, 23);
            this.tbAddress.TabIndex = 2;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(15, 230);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(40, 15);
            this.labelGender.TabIndex = 10;
            this.labelGender.Text = "სქესი";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "დამატება";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(397, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "გაუქმება";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorFullName
            // 
            this.errorFullName.ContainerControl = this;
            // 
            // errorPhone
            // 
            this.errorPhone.ContainerControl = this;
            // 
            // errorDob
            // 
            this.errorDob.ContainerControl = this;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(185, 230);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 23);
            this.cbGender.TabIndex = 4;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 331);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.labelFullName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "პაციენტის დამატება";
            ((System.ComponentModel.ISupportInitialize)(this.errorFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorFullName;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.ErrorProvider errorDob;
        private System.Windows.Forms.ComboBox cbGender;
    }
}