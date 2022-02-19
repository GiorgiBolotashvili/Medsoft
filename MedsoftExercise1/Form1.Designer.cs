
namespace MedsoftExercise1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tslAdd = new System.Windows.Forms.ToolStripLabel();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tslEdit = new System.Windows.Forms.ToolStripLabel();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tslDelete = new System.Windows.Forms.ToolStripLabel();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tslAdd,
            this.tsbEdit,
            this.tslEdit,
            this.tsbDelete,
            this.tslDelete});
            this.tsMenu.Location = new System.Drawing.Point(5, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(836, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "დამატება";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tslAdd
            // 
            this.tslAdd.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tslAdd.Name = "tslAdd";
            this.tslAdd.Size = new System.Drawing.Size(65, 22);
            this.tslAdd.Text = "დამატება";
            this.tslAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "რედაქტირება";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tslEdit
            // 
            this.tslEdit.Name = "tslEdit";
            this.tslEdit.Size = new System.Drawing.Size(89, 22);
            this.tslEdit.Text = "რედაქტირება";
            this.tslEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "წაშლა";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tslDelete
            // 
            this.tslDelete.Name = "tslDelete";
            this.tslDelete.Size = new System.Drawing.Size(48, 22);
            this.tslDelete.Text = "წაშლა";
            this.tslDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.AllowUserToAddRows = false;
            this.dgvPatientList.AllowUserToDeleteRows = false;
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientList.Location = new System.Drawing.Point(5, 25);
            this.dgvPatientList.MultiSelect = false;
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.ReadOnly = true;
            this.dgvPatientList.RowTemplate.Height = 25;
            this.dgvPatientList.Size = new System.Drawing.Size(836, 409);
            this.dgvPatientList.TabIndex = 0;
            this.dgvPatientList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPatientList_CellMouseDown);
            this.dgvPatientList.DoubleClick += new System.EventHandler(this.tsbEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 439);
            this.Controls.Add(this.dgvPatientList);
            this.Controls.Add(this.tsMenu);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medsoft";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enter += new System.EventHandler(this.MainForm_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripLabel tslAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripLabel tslEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripLabel tslDelete;
        private System.Windows.Forms.DataGridView dgvPatientList;
    }
}

