using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms;

namespace GameSudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kreirajtabla();
            novaIgra();
        }
        Pole[,] polinja = new Pole[9, 9];
        private void kreirajtabla()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    polinja[i, j] = new Pole();
                    polinja[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    polinja[i, j].Size = new Size(40, 40);
                    polinja[i, j].ForeColor = SystemColors.ControlDarkDark;
                    polinja[i, j].Location = new Point(i * 40, j * 40);
                    polinja[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightCoral;
                    polinja[i, j].FlatStyle = FlatStyle.Flat;
                    polinja[i, j].FlatAppearance.BorderColor = Color.Black;
                    polinja[i, j].X = i;
                    polinja[i, j].Y = j;
                    btncheck.BackColor = Color.LightCoral;
                    btnnewgame.BackColor = Color.LightCoral;

                    polinja[i, j].KeyPress += Pritisnato_Pole;

                    panel1.Controls.Add(polinja[i, j]);

                }
            }
        }
        private void Pritisnato_Pole(object sender, KeyPressEventArgs e)
        {
            var pole = sender as Pole;

            if (pole.fiksirano)
            {
                return;
            }
            int value;
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {

                if (value == 0)
                    pole.Clear();
                else
                    pole.Text = value.ToString();

                pole.ForeColor = SystemColors.ControlDarkDark;
            }
        }
        private void novaIgra()
        {
            loadValues();

            var hints = 0;
            if (radioButtonEasy.Checked)
                hints= 45;
            else if (radioButtonMedium.Checked)
                hints = 30;
            else if (radioButtonHard.Checked)
                hints= 15;

            showRandomValuesHints(hints);

        }
        

        private void showRandomValuesHints(int hints)
        {
            
            for (int i = 0; i < hints; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                
                polinja[rX, rY].Text = polinja[rX, rY].value.ToString();
                polinja[rX, rY].ForeColor = Color.Black;
                polinja[rX, rY].fiksirano = true;
            }
        }
        private void loadValues()
        {

            foreach (var pole in polinja)
            {
                pole.value = 0;
                pole.Clear();
            }
            findValueForNextCell(0, -1);
        }
        Random random = new Random();
        private bool findValueForNextCell(int i, int j)
        {
            
            if (++j > 8)
            {
                j = 0;
                
                if (++i > 8)
                    return true;
            }

            var value = 0;
            var broevi = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            
            do
            {
                
                if (broevi.Count < 1)
                {
                    polinja[i, j].value = 0;
                    return false;
                }

                
                value = broevi[random.Next(0, broevi.Count)];
                polinja[i, j].value = value;

               
                broevi.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            //

            return true;
        }

        private bool isValidNumber(int vrednost, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
               
                if (i != y && polinja[x, i].value == vrednost)
                    return false;

                
                if (i != x && polinja[i, y].value == vrednost)
                    return false;
            }

           
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && polinja[i, j].value == vrednost)
                        return false;
                }
            }

            return true;
        }
   


        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            var gresnoPole = new List<Pole>();
            
            foreach(var p in polinja)
            {
                if (!string.Equals(p.value.ToString(), p.Text))
                {
                    gresnoPole.Add(p);
                }
            }
            if (gresnoPole.Any())
            {
                gresnoPole.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Има грешка.");
            }
            else
            {
                MessageBox.Show("Точен Одговор!");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            novaIgra();
        }

        private void btnnewgame_Click(object sender, EventArgs e)
        {
            foreach(var pole in polinja)
            {
                if(pole.fiksirano == false)
                {
                    pole.Clear();
                }
            }
        }

       
    }
}
    






