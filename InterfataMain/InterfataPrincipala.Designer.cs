
namespace InterfataMain
{
    partial class InterfataPrincipala
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
            this.dataGridMed = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxDepo = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelDepozitare = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMed)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMed
            // 
            this.dataGridMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMed.Location = new System.Drawing.Point(3, 12);
            this.dataGridMed.Name = "dataGridMed";
            this.dataGridMed.RowHeadersWidth = 51;
            this.dataGridMed.RowTemplate.Height = 24;
            this.dataGridMed.Size = new System.Drawing.Size(737, 233);
            this.dataGridMed.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 460);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 507);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(244, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Adaugare";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(117, 268);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 7;
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(117, 315);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(100, 22);
            this.textBoxDenumire.TabIndex = 8;
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(117, 418);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 22);
            this.textBoxPret.TabIndex = 9;
            // 
            // textBoxDepo
            // 
            this.textBoxDepo.Location = new System.Drawing.Point(117, 364);
            this.textBoxDepo.Name = "textBoxDepo";
            this.textBoxDepo.Size = new System.Drawing.Size(100, 22);
            this.textBoxDepo.TabIndex = 10;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(3, 268);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(28, 17);
            this.label_ID.TabIndex = 11;
            this.label_ID.Text = "ID:";
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.Location = new System.Drawing.Point(3, 318);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(82, 17);
            this.labelDenumire.TabIndex = 12;
            this.labelDenumire.Text = "Denumire:";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPret.Location = new System.Drawing.Point(3, 364);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(43, 17);
            this.labelPret.TabIndex = 13;
            this.labelPret.Text = "Pret:";
            // 
            // labelDepozitare
            // 
            this.labelDepozitare.AutoSize = true;
            this.labelDepozitare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepozitare.Location = new System.Drawing.Point(3, 421);
            this.labelDepozitare.Name = "labelDepozitare";
            this.labelDepozitare.Size = new System.Drawing.Size(92, 17);
            this.labelDepozitare.TabIndex = 14;
            this.labelDepozitare.Text = "Depozitare:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(0, 460);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(111, 17);
            this.labelData.TabIndex = 15;
            this.labelData.Text = "Data expirare:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 551);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(244, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Stergere";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // InterfataPrincipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 606);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelDepozitare);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBoxDepo);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridMed);
            this.Name = "InterfataPrincipala";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterfataPrincipala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMed;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxDepo;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelDepozitare;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonDelete;
    }
}

