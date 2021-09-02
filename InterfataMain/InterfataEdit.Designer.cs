
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
            this.labelEditID = new System.Windows.Forms.Label();
            this.labelEditPret = new System.Windows.Forms.Label();
            this.dateTimePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelEditFurnizor = new System.Windows.Forms.Label();
            this.textBoxEditID = new System.Windows.Forms.TextBox();
            this.textBoxEditDenumire = new System.Windows.Forms.TextBox();
            this.textBoxEditPret = new System.Windows.Forms.TextBox();
            this.labelEditData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEditDenumire
            // 
            this.labelEditDenumire.AutoSize = true;
            this.labelEditDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditDenumire.Location = new System.Drawing.Point(6, 71);
            this.labelEditDenumire.Name = "labelEditDenumire";
            this.labelEditDenumire.Size = new System.Drawing.Size(82, 17);
            this.labelEditDenumire.TabIndex = 0;
            this.labelEditDenumire.Text = "Denumire:";
            // 
            // labelEditID
            // 
            this.labelEditID.AutoSize = true;
            this.labelEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditID.Location = new System.Drawing.Point(6, 24);
            this.labelEditID.Name = "labelEditID";
            this.labelEditID.Size = new System.Drawing.Size(28, 17);
            this.labelEditID.TabIndex = 1;
            this.labelEditID.Text = "ID:";
            // 
            // labelEditPret
            // 
            this.labelEditPret.AutoSize = true;
            this.labelEditPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditPret.Location = new System.Drawing.Point(6, 112);
            this.labelEditPret.Name = "labelEditPret";
            this.labelEditPret.Size = new System.Drawing.Size(43, 17);
            this.labelEditPret.TabIndex = 2;
            this.labelEditPret.Text = "Pret:";
            // 
            // dateTimePickerEdit
            // 
            this.dateTimePickerEdit.Location = new System.Drawing.Point(123, 160);
            this.dateTimePickerEdit.Name = "dateTimePickerEdit";
            this.dateTimePickerEdit.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEdit.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // labelEditFurnizor
            // 
            this.labelEditFurnizor.AutoSize = true;
            this.labelEditFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditFurnizor.Location = new System.Drawing.Point(6, 197);
            this.labelEditFurnizor.Name = "labelEditFurnizor";
            this.labelEditFurnizor.Size = new System.Drawing.Size(73, 17);
            this.labelEditFurnizor.TabIndex = 5;
            this.labelEditFurnizor.Text = "Furnizor:";
            // 
            // textBoxEditID
            // 
            this.textBoxEditID.Location = new System.Drawing.Point(123, 24);
            this.textBoxEditID.Name = "textBoxEditID";
            this.textBoxEditID.Size = new System.Drawing.Size(100, 22);
            this.textBoxEditID.TabIndex = 6;
            // 
            // textBoxEditDenumire
            // 
            this.textBoxEditDenumire.Location = new System.Drawing.Point(123, 68);
            this.textBoxEditDenumire.Name = "textBoxEditDenumire";
            this.textBoxEditDenumire.Size = new System.Drawing.Size(100, 22);
            this.textBoxEditDenumire.TabIndex = 7;
            // 
            // textBoxEditPret
            // 
            this.textBoxEditPret.Location = new System.Drawing.Point(123, 112);
            this.textBoxEditPret.Name = "textBoxEditPret";
            this.textBoxEditPret.Size = new System.Drawing.Size(100, 22);
            this.textBoxEditPret.TabIndex = 8;
            // 
            // labelEditData
            // 
            this.labelEditData.AutoSize = true;
            this.labelEditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditData.Location = new System.Drawing.Point(6, 160);
            this.labelEditData.Name = "labelEditData";
            this.labelEditData.Size = new System.Drawing.Size(111, 17);
            this.labelEditData.TabIndex = 9;
            this.labelEditData.Text = "Data expirare:";
            // 
            // InterfataEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEditData);
            this.Controls.Add(this.textBoxEditPret);
            this.Controls.Add(this.textBoxEditDenumire);
            this.Controls.Add(this.textBoxEditID);
            this.Controls.Add(this.labelEditFurnizor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePickerEdit);
            this.Controls.Add(this.labelEditPret);
            this.Controls.Add(this.labelEditID);
            this.Controls.Add(this.labelEditDenumire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfataEdit";
            this.Text = "Editare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditDenumire;
        private System.Windows.Forms.Label labelEditID;
        private System.Windows.Forms.Label labelEditPret;
        private System.Windows.Forms.DateTimePicker dateTimePickerEdit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelEditFurnizor;
        private System.Windows.Forms.TextBox textBoxEditID;
        private System.Windows.Forms.TextBox textBoxEditDenumire;
        private System.Windows.Forms.TextBox textBoxEditPret;
        private System.Windows.Forms.Label labelEditData;
    }
}