using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InterfataUtilizator;
using LibrarieModele;
using NivelAccesDate;


namespace InterfataMain
{
    public partial class InterfataPrincipala : Form
    {
        IStocareMedicamente stocareMedicamente = (IStocareMedicamente)new StocareFactory().GetTipStocare(typeof(Medicament));
        IStocareFurnizori stocareFurnizori = (IStocareFurnizori)new StocareFactory().GetTipStocare(typeof(Furnizor));
        public InterfataPrincipala()
        {
            InitializeComponent();
        }

        private void InterfataPrincipala_Load(object sender, EventArgs e)
        {
            AfisareMedicamente();
        }

        public void AfisareMedicamente()
        {
            try
            {
                var medicamente = stocareMedicamente.GetMedicamente();

                if ((medicamente != null))
                {
                    dataGridMed.DataSource = medicamente.Select(med => new { med.id, med.pret, med.denumire, med.dataExpirare,med.furnizor}).ToList();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Medicament m = new Medicament(Convert.ToInt32(textBoxId.Text), textBoxDenumire.Text,
                Convert.ToDouble(textBoxPret.Text),
                Convert.ToDateTime(dateTimePicker1.Text), comboBoxFurnizor.SelectedItem.ToString());

            if(stocareMedicamente.AddMedicament(m))
                AfisareMedicamente();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int inregistareSelectata = dataGridMed.CurrentCell.RowIndex;

            int id = Int32.Parse(dataGridMed[0, inregistareSelectata].Value.ToString());

            stocareMedicamente.DeleteMedicament(id);

            AfisareMedicamente();

        }

        public void GetListaFurnizori()
        {
            try
            { 
                var furnizori = stocareFurnizori.GetFurnizori();

                if (furnizori != null)
                {
                    foreach (var furnizor in furnizori)
                    {
                        comboBoxFurnizor.Items.Add(furnizor.denumire);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void comboBoxFurnizor_Click(object sender, EventArgs e)
        {
            comboBoxFurnizor.Items.Clear();
            GetListaFurnizori();
        }
    }
}
