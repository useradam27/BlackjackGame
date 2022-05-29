using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    /// <summary>
    /// Form class for inital menu
    /// </summary>
    public partial class Menu_Form : Form
    {
        /// <summary>
        /// counts the number of tables created
        /// </summary>
        public static int tableCount;

        /// <summary>
        /// Form constructor used to initalize all components and values in program
        /// </summary>
        public Menu_Form()
        {
            InitializeComponent();
            tableCount = 0;
        }

        /// <summary>
        /// Creates a new blackjack table for the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void create_table_button_Click(object sender, EventArgs e)
        {
            if (errorCheck() > 0)
                return;

            

            int mode = 0;
            tableCount++;
            table_count.Text = tableCount.ToString();

            //check if user chose S17
            if (mode_checkbox.Checked)
            {
                mode = 1;
            }
            
            //creates table with deck ammount, seed number, table number, and mode
            Form t = new Table_Form(Int32.Parse(deck_comboBox.Text), Int32.Parse(seed_box.Text), tableCount, mode);
            t.Show();
        }

        /// <summary>
        /// Closes form if user chooses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void end_game_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        /// <summary>
        /// Checks if seed box is empty or has a non number ammount. Checks is selection is made on combo box
        /// </summary>
        /// <returns>count of errors found</returns>
        private int errorCheck()
        {
            int error = 0;

            if (string.IsNullOrEmpty(seed_box.Text))
            {
                MessageBox.Show("Please enter a seed!");
                error++;
            }

            int val;
            if (!int.TryParse(seed_box.Text, out val))
            {
                MessageBox.Show("Please only enter a number into the seed box!");
                error++;
                return error;
            }

            if (Int32.Parse(seed_box.Text) <= 0)
            {
                MessageBox.Show("Please enter a positive number for your seet!");
                error++;
            }

            if (deck_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose amount from drop down box!");
                error++;
            }

            return error;
        }

    }
}
