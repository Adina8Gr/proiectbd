using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;
using Oracle.DataAccess.Client;


namespace InterfataUtilizator
{
    public partial class FormaAfisare : Form
    {

        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        IStocarePacienti stocarePacienti = (IStocarePacienti)new StocareFactory().GetTipStocarePacienti();
        IStocareBuletinAnalize stocareBuletin=(IStocareBuletinAnalize)new StocareFactory().GetTipStocareBuletinAnalize();
        IStocareRezultat stocareRezultat=(IStocareRezultat)new StocareFactory().GetTipStocareRezultat();
        IStocareAnalize stocareAnalize=(IStocareAnalize)new StocareFactory().GetTipStocareAnalize();
        IStocareAnalize stocareAnalize2 = (IStocareAnalize)new StocareFactory().GetTipStocareAnalize();
        IStocarePersonalMedical stocarePersonal = (IStocarePersonalMedical)new StocareFactory().GetTipStocarePersonalMedical();
        IStocareLaboratoare stocareLaboratoare = (IStocareLaboratoare)new StocareFactory().GetTipStocareLaboratoare();
        public FormaAfisare()
        {
            InitializeComponent();
            //read();
            if (stocarePacienti == null || stocareBuletin==null || stocarePersonal==null || stocareLaboratoare==null || stocareRezultat==null || stocareAnalize==null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }
        
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

           
        }

     

       
        private void AfiseazaPacienti()
        {
            try
            {
               
                var pacienti = stocarePacienti.GetPacienti();
            if (pacienti != null && pacienti.Any())
            {
                dataGridView1.DataSource = pacienti.Select(p => new { p.Id_Pacient, p.Nume, p.Prenume, p.CNP, p.Data_nasterii,p.Sex,p.Telefon,p.Adresa }).ToList();

             
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
}
        private void AfiseazaBuletine()
        {
            try
            {
               
                var buletine = stocareBuletin.GetBuletin();
                if (buletine != null && buletine.Any())
                {
                    dataGridView1.DataSource = buletine.Select(b => new { b.Id_Buletin, b.Data_recoltarii, b.Data_Rezultate, b.Id_Pacient,b.Id_Personal }).ToList();
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AfiseazaLaboratoare()
        {
            try
            {
                var laboratoare = stocareLaboratoare.GetLaboratoare();
                if (laboratoare != null && laboratoare.Any())
                {
                    dataGridView1.DataSource = laboratoare.Select(l => new { l.Id_Laborator, l.Nume_Laborator, l.Adresa, l.Telefon }).ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AfiseazaRezultate()
        {
            try
            {
                var rezultate = stocareRezultat.GetRezultat();
                if (rezultate != null && rezultate.Any())
                {
                    dataGridView1.DataSource = rezultate.Select(r => new { r.Id_Rezultat,r.Id_Buletin, r.Id_Analiza, r.Rezultat_Analiza, r.Comentarii }).ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
       
        private void AfiseazaPersonalMedical()
        {
            try
            {
               
                var personal = stocarePersonal.GetPersonal();
                if (personal != null && personal.Any())
                {
                    dataGridView1.DataSource = personal.Select(p => new { p.Id_Personal, p.Nume, p.Prenume, p.Functie, p.Departament, p.Id_Laborator }).ToList();
                   
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AfiseazaAnalize()
        {
            try
            {
               
                var analize = stocareAnalize.GetAnalize();
                if (analize != null && analize.Any())
                {
                    dataGridView1.DataSource = analize.Select(a => new { a.Id_Analiza, a.Denumire, a.Tip, a.Pret }).ToList();
                   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void buttonFormAdaugare_Click(object sender, EventArgs e)
        {
            FormaAdaugare f = new FormaAdaugare();
            f.Show();
            this.Hide();
        }
       
       private void Form1_Load(object sender, EventArgs e)
        {
            //AfiseazaPacienti();
            comboBox1.Items.Add("Pacienti");
            comboBox1.Items.Add("Buletine analize");
            comboBox1.Items.Add("Rezultate analize");
            comboBox1.Items.Add("Personal medical");
            comboBox1.Items.Add("Pachet Analize");
            comboBox1.Items.Add("Laboratoare");
            groupBox1.Visible= false;
            groupBox2.Visible= false;
            groupBox3.Visible= false;
            IncarcaPacienti();
            IncarcaPersonal();
            IncarcaBuletin();
            IncarcaAnalize();
           
        }
        private void FormaAfisare_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
     


    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox1.SelectedItem=="Pacienti")
            {

                AfiseazaPacienti();
                var p = stocarePacienti.GetNumarPacienti();
                labelnrpacienti.Text = p.ToString();
   
               
            }
            else if(comboBox1.SelectedItem=="Buletine analize")
            {
                AfiseazaBuletine();
                var b = stocareBuletin.GetNumarBuletine();
                labelnrpacienti.Text = b.ToString();
            }
            else if(comboBox1.SelectedItem=="Rezultate analize")
            {
                AfiseazaRezultate();
                var r = stocareRezultat.GetNumarRezultate();
                labelnrpacienti.Text = r.ToString();
            }

            else if(comboBox1.SelectedItem=="Personal medical")
            {
                AfiseazaPersonalMedical();
                labelnrpacienti.Text = "";
            }
            else if(comboBox1.SelectedItem=="Pachet Analize")
            {
                AfiseazaAnalize();
                labelnrpacienti.Text = "";
            }
            else if(comboBox1.SelectedItem=="Laboratoare")
            {
                AfiseazaLaboratoare();
                labelnrpacienti.Text = "";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Pacienti")
            {
                dataGridView1.ClearSelection();
                int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string idpacient = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
               try
                {
                    Pacienti p = stocarePacienti.GetPacienti(Int32.Parse(idpacient));
                    groupBox1.Visible = true;
                    //incarcarea datelor in controalele de pe forma
                    if (p != null)
                    {
                        lblIdPacient.Text = p.Id_Pacient.ToString();
                        textBoxNumePacient.Text = p.Nume;
                        textBoxPrenumePacient.Text = p.Prenume;
                        textBoxCNP.Text = p.CNP.ToString();
                        textBoxDataPacient.Text = p.Data_nasterii.ToShortDateString();
                        textBoxSexPacient.Text = p.Sex;
                        textBoxTelefonPacient.Text = p.Telefon.ToString();
                        textBoxAdresaPacient.Text = p.Adresa;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                
            }
            else if(comboBox1.SelectedItem.ToString() =="Buletine analize")
            {
                dataGridView1.ClearSelection();
                int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
                string idbuletin = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
                try
                {
                   BuletinAnalize b = stocareBuletin.GetBuletin(Int32.Parse(idbuletin));
                    groupBox2.Visible = true;
                    //incarcarea datelor in controalele de pe forma
                    if (b != null)
                    {
                        lblIdBuletin.Text=b.Id_Buletin.ToString();
                        textDataRecoltarii.Text = b.Data_recoltarii.ToShortDateString();
                        textBoxDataRezultate.Text = b.Data_Rezultate.ToShortDateString();
         
                        comboIdPacientBuletin.SelectedItem = new ComboItem( b.Pacienti.Nume+" "+b.Pacienti.Prenume,(Int32)b.Id_Pacient);
                        comboMedic.SelectedItem = new ComboItem(b.PersonalMedical.Nume+" "+b.PersonalMedical.Prenume,b.Id_Personal);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                
               
            }
            else if (comboBox1.SelectedItem.ToString() == "Rezultate analize")
            {
                dataGridView1.ClearSelection();
                int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
                string idrezultat = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
                try
                {
                    Rezultat r = stocareRezultat.GetRezultat(Int32.Parse(idrezultat));
                    groupBox3.Visible = true;
                    //incarcarea datelor in controalele de pe forma
                    if (r != null)
                    {
                        lblIdRezultat.Text = r.Id_Rezultat.ToString();
                        comboBoxIDBuletinAnaliza.SelectedItem =new ComboItem(Convert.ToString(r.BuletinAnalize.Id_Buletin),r.Id_Buletin);
                        comboBoxAnaliza.SelectedItem =  new ComboItem(r.Analize.Denumire,r.Id_Analiza);
                        textBoxRezultatAnaliza.Text = r.Rezultat_Analiza.ToString();
                        textBoxComentariiAnaliza.Text = r.Comentarii;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                
            }

        }

        private void buttonAdaugaPacient_Click(object sender, EventArgs e)
        {

            try
            {
                var pacient = new Pacienti(
                    textBoxNumePacient.Text,
                    textBoxPrenumePacient.Text,
                    Int64.Parse(textBoxCNP.Text),
                    Convert.ToDateTime(textBoxDataPacient.Text),
                    textBoxSexPacient.Text,
                    Int64.Parse(textBoxTelefonPacient.Text),
                    textBoxAdresaPacient.Text,Int32.Parse(lblIdPacient.Text));

                var rezultat = stocarePacienti.UpdatePacienti(pacient);
                if (rezultat !=null)
                {
                    MessageBox.Show("Pacient actualizat");
                    AfiseazaPacienti();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare pacient");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var buletin = new BuletinAnalize(
                    Convert.ToDateTime(textDataRecoltarii.Text),
                    Convert.ToDateTime(textBoxDataRezultate.Text),
                   ((ComboItem)comboIdPacientBuletin.SelectedItem).Value,
                    ((ComboItem)comboMedic.SelectedItem).Text1, Int32.Parse(lblIdBuletin.Text) );

                var rezultat = stocareBuletin.UpdateBuletin(buletin);
                if (rezultat != null)
                {
                    MessageBox.Show("Buletin actualizat");
                    IncarcaBuletin();
                    AfiseazaBuletine();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare buletin");
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
                var rezultateAnalize = new Rezultat(((ComboItem)comboBoxIDBuletinAnaliza.SelectedItem).Value,
                    ((ComboItem)comboBoxAnaliza.SelectedItem).Text1,Int32.Parse(textBoxRezultatAnaliza.Text),textBoxComentariiAnaliza.Text, Int32.Parse(lblIdRezultat.Text ));

                var rezultat = stocareRezultat.UpdateRezultat(rezultateAnalize);
                if (rezultat != null)
                {
                    MessageBox.Show("Rezultat actualizat");
                    AfiseazaRezultate();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare rezultat");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void buttonStergereFizica_Click(object sender, EventArgs e)
        {
            try { 
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
                if (comboBox1.SelectedItem == "Pacienti")
                {


                    var rez = stocarePacienti.DeletePacienti(Convert.ToInt32(id));
                    MessageBox.Show(rez.ToString());
                    if (rez ==SUCCES)
                    {
                        MessageBox.Show("Pacientul a fost sters");
                        AfiseazaPacienti();

                    }
                    else
                    {
                        MessageBox.Show("Stergerea nu a mers");
                    }
                }
                else if(comboBox1.SelectedItem =="Buletine analize")
                {
                    var rez = stocareBuletin.DeleteBuletine(Convert.ToInt32(id));
                    MessageBox.Show(rez.ToString());
                    if (rez == SUCCES)
                    {
                        MessageBox.Show("Buletinul a fost sters");
                        AfiseazaBuletine();

                    }
                    else
                    {
                        MessageBox.Show("Stergerea nu a mers");
                    }
                }
                else if (comboBox1.SelectedItem == "Rezultate analize")
                {
                    var rez = stocareRezultat.DeleteRezultate(Convert.ToInt32(id));
                    MessageBox.Show(rez.ToString());
                    if (rez == SUCCES)
                    {
                        MessageBox.Show("Rezultatul a fost sters");
                        AfiseazaRezultate();

                    }
                    else
                    {
                        MessageBox.Show("Stergerea nu a mers");
                    }
                }
                else if (comboBox1.SelectedItem == "Pachet Analize")
                {
                    var rez = stocareAnalize.DeleteAnalize(id);
                    MessageBox.Show(rez.ToString());
                    if (rez == SUCCES)
                    {
                        MessageBox.Show("Analiza a fost stearsa");
                        AfiseazaAnalize();

                    }
                    else
                    {
                        MessageBox.Show("Stergerea nu a mers");
                    }
                }
                else if (comboBox1.SelectedItem == "Laboratoare")
                {
                    var rez = stocareLaboratoare.DeleteLaboratoare(Convert.ToInt32(id));
                    MessageBox.Show(rez.ToString());
                    if (rez == SUCCES)
                    {
                        MessageBox.Show("Laboratorul a fost sters");
                        AfiseazaLaboratoare();

                    }
                    else
                    {
                        MessageBox.Show("Stergerea nu a mers");
                    }
                }
                else if (comboBox1.SelectedItem == "Personal medical")
                {
                    var rez = stocarePersonal.DeletePersonal(id);
                    MessageBox.Show(rez.ToString());
                    if (rez == SUCCES)
                    {
                        MessageBox.Show("Personalul a fost sters");
                        AfiseazaPersonalMedical();

                    }
                    else
                    {
                        MessageBox.Show("Stergerea nu a mers");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Exceptie"+ ex.Message);
            }
        }

      
        private void IncarcaPacienti()
        {
            try
            {
                //se elimina itemii deja adaugati
              //  comboIdPacientBuletin.Items.Clear();

                var pacienti = stocarePacienti.GetPacienti();
                if (pacienti != null && pacienti.Any())
                {
                    foreach (var pacient in pacienti)
                    {
                        comboIdPacientBuletin.Items.Add(new ComboItem(pacient.Nume+" "+pacient.Prenume, (Int32)pacient.Id_Pacient));
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
                comboMedic.Items.Clear();

                var personal = stocarePersonal.GetPersonal().Where(p => p.Id_Personal.Contains("Med"));
                if (personal != null && personal.Any())
                {
                    foreach (var pers in personal)
                    {
                        comboMedic.Items.Add(new ComboItem(pers.Nume+" "+pers.Prenume, pers.Id_Personal));
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
                //se elimina itemii deja adaugati
                comboBoxIDBuletinAnaliza.Items.Clear();

                var buletine = stocareBuletin.GetBuletin();
                if (buletine != null && buletine.Any())
                {
                    foreach (var buletin in buletine)
                    {
                        comboBoxIDBuletinAnaliza.Items.Add(new ComboItem(Convert.ToString(buletin.Id_Buletin), (Int32)buletin.Id_Buletin));
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
                comboBoxAnaliza.Items.Clear();

                var analize = stocareAnalize.GetAnalize();
                if (analize != null && analize.Any())
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          /*  Rezultat result = null;
            var dsBuletin = SqlDBHelper.ExecuteDataSet("select * from rezultate_ag where Id_Buletin = :Id_Buletin", CommandType.Text,
                new OracleParameter(":Id_Buletin", OracleDbType.Int32, Convert.ToUInt32(textBox2.Text), ParameterDirection.Input));

            if (dsBuletin.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsBuletin.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Rezultat(linieBD);
                //incarca entitatile aditionale
               // dataGridView1.DataSource = linieBD.(r => new { r.Id_Buletin, r.Id_Analiza, r.Rezultat_Analiza, r.Comentarii, r.Id_Rezultat }).ToList();
            }
            

            */
        }
        // Adăugați o referință către obiectul AdministrareRezultate


        // Creați o metodă publică pentru a afișa rezultatele buletinului în altă formă
        
        private AdministrareRezultat stocareRezultate;
        public void AfiseazaRezultateBuletin(int idBuletin, DataGridView dataGridViewRezultate)
        {
            // Apelați funcția GetRezultateByBuletinId și setați sursa de date a DataGridView
            var rezultate = stocareRezultate.GetRezultateByBuletinId(idBuletin);
            dataGridViewRezultate.DataSource = rezultate;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Buletine analize")
            {
                dataGridView1.ClearSelection();
                int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
                string idbuletin = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
                try
                {

                    var rezultate = stocareRezultat.GetRezultateByBuletinId(Int32.Parse(idbuletin));
                    if (rezultate != null && rezultate.Any())
                    {
                        dataGridView1.DataSource = rezultate.Select(r => new { r.Id_Rezultat, r.Id_Buletin, r.Id_Analiza, r.Rezultat_Analiza, r.Comentarii }).ToList();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
            else if(comboBox1.SelectedItem =="Pacienti")
            {
                dataGridView1.ClearSelection();
                int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
                string idpacient = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
                try
                {

                    var buletine = stocareBuletin.GetBuletineByPacientId(Int32.Parse(idpacient));
                    if (buletine != null && buletine.Any())
                    {
                        dataGridView1.DataSource = buletine.Select(b => new { b.Id_Buletin, b.Data_recoltarii, b.Data_Rezultate, b.Id_Pacient, b.Id_Personal }).ToList();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Buletine analize")
            {
                AfiseazaBuletine();
            }
            else if (comboBox1.SelectedItem == "Pacienti")
            {
                AfiseazaPacienti();
            }
         }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string numeColoana = textBox1.Text;
            bool ordineCrescatoare = false;
            if (checkBox1.Checked)
            {

                ordineCrescatoare = true;

               
                if (comboBox1.SelectedItem == "Pacienti")
                {

                    var pacientiOrdonati = stocarePacienti.GetPacientiOrdonati(numeColoana, ordineCrescatoare);
                    dataGridView1.DataSource = pacientiOrdonati;

                }
                else if (comboBox1.SelectedItem == "Buletine analize")
                {
                    var buletineOrdonate = stocareBuletin.GetBuletineOrdonate(numeColoana, ordineCrescatoare);
                    dataGridView1.DataSource = buletineOrdonate;
                }
                else if (comboBox1.SelectedItem == "Rezultate analize")
                {
                    var rezultateOrdonate = stocareRezultat.GetRezultatOrdonat(numeColoana, ordineCrescatoare);
                    dataGridView1.DataSource = rezultateOrdonate;
                }

                else if (comboBox1.SelectedItem == "Personal medical")
                {
                    var personalOrdonati = stocarePersonal.GetPersonalOrdonat(numeColoana, ordineCrescatoare);
                    dataGridView1.DataSource = personalOrdonati;
                }
                else if (comboBox1.SelectedItem == "Pachet Analize")
                {
                    var analizeOrdonate = stocareAnalize.GetAnalizeOrdonate(numeColoana, ordineCrescatoare);
                    dataGridView1.DataSource = analizeOrdonate;
                }
                else if (comboBox1.SelectedItem == "Laboratoare")
                {
                    var laboratoareOrdonate = stocareLaboratoare.GetLaboratoareOrdonate(numeColoana, ordineCrescatoare);
                    dataGridView1.DataSource = laboratoareOrdonate;
                }
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                // Utilizați lista de pacienți ordonați pentru a le afișa în DataGridView sau în altă formă dorită
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string numeColoana = textBox1.Text;
            bool ordineDescrescatoare = false;
            if (checkBox2.Checked)
            {
               

               

                if (comboBox1.SelectedItem == "Pacienti")
                {

                    var pacientiOrdonati = stocarePacienti.GetPacientiOrdonati(numeColoana, ordineDescrescatoare);
                    dataGridView1.DataSource = pacientiOrdonati;

                }
                else if (comboBox1.SelectedItem == "Buletine analize")
                {
                    var buletineOrdonate = stocareBuletin.GetBuletineOrdonate(numeColoana, ordineDescrescatoare);
                    dataGridView1.DataSource = buletineOrdonate;
                }
                else if (comboBox1.SelectedItem == "Rezultate analize")
                {
                    var rezultateOrdonate = stocareRezultat.GetRezultatOrdonat(numeColoana, ordineDescrescatoare);
                    dataGridView1.DataSource = rezultateOrdonate;
                }

                else if (comboBox1.SelectedItem == "Personal medical")
                {
                    var personalOrdonati = stocarePersonal.GetPersonalOrdonat(numeColoana, ordineDescrescatoare);
                    dataGridView1.DataSource = personalOrdonati;
                }
                else if (comboBox1.SelectedItem == "Pachet Analize")
                {
                    var analizeOrdonate = stocareAnalize.GetAnalizeOrdonate(numeColoana, ordineDescrescatoare);
                    dataGridView1.DataSource = analizeOrdonate;
                }
                else if (comboBox1.SelectedItem == "Laboratoare")
                {
                    var laboratoareOrdonate = stocareLaboratoare.GetLaboratoareOrdonate(numeColoana, ordineDescrescatoare);
                    dataGridView1.DataSource = laboratoareOrdonate;
                }
                checkBox2.Checked = false;
                checkBox1.Checked = false;
            }
        }
    }
    
}
