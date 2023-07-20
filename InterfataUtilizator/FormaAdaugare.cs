using System;
using System.Linq;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace InterfataUtilizator
{
    public partial class FormaAdaugare : Form
    {
        private const bool SUCCES = true;
        IStocarePacienti stocarePacienti = (IStocarePacienti)new StocareFactory().GetTipStocarePacienti();
        IStocareBuletinAnalize stocareBuletin = (IStocareBuletinAnalize)new StocareFactory().GetTipStocareBuletinAnalize();
        IStocareRezultat stocareRezultat=(IStocareRezultat)new StocareFactory().GetTipStocareRezultat();
        IStocarePersonalMedical stocarePersonal=(IStocarePersonalMedical)new StocareFactory().GetTipStocarePersonalMedical();
        IStocareAnalize stocareAnalize=(IStocareAnalize)new StocareFactory().GetTipStocareAnalize();
        public FormaAdaugare()
        {
            InitializeComponent();
            if (stocarePacienti == null || stocareBuletin ==null || stocareRezultat==null || stocareAnalize==null || stocarePersonal==null )
            {
                MessageBox.Show("Eroare la initializare");
            }

        }

        private void FormaAdaugare_Load(object sender, EventArgs e)
        {
            IncarcaPacienti();
            IncarcaPersonal();
            IncarcaBuletin();
            IncarcaAnalize();
            
            

        }
        private void FormaAdaugare_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaPacient_Click(object sender, EventArgs e)
        {

            try
                
            {
               
                var rezultat = stocarePacienti.AddPacienti(new Pacienti(textBoxNumePacient.Text, textBoxPrenumePacient.Text, Convert.ToInt64(textBoxCNP.Text), Convert.ToDateTime(textBoxDataPacient.Text), textBoxSexPacient.Text, Convert.ToInt64(textBoxTelefonPacient.Text),textBoxAdresaPacient.Text));
                if (rezultat ==SUCCES)
                {
                    MessageBox.Show("Pacient adaugat");
                    IncarcaPacienti();
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare pacient");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }
        private void IncarcaPacienti()
        {
            
            try
            {
                //se elimina itemii deja adaugati
                //comboBoxIDPacientBuletin.Items.Clear();
                comboBoxIDPacientBuletin.Items.Clear();
                var pacienti = stocarePacienti.GetPacienti();
                if (pacienti !=null)
                {
                    foreach (var pacient in pacienti)
                    {
                        comboBoxIDPacientBuletin.Items.Add(new ComboItem(pacient.Nume+" "+pacient.Prenume, (Int32)pacient.Id_Pacient));
                    }
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void IncarcaPersonal()
        {
            try
            {
                //se elimina itemii deja adaugati
                //comboBoxIDPacientBuletin.Items.Clear();

                var personal = stocarePersonal.GetPersonal().Where(p => p.Id_Personal.Contains("Med"));
                if (personal != null)
                {
                    foreach (var pers in personal)
                    {
                        comboBoxMedicBuletin.Items.Add(new ComboItem(pers.Nume+" "+pers.Prenume, pers.Id_Personal));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void IncarcaBuletin()
        {
            try
            {
                comboBoxIDBuletinAnaliza.Items.Clear();
                //se elimina itemii deja adaugati
                //comboBoxIDPacientBuletin.Items.Clear();

                var buletine = stocareBuletin.GetBuletin();
                if (buletine != null && buletine.Any())
                {
                    foreach (var buletin in buletine)
                    {
                        comboBoxIDBuletinAnaliza.Items.Add(new ComboItem(buletin.Id_Buletin.ToString(), (Int32)buletin.Id_Buletin));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void IncarcaAnalize()
        {
            try
            {
                //se elimina itemii deja adaugati
                //comboBoxIDPacientBuletin.Items.Clear();

                var analize = stocareAnalize.GetAnalize();
                if (analize != null)
                {
                    foreach (var analiza in analize)
                    {
                        comboBoxAnaliza.Items.Add(new ComboItem(analiza.Denumire, analiza.Id_Analiza));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void buttonCancelAdaugare_Click(object sender, EventArgs e)
        {
            FormaAfisare f = new FormaAfisare();
            f.Show();
            this.Hide();
        }

        private void buttonAdaugaBuletin_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                   

                var rezultat = stocareBuletin.AddBuletin(new BuletinAnalize(
                    Convert.ToDateTime(textBoxDataRecoltarii.Text),
                    Convert.ToDateTime(textBoxDataRezultate.Text),
                    ((ComboItem)comboBoxIDPacientBuletin.SelectedItem).Value,
                    ((ComboItem)comboBoxMedicBuletin.SelectedItem).Text1));


                if (rezultat ==SUCCES)
                {
                    MessageBox.Show("Buletin de analize adaugat");
                    IncarcaBuletin();
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare buletin de analize");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void buttonAdaugaAnaliza_Click(object sender, EventArgs e)
        {
            try
            {
                
               

                  

                var rezultat = stocareRezultat.AddRezultat( new Rezultat(
                    ((ComboItem)comboBoxIDBuletinAnaliza.SelectedItem).Value,
                    ((ComboItem)comboBoxAnaliza.SelectedItem).Text1,
                   Convert.ToInt32(textBoxRezultatAnaliza.Text),
                   textBoxComentariiAnaliza.Text));
                if (rezultat !=null)
                {
                    MessageBox.Show("Rezultat analiza adaugat");
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare rezultat analiza");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }
    }
}
