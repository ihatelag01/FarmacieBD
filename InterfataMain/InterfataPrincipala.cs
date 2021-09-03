using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using InterfataUtilizator;
using LibrarieModele;
using NivelAccesDate;


namespace InterfataMain
{
    public partial class InterfataPrincipala : Form
    {
        IStocareMedicamente stocareMedicamente =
            (IStocareMedicamente)new StocareFactory().GetTipStocare(typeof(Medicament));

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
                    dataGridMed.DataSource = medicamente
                        .Select(med => new { med.id, med.pret, med.denumire, med.dataExpirare, med.furnizor }).ToList();
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

            if (ValidareIdMedicament() && ValidareTextBoxMedicament())
            {
                stocareMedicamente.AddMedicament(m);
                AfisareMedicamente();
            }
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
            comboBoxFurnizor.Items.Clear();
            try
            {
                var lst_furnizori = stocareFurnizori.GetFurnizori();

                foreach (var furnizor in lst_furnizori)
                {
                    comboBoxFurnizor.Items.Add(furnizor.denumire);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void comboBoxFurnizor_Click(object sender, EventArgs e)
        {
            comboBoxFurnizor.Items.Clear();
            GetListaFurnizori();
        }
        private void buttonAddFurnizori_Click(object sender, EventArgs e)
        {
            Furnizor f = new Furnizor(textBoxDenumireFurnizor.Text, textBoxAdresa.Text, textBoxTara.Text);

            if (ValidareTextBoxFurnizor() && ValidareDenumireFurnizor())
            {
                stocareFurnizori.AddFurnizor(f);
                GetListaFurnizori();
            }
        }
        private bool ValidareDate()
        {
            if (ValidareTextBoxFurnizor() && ValidareDenumireFurnizor() && ValidareTextBoxMedicament() && ValidareIdMedicament())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidareTextBoxMedicament()
        {
            if (textBoxDenumire.Text == "" || textBoxDenumire.Text.Length > 20 || textBoxPret.Text == "")
            {
                labelDenumire.ForeColor = Color.Red;
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidareIdMedicament()
        {
            List<Medicament> list_medicamente = stocareMedicamente.GetMedicamente();

            bool flag = true;

            foreach (var medicament in list_medicamente)
            {
                if (Int32.Parse(textBoxId.Text) == medicament.id)
                {
                    label_ID.ForeColor = Color.Red;
                    flag = false;
                }
            }

            return flag;
        }
        private bool ValidareTextBoxFurnizor()
        {
            bool flag = true;

            if (textBoxDenumireFurnizor.Text == "" || textBoxDenumireFurnizor.Text.Length > 20 ||
                textBoxAdresa.Text == "" || textBoxAdresa.Text.Length > 100 || textBoxTara.Text == "" ||
                textBoxTara.Text.Length > 20)
            {
                labelDenumireFurnizor.ForeColor = Color.Red;
                labelAdresa.ForeColor = Color.Red;
                labelTara.ForeColor = Color.Red;
                flag = false;
            }

            return flag;
        }
        private bool ValidareDenumireFurnizor()
        {
            List<Furnizor> list_furnizori = stocareFurnizori.GetFurnizori();

            bool flag = true;

            foreach (var furnizor in list_furnizori)
            {
                if (textBoxDenumireFurnizor.Text == furnizor.denumire)
                {
                    labelDenumireFurnizor.ForeColor = Color.Red;
                    flag = false;
                }
            }

            return flag;
        }

        private void dataGridMed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InterfataEdit interfataEditare = new InterfataEdit();
            string idMedicament = dataGridMed[0, dataGridMed.CurrentCell.RowIndex].Value.ToString();
            interfataEditare.SetLabelID(idMedicament);
            interfataEditare.Show();
        }

         
    }
}
