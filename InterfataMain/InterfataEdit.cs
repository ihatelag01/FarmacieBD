using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfataUtilizator;
using LibrarieModele;
using NivelAccesDate;

namespace InterfataMain
{
    public partial class InterfataEdit : Form
    {
        public InterfataPrincipala interfataPrincipala = new InterfataPrincipala();

        IStocareMedicamente stocareMedicamente=(IStocareMedicamente) new StocareFactory().GetTipStocare(typeof(Medicament));

        private IStocareFurnizori stocareFurnizori = (IStocareFurnizori) new StocareFactory().GetTipStocare((typeof(Furnizor)));


        public InterfataEdit()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Medicament med = new Medicament(Convert.ToInt32(labelID.Text),textBoxEditDenumire.Text,Convert.ToDouble(textBoxEditPret.Text)
                ,dateTimePickerEdit.Value,comboBoxEditFurnizor.SelectedItem.ToString());

            stocareMedicamente.UpdateMedicamente(med);
            
            interfataPrincipala.AfisareMedicamente();
             
            this.Close();
        }

        public void GetListaFurnizori()
        {
            comboBoxEditFurnizor.Items.Clear();
            try
            {
                var lst_furnizori = stocareFurnizori.GetFurnizori();

                foreach (var furnizor in lst_furnizori)
                {
                    comboBoxEditFurnizor.Items.Add(furnizor.denumire);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void comboBoxEditFurnizor_Click(object sender, EventArgs e)
        {
            GetListaFurnizori();
        }

        private void InterfataEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            interfataPrincipala.AfisareMedicamente();
        }

        private void InterfataEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            interfataPrincipala.AfisareMedicamente();
        }

        public void SetLabelID(string id)
        {
            this.labelID.Text = id;
        }

        private void InterfataEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
