# Судоку

Овој проект се однесува на имплементација на играта Судоку со користење на Windows Forms во C#.

Финалниот изглед на играта по имплементација на овој код.
![Судоку](https://i.postimg.cc/QNqjHhZy/sudokuu.png)
![Судоку](https://i.postimg.cc/QxTCCvS9/funkcija.png)

Прв чекор е креирање на веб форма и со помош на drag and drop од Toolbox-от го поставуваме cointainer-от на Судоку таблата преку опцијата Panel. <br>
Потоа правиме класа преку која се моделира секое поле од таблата на Судоку која што е матрица 9x9 полиња, која се вика Pole и во неа ги внесуваме нејзините параметри 
и методи за да може потоа да се користи. 



```

namespace GameSudoku
{
    class Pole : Button
    {
        public int value { get; set; }
        public bool fiksirano { set; get; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            this.Text = string.Empty;
            this.fiksirano= false;
        }
    }
}
```
Потоа креираме методи kreirajtabla() и novaigra() на начин што методот kreirajtabla() ги пополнува сите полиња на таблата преку тоа што креира матрица од тип Pole и секој
елемент од матрицата го подесува со соодветна боја, текст за подобар изглед на таблата. На крај на панелот кој што го додадовме на почетокот, именуван Panel1 ги додаваме
полињата од матрицата, нивните координати, како и се овозможува функционалностa да се притисне на  поле преку Pritisnato_pole() методот.      


        
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
        


   
За започнување на нова игра се користи методот novaIgra() каде се одредува нивото на Судоку преку селектираната опција на RadioButtons и според таа проверка се одредува тежината играта. Потоа се повикуваат методите loadValues() и  findValueForNextCell() кој ги поминува наредните ќелии со цел да генерираат броеви во таблата со кои што ќе може да се постави самата задача. <br>



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
        
        
        
        
Клучна улога игра методот isValidNumber() кој всушност ја одредува функционалноста на Судоку играта односно рестрикциите и правилата според кои таа се имплементира. Одредува дека броевите во иста редица, во иста колона како и регион не смеат да биде исти. Доколку тоа се случи, решението е грешно.



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
        
        
        
        




        
<p> Исто така се додаваат контролите на играта односно копчињата Нова Игра за започнување на нова игра, Ресетирај за да се избрише внесот и Проверка <br>
за да се провери дали сме решиле точно или сме направиле грешка и соодветни пораки во врска со тоа, како и Селекција на ниво на играта според тоа <br>
дали има повеќе или помалку помош преку RadioButtons. </p>


```
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







