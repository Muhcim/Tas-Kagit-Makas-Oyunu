using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagıttMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string secilen , gelen;
        Random rnd = new Random();
        int gelendeger = 0 , skorOyuncu = 0 , skorPC = 0 ; 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxTas_Click(object sender, EventArgs e)
        {
            secilen = "Taş"; 
            pictureBoxTas.BackColor = Color.Green;
            pictureBoxKagıt.BackColor = Color.Transparent;
            pictureBoxMakas.BackColor = Color.Transparent; 
        }

        private void pictureBoxKagıt_Click(object sender, EventArgs e)
        {
            secilen = "Kağıt"; 
            pictureBoxKagıt.BackColor = Color.Green;
            pictureBoxTas.BackColor = Color.Transparent;
            pictureBoxMakas.BackColor = Color.Transparent; 
        }

        private void pictureBoxMakas_Click(object sender, EventArgs e)
        {
            secilen = "Makas"; 
            pictureBoxMakas.BackColor = Color.Green;
            pictureBoxKagıt.BackColor = Color.Transparent;
            pictureBoxTas.BackColor = Color.Transparent; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (secilen != null)
            {
                if (secilen == "Taş")
                    pictureBoxOyuncu1.ImageLocation = "tas.png";
                else if (secilen == "Kağıt")
                    pictureBoxOyuncu1.ImageLocation = "kagıt.png";
                else if (secilen == "Makas")
                    pictureBoxOyuncu1.ImageLocation = "makas.png";

                oyna();
                this.Text = gelendeger.ToString(); 
                karsılastır(); 
            }
               else 
            {
            MessageBox.Show("Hamle Seçin" , "Hata" , MessageBoxButtons.OK , MessageBoxIcon.Information) ; 
            }

            }
        private void oyna()
        {
            gelendeger = rnd.Next(1, 4);
            if (gelendeger == 1)
            {
                gelen = "Taş";
                pictureBoxPC.ImageLocation = "tas.png";
            }
            else if (gelendeger == 2)
            {
                gelen = "Kağıt";
                pictureBoxPC.ImageLocation = "kagıt.png"; 
            }
            else if (gelendeger == 3)
            {
                gelen = "Makas";
                pictureBoxPC.ImageLocation = "makas.png"; 
            }
        }

        private void karsılastır()
        { 
          // beraberlik dururmu 
            if (secilen == "Taş" && gelen == "Taş")
                label1.Text = "Berabere";
            else if (secilen == "Kağıt" && gelen == "Kağıt")
                label1.Text = "Berabere";
            else if (secilen == "Makas" && gelen == "Makas")
                label1.Text = "Berabere";  
            
            // Taş Karşılaştırması  
            if (secilen == "Taş" && gelen == "Kağıt")
            {
                label1.Text = "Kağıt Taş'ı Sarar";
                skorPC++;
            }
            else if (secilen == "Taş" && gelen == "Makas")
            {
                label1.Text = "Taş Makas'ı Kırar";
                skorOyuncu++;  
            }

            // Kağıt Karşılaştırması 

            if (secilen == "Kağıt" && gelen == "Taş")
            {
                label1.Text = "Kağıt Taş'ı Sarar";
                skorOyuncu++;
            }
            else if (secilen == "Kağıt" && gelen == "Makas")
            {
                label1.Text = "Makas Kağıt'ı Keser";
                skorPC++;  
            }
             
            // Makas Karşılaştırması 

            if (secilen == "Makas" && gelen == "Taş")
            {
                label1.Text = "Taş Makas'ı Kırar";
                skorPC++;
            }
            else if (secilen == "Makas" && gelen == "Kağıt")
            {
                label1.Text = "Makas Kağıt'ı Keser";
                skorOyuncu++; 
            }

            labelSkor.Text = skorOyuncu.ToString();
            labelSkorPC.Text = skorPC.ToString(); 
        }
        }
    }

