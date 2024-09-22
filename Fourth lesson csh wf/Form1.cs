using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Fourth_lesson_csh_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(645, 455);
            this.Text = "BestOil";
            comboBoxFuel.Items.Add(new Oil { Name = "A-92", Price = 40.0f });
            comboBoxFuel.Items.Add(new Oil { Name = "A-95", Price = 51.0f });
            comboBoxFuel.Items.Add(new Oil { Name = "A-98", Price = 63.0f });

            comboBoxFuel.SelectedIndex = 1;
            textBoxNumber.Text = "10";

            textBoxHotDogPrice.Text = "4,00";
            textBoxHamburgerPrice.Text = "5,40";
            textBoxFrenchFriesPrice.Text = "7,20";
            textBoxCocaColaPrice.Text = "4,40";
        }

        //------------------------------------- GAS STATION -------------------------------------
        private void comboBoxBenzin_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = ((Oil)comboBoxFuel.SelectedItem).Price.ToString();
            if (radioButtonNumber.Checked && !String.IsNullOrEmpty(textBoxNumber.Text))
            {
                groupBoxToPayOrToIssue.Text = "To pay";
                labelToPay.Text = textBoxSum.Text = (((Oil)comboBoxFuel.SelectedItem).Price * Convert.ToSingle(textBoxNumber.Text)).ToString();
                labelGrnOrL.Text = "UAH";
            }
            if (radioButtonSum.Checked && !String.IsNullOrEmpty(textBoxSum.Text))
            {
                groupBoxToPayOrToIssue.Text = "To issue";
                labelToPay.Text = textBoxNumber.Text = (Convert.ToSingle(textBoxSum.Text) / ((Oil)comboBoxFuel.SelectedItem).Price).ToString();
                labelGrnOrL.Text = "l";
            }
        }
        private void radioButtonNumber_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumber.Enabled = true;
            textBoxSum.Enabled = false;

            if (!String.IsNullOrEmpty(textBoxNumber.Text))
            {
                groupBoxToPayOrToIssue.Text = "To pay";
                labelToPay.Text = textBoxSum.Text = (((Oil)comboBoxFuel.SelectedItem).Price * Convert.ToSingle(textBoxNumber.Text)).ToString();
                labelGrnOrL.Text = "";
            }
        }
        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumber.Enabled = false;
            textBoxSum.Enabled = true;

            if (!String.IsNullOrEmpty(textBoxSum.Text))
            {
                groupBoxToPayOrToIssue.Text = "To issue";
                labelToPay.Text = textBoxNumber.Text = (Convert.ToSingle(textBoxSum.Text) / ((Oil)comboBoxFuel.SelectedItem).Price).ToString();
                labelGrnOrL.Text = "l";
            }
        }
        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxNumber.Text))
            {
                groupBoxToPayOrToIssue.Text = "To pay";
                labelToPay.Text = textBoxSum.Text = (((Oil)comboBoxFuel.SelectedItem).Price * Convert.ToSingle(textBoxNumber.Text)).ToString();
                labelGrnOrL.Text = "UAH";
            }
        }
        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSum.Text))
            {
                groupBoxToPayOrToIssue.Text = "To issue";
                labelToPay.Text = textBoxNumber.Text = (Convert.ToSingle(textBoxSum.Text) / ((Oil)comboBoxFuel.SelectedItem).Price).ToString();
                labelGrnOrL.Text = "l";
            }
        }

        //------------------------------------- MINI CAFE -------------------------------------

        AllFoods allFoods = new AllFoods();
        bool isAlreadySet = false;
        float counts = 0;

        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHotDogNumber.Enabled = checkBoxHotDog.Checked;
            if (!checkBoxHotDog.Checked)
            {
                textBoxHotDogNumber.Text = null;
                allFoods.Delete(checkBoxHotDog.Text);
            }

            if (checkBoxHotDog.Checked)
            {
                isAlreadySet = true;
                textBoxHotDogNumber.Text = "1";
                float multiplication = Convert.ToSingle(textBoxHotDogPrice.Text) * Convert.ToInt32(textBoxHotDogNumber.Text);
                allFoods.Foods.Add(new Food(checkBoxHotDog.Text, multiplication));
                labelToPay2.Text = allFoods.ToString();
            }
        }
        private void checkBoxHamburger_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHamburgerNumber.Enabled = checkBoxHamburger.Checked;
            if (!checkBoxHamburger.Checked)
            {
                textBoxHamburgerNumber.Text = null;
                allFoods.Delete(checkBoxHotDog.Text);
            }

            if (checkBoxHamburger.Checked)
            {
                isAlreadySet = true;
                textBoxHamburgerNumber.Text = "1";
                float multiplication = Convert.ToSingle(textBoxHamburgerPrice.Text) * Convert.ToInt32(textBoxHamburgerNumber.Text);
                allFoods.Foods.Add(new Food(checkBoxHamburger.Text, multiplication));
                labelToPay2.Text = allFoods.ToString();
            }
        }
        private void checkBoxFrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFrenchFriesNumber.Enabled = checkBoxFrenchFries.Checked;
            if (!checkBoxFrenchFries.Checked)
            {
                textBoxFrenchFriesNumber.Text = null;
                allFoods.Delete(checkBoxFrenchFries.Text);
            }

            if (checkBoxFrenchFries.Checked)
            {
                isAlreadySet = true;
                textBoxFrenchFriesNumber.Text = "1";
                float multiplication = Convert.ToSingle(textBoxFrenchFriesPrice.Text) * Convert.ToInt32(textBoxFrenchFriesNumber.Text);
                allFoods.Foods.Add(new Food(checkBoxFrenchFries.Text, multiplication));
                labelToPay2.Text = allFoods.ToString();
            }
        }
        private void checkBoxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCocaColaNumber.Enabled = checkBoxCocaCola.Checked;
            if (!checkBoxCocaCola.Checked)
            {
                textBoxCocaColaNumber.Text = null;
                allFoods.Delete(checkBoxCocaCola.Text);
            }

            if (checkBoxCocaCola.Checked)
            {
                isAlreadySet = true;
                textBoxCocaColaNumber.Text = "1";
                float multiplication = Convert.ToSingle(textBoxCocaColaPrice.Text) * Convert.ToInt32(textBoxCocaColaNumber.Text);
                allFoods.Foods.Add(new Food(checkBoxCocaCola.Text, multiplication));
                labelToPay2.Text = allFoods.ToString();
            }
        }

        private void textBoxHotDogNumber_TextChanged(object sender, EventArgs e)
        {
            if (isAlreadySet)
                isAlreadySet = false;
            else if (string.IsNullOrEmpty(textBoxHotDogNumber.Text))
            {
                allFoods.Delete(checkBoxHotDog.Text);
                labelToPay2.Text = allFoods.ToString();
            }
            else if (!string.IsNullOrEmpty(textBoxHotDogNumber.Text))
            {
                allFoods.Delete(checkBoxHotDog.Text);
                float multiplication = Convert.ToSingle(textBoxHotDogPrice.Text) * Convert.ToInt32(textBoxHotDogNumber.Text);
                allFoods.Foods.Add(new Food(checkBoxHotDog.Text, multiplication));
                labelToPay2.Text = allFoods.ToString();
            }
        }
        private void textBoxHamburgerNumber_TextChanged(object sender, EventArgs e)
        {
            if (isAlreadySet)
                isAlreadySet = false;
            else if (string.IsNullOrEmpty(textBoxHamburgerNumber.Text))
            {
                allFoods.Delete(checkBoxHamburger.Text);
                labelToPay2.Text = allFoods.ToString();
            }
            else if (!string.IsNullOrEmpty(textBoxHamburgerNumber.Text))
            {
                allFoods.Delete(checkBoxHamburger.Text);
                float multiplication = Convert.ToSingle(textBoxHamburgerPrice.Text) * Convert.ToInt32(textBoxHamburgerNumber.Text);
                allFoods.Foods.Add(new Food(checkBoxHamburger.Text, multiplication));
                labelToPay2.Text = allFoods.ToString();
            }
        }
        private void textBoxFrenchFriesNumber_TextChanged(object sender, EventArgs e)
        {
            if (isAlreadySet)
                isAlreadySet = false;
            else if (string.IsNullOrEmpty(textBoxFrenchFriesNumber.Text))
            {
                allFoods.Delete(checkBoxFrenchFries.Text);
                labelToPay2.Text = allFoods.ToString();
            }
            else if (!string.IsNullOrEmpty(textBoxFrenchFriesNumber.Text))
            {
                allFoods.Delete(checkBoxFrenchFries.Text);
                float multiplication = Convert.ToSingle(textBoxFrenchFriesPrice.Text) * Convert.ToInt32(textBoxFrenchFriesNumber.Text);
                allFoods.Foods.Add(new Food(checkBoxFrenchFries.Text, multiplication));
                labelToPay2.Text = allFoods.ToString();
            }
        }
        private void textBoxCocaColaNumber_TextChanged(object sender, EventArgs e)
        {
            if (isAlreadySet)
                isAlreadySet = false;
            else if (string.IsNullOrEmpty(textBoxCocaColaNumber.Text))
            {
                allFoods.Delete(checkBoxCocaCola.Text);
                labelToPay2.Text = allFoods.ToString();
            }
            else if (!string.IsNullOrEmpty(textBoxCocaColaNumber.Text))
            {
                allFoods.Delete(checkBoxCocaCola.Text);
                float multiplication = Convert.ToSingle(textBoxCocaColaPrice.Text) * Convert.ToInt32(textBoxCocaColaNumber.Text);
                allFoods.Foods.Add(new Food(checkBoxCocaCola.Text, multiplication));
                labelToPay2.Text = allFoods.ToString();
            }
        }

        //------------------------------------- All due -------------------------------------

        private void buttonCount_Click(object sender, EventArgs e)
        {
            labelAllDue.Text = (Convert.ToSingle(labelToPay.Text) + Convert.ToSingle(labelToPay2.Text)).ToString();
            counts += Convert.ToSingle(labelAllDue.Text);
            timerCount.Start();
            timerCount.Interval = 7000;
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            timerCount.Stop();
            DialogResult message = MessageBox.Show("Clear form?", "7 seconds are up", MessageBoxButtons.OKCancel);
            if (message == DialogResult.OK)
            {
                comboBoxFuel.SelectedIndex = 1;
                textBoxNumber.Text = "10";

                radioButtonNumber.Checked = false;
                radioButtonSum.Checked = false;

                textBoxNumber.Enabled = false;
                textBoxSum.Enabled = false;

                groupBoxToPayOrToIssue.Text = "To pay";
                labelGrnOrL.Text = "grn";

                labelToPay.Text = "0";
                labelToPay2.Text = "0";
                labelAllDue.Text = "0";

                allFoods.Foods.Clear();

                checkBoxHotDog.Checked = false;
                checkBoxHamburger.Checked = false;
                checkBoxFrenchFries.Checked = false;
                checkBoxCocaCola.Checked = false;
            }
            if (message == DialogResult.Cancel || message == DialogResult.None)
            {
                timerCount.Start();
                timerCount.Interval = 7000;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show($"All revenue for the day: {counts} grn", "Exiting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (message == DialogResult.OK || message == DialogResult.None)
                this.Close();
        }
    }
}