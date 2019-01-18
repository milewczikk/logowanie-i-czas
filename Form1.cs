using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Logow : Form
    {
        string kod = Los.Losowanie().ToString();
        DateTime StartTime;
        DateTime EndTime;
        DateTime EndTimeHaslo;
        DateTime Czas;
        double drej1;
        double drej2;
        double drej3;
        double drej4;
        double drej5;
        //double srednia;
        public Logow()
        {
            InitializeComponent();
            pokazOknorejestracji();
        }
        private void Text_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("Entered");
            StartTime = DateTime.Now;
        }
        private void text_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Changed at : " + DateTime.Now.Subtract(StartTime).ToString());
            StartTime = DateTime.Now;
        }
        private void haslo_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Left");
            EndTimeHaslo = DateTime.Now;
            //double date = EndTime.ToOADate();
            //DateTime con = DateTime.FromOADate(date);
            //MessageBox.Show("Time in control: " + EndTimeHaslo.Subtract(StartTime).ToString());
            //MessageBox.Show("Time in control: " + date.ToString());
            //MessageBox.Show("Time in control: " + Czas.Subtract(DateTime.Now).ToString());
        }
        private void rej1_Leave(object sender, EventArgs e)
        {
            EndTime = DateTime.Now;
            drej1 = EndTime.ToOADate();
        }
        private void rej2_Leave(object sender, EventArgs e)
        {
            EndTime = DateTime.Now;
            drej2 = EndTime.ToOADate();
        }
        private void rej3_Leave(object sender, EventArgs e)
        {
            EndTime = DateTime.Now;
            drej3 = EndTime.ToOADate();
        }
        private void rej4_Leave(object sender, EventArgs e)
        {
            EndTime = DateTime.Now;
            drej4 = EndTime.ToOADate();
        }
        private void rej5_Leave(object sender, EventArgs e)
        {
            EndTime = DateTime.Now;
            drej5 = EndTime.ToOADate();
        }

        private void pokazOknorejestracji()
        {
            rejestracja.Visible = true;
            log1.Visible = false;
            log2.Visible = false;
            log3.Visible = false;
        }

        private void AkcRej_Click(object sender, EventArgs e)
        {
            double suma = drej1 + drej2 + drej3 + drej4 + drej5;
            double srednia = suma / 5;
            Czas = DateTime.FromOADate(srednia);

            if (rej1.Text == rej2.Text && rej1.Text == rej3.Text && rej1.Text == rej4.Text && rej1.Text == rej5.Text)
            {
                if (rej1.Text != "" && rej2.Text != "" && rej3.Text != "" && rej4.Text != "" && rej5.Text != "")
                {
                    MessageBox.Show("Rejestracja przebiegła pomyślnie");
                    pokazOknologowania();
                }
                else
                {
                    MessageBox.Show("Proszę uzupełnić pola");
                }
            }
            else
            {
                MessageBox.Show("Hasła w polach są różne");
                Application.Exit();
            }
        }
        private void pokazOknologowania()
        {
            log1.Visible = true;
            log2.Visible = false;
            log3.Visible = false;
            rejestracja.Visible = false;
        }

        private void weryfikuj_Click(object sender, EventArgs e)
        {
            if (EndTimeHaslo < Czas.AddMilliseconds(10000) && EndTimeHaslo > Czas.AddMilliseconds(-10000))
            {
                if (login.Text == "admin" && haslo.Text == rej1.Text && nierobot.Checked == true)
                {
                    MessageBox.Show("zalogowales sie");
                    log1.Visible = false;
                    log2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Błędnie wprowadzone dane");
                }
            }
            else
            {
                MessageBox.Show("Czas wpisywania hasła się nie zgadza");
            }
        }
        private void wyslij_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("kodwerc@gmail.com");
                mail.To.Add(email.Text);
                mail.Subject = "Kod weryfikacyjny";
                mail.Body = kod;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("kodwerc", "zaq1@WSXzaq1");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("E-mail został wysłany");
                log3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sprawdz_Click(object sender, EventArgs e)
        {
            if (sprawdzenie.Text.Equals(kod))
            {
                MessageBox.Show("Zalogowałeś się poprawnie!!");
                log2.Visible = false;
                log3.Visible = false;
            }
            else
            {
                MessageBox.Show("Kod jest niepoprawny.Spróbuj jeszcze raz");
            }
        }
    }
}
