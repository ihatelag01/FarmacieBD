using System;
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
                    dataGridMed.DataSource = medicamente.Select(med => new { med.id, med.pret, med.denumire, med.dataExpirare, med.tipDepozitare }).ToList();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Medicament m = new Medicament(Convert.ToInt32(textBoxId.Text),textBoxDenumire.Text,Convert.ToDouble(textBoxPret.Text),
                Convert.ToDateTime(dateTimePicker1.Text),Convert.ToInt32(textBoxDepo.Text));

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
    }
}
