
namespace InterfataMain
{
    partial class InterfataEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfataEdit));
            this.labelEditDenumire = new System.Windows.Forms.Label();
            this.labelEditPret = new System.Windows.Forms.Label();
            this.dateTimePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEditFurnizor = new System.Windows.Forms.ComboBox();
            this.labelEditFurnizor = new System.Windows.Forms.Label();
            this.textBoxEditDenumire = new System.Windows.Forms.TextBox();
            this.textBoxEditPret = new System.Windows.Forms.TextBox();
            this.labelEditData = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEditDenumire
            // 
            this.labelEditDenumire.AutoSize = true;
            this.labelEditDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditDenumire.Location = new System.Drawing.Point(6, 28);
            this.labelEditDenumire.Name = "labelEditDenumire";
            this.labelEditDenumire.Size = new System.Drawing.Size(82, 17);
            this.labelEditDenumire.TabIndex = 0;
            this.labelEditDenumire.Text = "Denumire:";
            // 
            // labelEditPret
            // 
            this.labelEditPret.AutoSize = true;
            this.labelEditPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditPret.Location = new System.Drawing.Point(6, 72);
            this.labelEditPret.Name = "labelEditPret";
            this.labelEditPret.Size = new System.Drawing.Size(43, 17);
            this.labelEditPret.TabIndex = 2;
            this.labelEditPret.Text = "Pret:";
            // 
            // dateTimePickerEdit
            // 
            this.dateTimePickerEdit.Location = new System.Drawing.Point(123, 111);
            this.dateTimePickerEdit.Name = "dateTimePickerEdit";
            this.dateTimePickerEdit.Size = new System.Drawing.Size(154, 22);
            this.dateTimePickerEdit.TabIndex = 3;
            // 
            // comboBoxEditFurnizor
            // 
            this.comboBoxEditFurnizor.FormattingEnabled = true;
            this.comboBoxEditFurnizor.Location = new System.Drawing.Point(123, 154);
            this.comboBoxEditFurnizor.Name = "comboBoxEditFurnizor";
            this.comboBoxEditFurnizor.Size = new System.Drawing.Size(154, 24);
            this.comboBoxEditFurnizor.TabIndex = 4;
            this.comboBoxEditFurnizor.Click += new System.EventHandler(this.comboBoxEditFurnizor_Click);
            // 
            // labelEditFurnizor
            // 
            this.labelEditFurnizor.AutoSize = true;
            this.labelEditFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditFurnizor.Location = new System.Drawing.Point(6, 161);
            this.labelEditFurnizor.Name = "labelEditFurnizor";
            this.labelEditFurnizor.Size = new System.Drawing.Size(73, 17);
            this.labelEditFurnizor.TabIndex = 5;
            this.labelEditFurnizor.Text = "Furnizor:";
            // 
            // textBoxEditDenumire
            // 
            this.textBoxEditDenumire.Location = new System.Drawing.Point(123, 28);
            this.textBoxEditDenumire.Name = "textBoxEditDenumire";
            this.textBoxEditDenumire.Size = new System.Drawing.Size(154, 22);
            this.textBoxEditDenumire.TabIndex = 7;
            // 
            // textBoxEditPret
            // 
            this.textBoxEditPret.Location = new System.Drawing.Point(123, 69);
            this.textBoxEditPret.Name = "textBoxEditPret";
            this.textBoxEditPret.Size = new System.Drawing.Size(154, 22);
            this.textBoxEditPret.TabIndex = 8;
            // 
            // labelEditData
            // 
            this.labelEditData.AutoSize = true;
            this.labelEditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditData.Location = new System.Drawing.Point(6, 116);
            this.labelEditData.Name = "labelEditData";
            this.labelEditData.Size = new System.Drawing.Size(111, 17);
            this.labelEditData.TabIndex = 9;
            this.labelEditData.Text = "Data expirare:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Ivory;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonUpdate.Location = new System.Drawing.Point(9, 199);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(268, 33);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Actualiazare informatii";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(543, 140);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 17);
            this.labelID.TabIndex = 11;
            this.labelID.Text = "label1";
            this.labelID.Visible = false;
            // 
            // InterfataEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(289, 450);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelEditData);
            this.Controls.Add(this.textBoxEditPret);
            this.Controls.Add(this.textBoxEditDenumire);
            this.Controls.Add(this.labelEditFurnizor);
            this.Controls.Add(this.comboBoxEditFurnizor);
            this.Controls.Add(this.dateTimePickerEdit);
            this.Controls.Add(this.labelEditPret);
            this.Controls.Add(this.labelEditDenumire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfataEdit";
            this.Text = "Editare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterfataEdit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfataEdit_FormClosed);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditDenumire;
        private System.Windows.Forms.Label labelEditPret;
        private System.Windows.Forms.DateTimePicker dateTimePickerEdit;
        private System.Windows.Forms.ComboBox comboBoxEditFurnizor;
        private System.Windows.Forms.Label labelEditFurnizor;
        private System.Windows.Forms.TextBox textBoxEditDenumire;
        private System.Windows.Forms.TextBox textBoxEditPret;
        private System.Windows.Forms.Label labelEditData;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelID;
    }
}