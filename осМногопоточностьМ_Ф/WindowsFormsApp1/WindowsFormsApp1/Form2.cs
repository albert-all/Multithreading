using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private bool win = false;
        private Button[,] buttons = new Button[3, 3];
        private int player;
        private int zero_win;
        private int cross_win;
        public Form2()
        {
            InitializeComponent();
            radioButton2.Checked = true;
            player = 1;
            label5.Text = "0";
            label6.Text = "0";
            label1.Text = "Ход крестика";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(100, 100);
                    buttons[i, j].BackColor = Color.FromArgb(227, 227, 227);
                }
            }
            setButtons();
        }
        private void ComputerPlay()
        {
            Thread.Sleep(400);
            this.Invoke((MethodInvoker)delegate ()
            {
                if (buttons[1, 1].Text == "X")
                {
                    if (buttons[0, 0].Text == "")
                    {
                        buttons[0, 0].Text = "O";
                        buttons[0, 0].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[0, 2].Text == "X" && buttons[1, 1].Text == "X")
                {
                    if (buttons[2, 0].Text == "")
                    {
                        buttons[2, 0].Text = "O";
                        buttons[2, 0].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[1, 0].Text == "X" && buttons[1, 1].Text == "X")
                {
                    if (buttons[1, 2].Text == "")
                    {
                        buttons[1, 2].Text = "O";
                        buttons[1, 2].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[0, 1].Text == "X" && buttons[1, 1].Text == "X")
                {
                    if (buttons[2, 1].Text == "")
                    {
                        buttons[2, 1].Text = "O";
                        buttons[2, 1].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[2, 0].Text == "X" && buttons[1, 1].Text == "X")
                {
                    if (buttons[0, 2].Text == "")
                    {
                        buttons[0, 2].Text = "O";
                        buttons[0, 2].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[2, 1].Text == "X" && buttons[1, 1].Text == "X")
                {
                    if (buttons[0, 1].Text == "")
                    {
                        buttons[0, 1].Text = "O";
                        buttons[0, 1].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[1, 1].Text == "")
                {
                    if (buttons[1, 1].Text == "")
                    {
                        buttons[1, 1].Text = "O";
                        buttons[1, 1].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[1, 2].Text == "X" && buttons[1, 0].Text == "X")
                {
                    if (buttons[1, 0].Text == "")
                    {
                        buttons[1, 0].Text = "O";
                        buttons[1, 0].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[1, 2].Text == "X" && buttons[0, 2].Text == "X")
                {
                    if (buttons[2, 2].Text == "")
                    {
                        buttons[2, 2].Text = "O";
                        buttons[2, 2].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[2, 0].Text == "X" && buttons[2, 2].Text == "X")
                {
                    if (buttons[2, 1].Text == "")
                    {
                        buttons[2, 1].Text = "O";
                        buttons[2, 1].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[1, 0].Text == "X" && buttons[0, 0].Text == "X")
                {
                    if (buttons[2, 0].Text == "")
                    {
                        buttons[2, 0].Text = "O";
                        buttons[2, 0].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[1, 2].Text == "X" && buttons[2, 2].Text == "X")
                {
                    if (buttons[0, 2].Text == "")
                    {
                        buttons[0, 2].Text = "O";
                        buttons[0, 2].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[2, 1].Text == "X" && buttons[2, 2].Text == "X")
                {
                    if (buttons[2, 0].Text == "")
                    {
                        buttons[2, 0].Text = "O";
                        buttons[2, 0].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[1, 1].Text == "X" && buttons[1, 2].Text == "X")
                {
                    if (buttons[1, 0].Text == "")
                    {
                        buttons[1, 0].Text = "O";
                        buttons[1, 0].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[0, 2].Text == "X" && buttons[2, 2].Text == "X")
                {
                    if (buttons[1, 2].Text == "")
                    {
                        buttons[1, 2].Text = "O";
                        buttons[1, 2].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                if (buttons[0, 0].Text == "X" && buttons[2, 0].Text == "X")
                {
                    if (buttons[1, 0].Text == "")
                    {
                        buttons[1, 0].Text = "O";
                        buttons[1, 0].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
                ComputerPlayEasy();
            });
        }
        private void setButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Location = new Point(12 + 106 * j, 12 + 106 * i);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 48);
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sender.GetType().GetProperty("Text").SetValue(sender, "X");
            if (radioButton2.Checked)
            {
                switch (player)
                {
                    case 1:
                        sender.GetType().GetProperty("Text").SetValue(sender, "X");
                        player = 0;
                        label1.Text = "Ход нолика";
                        break;
                    case 0:
                        sender.GetType().GetProperty("Text").SetValue(sender, "O");
                        player = 1;
                        label1.Text = "Ход крестика";
                        break;
                }
            }
            else
            {
                Thread mythread = new Thread(ComputerPlay);
                mythread.Start();
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                    buttons[i, j].BackColor = Color.FromArgb(227, 227, 227);
                }
            }
            win = false;
            player = 1;
            label1.Text = "Ход крестика";
        }
        private void ComputerPlayEasy()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Text == "")
                    {
                        buttons[i, j].Text = "O";
                        buttons[i, j].Enabled = false;
                        label1.Text = "Ход крестика";
                        player = 1;
                        return;
                    }
                }
            }
        }
        private void checkWin()
        {

            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    if (buttons[0, 0].Text == "X")
                    {
                        cross_win++;
                        label5.Text = cross_win.ToString();
                        buttons[0, 0].BackColor = Color.MediumSpringGreen;
                        buttons[0, 1].BackColor = Color.MediumSpringGreen;
                        buttons[0, 2].BackColor = Color.MediumSpringGreen;
                        MessageBox.Show("Выиграл Крестик!");
                    }
                    if (buttons[0, 0].Text == "O")
                    {
                        zero_win++;
                        label6.Text = zero_win.ToString();
                        buttons[0, 0].BackColor = Color.Crimson;
                        buttons[0, 1].BackColor = Color.Crimson;
                        buttons[0, 2].BackColor = Color.Crimson;
                        MessageBox.Show("Выиграл Нолик!");
                    }
                    win = true;
                }
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    if (buttons[1, 0].Text == "X")
                    {
                        cross_win++;
                        label5.Text = cross_win.ToString();
                        buttons[1, 0].BackColor = Color.MediumSpringGreen;
                        buttons[1, 1].BackColor = Color.MediumSpringGreen;
                        buttons[1, 2].BackColor = Color.MediumSpringGreen;
                        MessageBox.Show("Выиграл Крестик!");
                    }
                    if (buttons[1, 0].Text == "O")
                    {
                        zero_win++;
                        label6.Text = zero_win.ToString();
                        buttons[1, 0].BackColor = Color.Crimson;
                        buttons[1, 1].BackColor = Color.Crimson;
                        buttons[1, 2].BackColor = Color.Crimson;
                        MessageBox.Show("Выиграл Нолик!");
                    }
                    win = true;
                }
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    if (buttons[2, 0].Text == "X")
                    {
                        cross_win++;
                        label5.Text = cross_win.ToString();
                        buttons[2, 0].BackColor = Color.MediumSpringGreen;
                        buttons[2, 1].BackColor = Color.MediumSpringGreen;
                        buttons[2, 2].BackColor = Color.MediumSpringGreen;
                        MessageBox.Show("Выиграл Крестик!");
                    }
                    if (buttons[2, 0].Text == "O")
                    {
                        zero_win++;
                        label6.Text = zero_win.ToString();
                        buttons[2, 0].BackColor = Color.Crimson;
                        buttons[2, 1].BackColor = Color.Crimson;
                        buttons[2, 2].BackColor = Color.Crimson;
                        MessageBox.Show("Выиграл Нолик!");
                    }
                    win = true;
                }
            }
            //вертикали
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    if (buttons[0, 0].Text == "X")
                    {
                        cross_win++;
                        label5.Text = cross_win.ToString();
                        buttons[0, 0].BackColor = Color.MediumSpringGreen;
                        buttons[1, 0].BackColor = Color.MediumSpringGreen;
                        buttons[2, 0].BackColor = Color.MediumSpringGreen;
                        MessageBox.Show("Выиграл Крестик!");
                    }
                    if (buttons[0, 0].Text == "O")
                    {
                        zero_win++;
                        label6.Text = zero_win.ToString();
                        buttons[0, 0].BackColor = Color.Crimson;
                        buttons[1, 0].BackColor = Color.Crimson;
                        buttons[2, 0].BackColor = Color.Crimson;
                        MessageBox.Show("Выиграл Нолик!");
                    }
                    win = true;
                }
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                {
                    if (buttons[0, 1].Text == "X")
                    {
                        cross_win++;
                        label5.Text = cross_win.ToString();
                        buttons[0, 1].BackColor = Color.MediumSpringGreen;
                        buttons[1, 1].BackColor = Color.MediumSpringGreen;
                        buttons[2, 1].BackColor = Color.MediumSpringGreen;
                        MessageBox.Show("Выиграл Крестик!");
                    }
                    if (buttons[0, 1].Text == "O")
                    {
                        zero_win++;
                        label6.Text = zero_win.ToString();
                        buttons[0, 1].BackColor = Color.Crimson;
                        buttons[1, 1].BackColor = Color.Crimson;
                        buttons[2, 1].BackColor = Color.Crimson;
                        MessageBox.Show("Выиграл Нолик!");
                    }
                    win = true;
                }
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    if (buttons[0, 2].Text == "X")
                    {
                        cross_win++;
                        label5.Text = cross_win.ToString();
                        buttons[0, 2].BackColor = Color.MediumSpringGreen;
                        buttons[1, 2].BackColor = Color.MediumSpringGreen;
                        buttons[2, 2].BackColor = Color.MediumSpringGreen;
                        MessageBox.Show("Выиграл Крестик!");
                    }
                    if (buttons[0, 2].Text == "O")
                    {
                        zero_win++;
                        label6.Text = zero_win.ToString();
                        buttons[0, 2].BackColor = Color.Crimson;
                        buttons[1, 2].BackColor = Color.Crimson;
                        buttons[2, 2].BackColor = Color.Crimson;
                        MessageBox.Show("Выиграл Нолик!");
                    }
                    win = true;
                }
            }
            //диагонали
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    if (buttons[0, 0].Text == "X")
                    {
                        cross_win++;
                        label5.Text = cross_win.ToString();
                        buttons[0, 0].BackColor = Color.MediumSpringGreen;
                        buttons[1, 1].BackColor = Color.MediumSpringGreen;
                        buttons[2, 2].BackColor = Color.MediumSpringGreen;
                        MessageBox.Show("Выиграл Крестик!");
                    }
                    if (buttons[0, 0].Text == "O")
                    {
                        zero_win++;
                        label6.Text = zero_win.ToString();
                        buttons[0, 0].BackColor = Color.Crimson;
                        buttons[1, 1].BackColor = Color.Crimson;
                        buttons[2, 2].BackColor = Color.Crimson;
                        MessageBox.Show("Выиграл Нолик!");
                    }
                    win = true;
                }
            }
            if (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    if (buttons[0, 2].Text == "X")
                    {
                        cross_win++;
                        label5.Text = cross_win.ToString();
                        buttons[0, 2].BackColor = Color.MediumSpringGreen;
                        buttons[1, 1].BackColor = Color.MediumSpringGreen;
                        buttons[2, 0].BackColor = Color.MediumSpringGreen;
                        MessageBox.Show("Выиграл Крестик!");
                    }
                    if (buttons[0, 2].Text == "O")
                    {
                        zero_win++;
                        label6.Text = zero_win.ToString();
                        buttons[0, 2].BackColor = Color.Crimson;
                        buttons[1, 1].BackColor = Color.Crimson;
                        buttons[2, 0].BackColor = Color.Crimson;
                        MessageBox.Show("Выиграл Нолик!");
                    }
                    win = true;
                }
            }
            if (win)
            {
                button1.PerformClick();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
