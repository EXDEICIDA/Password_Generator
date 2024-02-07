using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Generator : Form
    {

        int currentPasswordLenght = 0;
        Random character = new Random();


      

        public Generator()
        {
            InitializeComponent();
            //we are setting up minumum and maximu lenght for the password trackbar
            passwordLenghtSlider.Minimum = 5;
            passwordLenghtSlider.Maximum = 20;
            passwordGenerator(5);
          
        }


        private void passwordGenerator(int passwordLength)
        {
            //listing all the characters

            String allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz!@#$%^&";

            String randomPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];

            }
            lbPassword.Text = randomPassword;
        }
        private void copyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbPassword.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            passwordLenghtLabel.Text = "Password Length: " + passwordLenghtSlider.Value.ToString();
            currentPasswordLenght = passwordLenghtSlider.Value;
            passwordGenerator(currentPasswordLenght);
        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void Generator_Load(object sender, EventArgs e)
        {

        }
    }
}
