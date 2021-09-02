
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfataPrincipala));
            this.dataGridMed = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.labelFurnizor = new System.Windows.Forms.Label();
            this.comboBoxFurnizor = new System.Windows.Forms.ComboBox();
            this.labelDenumireFurnizor = new System.Windows.Forms.Label();
            this.textBoxDenumireFurnizor = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.textBoxTara = new System.Windows.Forms.TextBox();
            this.labelTara = new System.Windows.Forms.Label();
            this.buttonAddFurnizor = new System.Windows.Forms.Button();
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
            this.dataGridMed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMed_CellDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 409);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Ivory;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonAdd.Location = new System.Drawing.Point(3, 505);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(244, 36);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Adaugare medicament";
            this.buttonAdd.UseVisualStyleBackColor = false;
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
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.BackColor = System.Drawing.Color.Transparent;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.Color.Black;
            this.label_ID.Location = new System.Drawing.Point(3, 268);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(28, 17);
            this.label_ID.TabIndex = 11;
            this.label_ID.Text = "ID:";
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.BackColor = System.Drawing.Color.Transparent;
            this.labelDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.ForeColor = System.Drawing.Color.Black;
            this.labelDenumire.Location = new System.Drawing.Point(3, 318);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(82, 17);
            this.labelDenumire.TabIndex = 12;
            this.labelDenumire.Text = "Denumire:";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.BackColor = System.Drawing.Color.Transparent;
            this.labelPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPret.ForeColor = System.Drawing.Color.Black;
            this.labelPret.Location = new System.Drawing.Point(3, 364);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(43, 17);
            this.labelPret.TabIndex = 13;
            this.labelPret.Text = "Pret:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Black;
            this.labelData.Location = new System.Drawing.Point(0, 409);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(111, 17);
            this.labelData.TabIndex = 15;
            this.labelData.Text = "Data expirare:";
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(117, 364);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 22);
            this.textBoxPret.TabIndex = 9;
            // 
            // labelFurnizor
            // 
            this.labelFurnizor.AutoSize = true;
            this.labelFurnizor.BackColor = System.Drawing.Color.Transparent;
            this.labelFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFurnizor.ForeColor = System.Drawing.Color.Black;
            this.labelFurnizor.Location = new System.Drawing.Point(3, 454);
            this.labelFurnizor.Name = "labelFurnizor";
            this.labelFurnizor.Size = new System.Drawing.Size(73, 17);
            this.labelFurnizor.TabIndex = 18;
            this.labelFurnizor.Text = "Furnizor:";
            // 
            // comboBoxFurnizor
            // 
            this.comboBoxFurnizor.FormattingEnabled = true;
            this.comboBoxFurnizor.Location = new System.Drawing.Point(117, 454);
            this.comboBoxFurnizor.Name = "comboBoxFurnizor";
            this.comboBoxFurnizor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFurnizor.TabIndex = 19;
            this.comboBoxFurnizor.Click += new System.EventHandler(this.comboBoxFurnizor_Click);
            // 
            // labelDenumireFurnizor
            // 
            this.labelDenumireFurnizor.AutoSize = true;
            this.labelDenumireFurnizor.BackColor = System.Drawing.Color.Transparent;
            this.labelDenumireFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumireFurnizor.ForeColor = System.Drawing.Color.Black;
            this.labelDenumireFurnizor.Location = new System.Drawing.Point(532, 268);
            this.labelDenumireFurnizor.Name = "labelDenumireFurnizor";
            this.labelDenumireFurnizor.Size = new System.Drawing.Size(82, 17);
            this.labelDenumireFurnizor.TabIndex = 20;
            this.labelDenumireFurnizor.Text = "Denumire:";
            // 
            // textBoxDenumireFurnizor
            // 
            this.textBoxDenumireFurnizor.Location = new System.Drawing.Point(632, 265);
            this.textBoxDenumireFurnizor.Name = "textBoxDenumireFurnizor";
            this.textBoxDenumireFurnizor.Size = new System.Drawing.Size(100, 22);
            this.textBoxDenumireFurnizor.TabIndex = 21;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(632, 312);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdresa.TabIndex = 22;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.BackColor = System.Drawing.Color.Transparent;
            this.labelAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresa.ForeColor = System.Drawing.Color.Black;
            this.labelAdresa.Location = new System.Drawing.Point(532, 315);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(64, 17);
            this.labelAdresa.TabIndex = 23;
            this.labelAdresa.Text = "Adresa:";
            // 
            // textBoxTara
            // 
            this.textBoxTara.Location = new System.Drawing.Point(632, 359);
            this.textBoxTara.Name = "textBoxTara";
            this.textBoxTara.Size = new System.Drawing.Size(100, 22);
            this.textBoxTara.TabIndex = 24;
            // 
            // labelTara
            // 
            this.labelTara.AutoSize = true;
            this.labelTara.BackColor = System.Drawing.Color.Transparent;
            this.labelTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTara.ForeColor = System.Drawing.Color.Black;
            this.labelTara.Location = new System.Drawing.Point(535, 364);
            this.labelTara.Name = "labelTara";
            this.labelTara.Size = new System.Drawing.Size(47, 17);
            this.labelTara.TabIndex = 25;
            this.labelTara.Text = "Tara:";
            // 
            // buttonAddFurnizor
            // 
            this.buttonAddFurnizor.BackColor = System.Drawing.Color.Ivory;
            this.buttonAddFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFurnizor.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonAddFurnizor.Location = new System.Drawing.Point(538, 407);
            this.buttonAddFurnizor.Name = "buttonAddFurnizor";
            this.buttonAddFurnizor.Size = new System.Drawing.Size(194, 38);
            this.buttonAddFurnizor.TabIndex = 26;
            this.buttonAddFurnizor.Text = "Adaugare furnizor";
            this.buttonAddFurnizor.UseVisualStyleBackColor = false;
            this.buttonAddFurnizor.Click += new System.EventHandler(this.buttonAddFurnizori_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Ivory;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonDelete.Location = new System.Drawing.Point(3, 547);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(244, 36);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Stergere medicament";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // InterfataPrincipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(744, 606);
            this.Controls.Add(this.buttonAddFurnizor);
            this.Controls.Add(this.labelTara);
            this.Controls.Add(this.textBoxTara);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxDenumireFurnizor);
            this.Controls.Add(this.labelDenumireFurnizor);
            this.Controls.Add(this.comboBoxFurnizor);
            this.Controls.Add(this.labelFurnizor);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridMed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfataPrincipala";
            this.Text = "FarmacieBD";
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
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.Label labelFurnizor;
        private System.Windows.Forms.ComboBox comboBoxFurnizor;
        private System.Windows.Forms.Label labelDenumireFurnizor;
        private System.Windows.Forms.TextBox textBoxDenumireFurnizor;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox textBoxTara;
        private System.Windows.Forms.Label labelTara;
        private System.Windows.Forms.Button buttonAddFurnizor;
    }
}

