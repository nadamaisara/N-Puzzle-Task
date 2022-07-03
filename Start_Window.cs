using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_Puzzle_Game
{
    public partial class Start_Window : Form
    {
        public static Start_Window __main__;
        bool Eight = false, Fifteen = false;
        public Start_Window()
        {
            InitializeComponent();
            __main__ = this;
        }

        private void Start_Window_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbx_size.SelectedItem.ToString())
            {
                case "3 * 3":
                    comboBox2.Items.Clear();
                    List<string> lst = new List<string>() { "BFS" };
                    foreach (string s in lst) comboBox2.Items.Add(s);
                    Eight = true; Fifteen = false;
                    break;
       
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eight_Puzzle _8 = new Eight_Puzzle();

            if (Eight)
            {
                switch (comboBox2.SelectedItem.ToString())
                {
                    case "BFS":
                        _8.b_bfs = true;
                        break;
                }
                _8.Show();
                __main__.Hide();
            }
        }

    }
}
