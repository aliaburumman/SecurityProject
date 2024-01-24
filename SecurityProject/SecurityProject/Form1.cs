using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityProject
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private int roundNumber = 1;

        private bool IsValidBinary(string input)
        {
            return input.All(c => c == '0' || c == '1');
        }

        private string ExpansionPerm(string plainText)
        {
            int[] EXP = { 4, 1, 2, 3, 2, 3, 4, 1 };
            StringBuilder halfPlain = new StringBuilder();
            StringBuilder plain = new StringBuilder();

            for (int i = 4; i < 8; i++)
            {
                halfPlain.Append(plainText[i]);
            }

            int k = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j + 1 == EXP[i])
                    {
                        plain.Append(halfPlain[j]);
                    }
                }
            }

            return plain.ToString();
        }



        private string Perm(string plainText, int s)
{
    StringBuilder plain = new StringBuilder();
    string temp = plainText;
    int[] IP = { 2, 6, 3, 1, 4, 8, 5, 7 };
    int[] IPinv = { 4, 1, 3, 5, 7, 2, 8, 6 };

    if (s == 0)
    {
        for (int j = 0; j < 8; j++)
        {
            int index = IP[j] - 1; 
            if (index >= 0 && index < temp.Length)
            {
                plain.Append(temp[index]);
            }
        }
    }
    else
    {
        for (int j = 0; j < 8; j++)
        {
            int index = IPinv[j] - 1;  
            if (index >= 0 && index < temp.Length)
            {
                plain.Append(temp[index]);
            }
        }
    }

    return plain.ToString();
        }


        private string generateSubKey(ref string key, int shiftNum)
        {
            int[] P8 = { 6, 3, 7, 4, 8, 5, 10, 9 };
            string k1 = new string(' ', 8);
            int length = key.Length;

            string firstHalf = key.Substring(0, length / 2);
            string secondHalf = key.Substring(length / 2);

            string shiftedFirstHalf = firstHalf.Substring(shiftNum) + firstHalf.Substring(0, shiftNum);
            string shiftedSecondHalf = secondHalf.Substring(shiftNum) + secondHalf.Substring(0, shiftNum);
            key = shiftedFirstHalf + shiftedSecondHalf;


            int k = 0;
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i + 1 == P8[j])
                    {
                        k1 = k1.Remove(k, 1).Insert(k, key[i].ToString());
                        k++;
                    }
                }
            }

            return k1;
        }


        string Substitution(string plainText)
        {
            char[] plain = new char[4];
            int row = -1;
            int col = -1;
            int[,] S0 = { { 1, 0, 3, 2 }, { 3, 2, 1, 0 }, { 0, 2, 1, 3 }, { 3, 1, 3, 2 } };
            int[,] S1 = { { 0, 1, 2, 3 }, { 2, 0, 1, 3 }, { 3, 0, 1, 0 }, { 2, 1, 0, 3 } };
            int k = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 2; j < 4; j++)
                {
                    if (i == 0 && j == 3)
                    {
                        if (plainText[i] == '1' && plainText[j] == '1')
                        {
                            row = 3;
                        }
                        else if (plainText[i] == '1' && plainText[j] == '0')
                        {
                            row = 2;
                        }
                        else if (plainText[i] == '0' && plainText[j] == '1')
                        {
                            row = 1;
                        }
                        else if (plainText[i] == '0' && plainText[j] == '0')
                        {
                            row = 0;
                        }
                    }
                    else if (i == 1 && j == 2)
                    {
                        if (plainText[i] == '1' && plainText[j] == '1')
                        {
                            col = 3;
                        }
                        else if (plainText[i] == '1' && plainText[j] == '0')
                        {
                            col = 2;
                        }
                        else if (plainText[i] == '0' && plainText[j] == '1')
                        {
                            col = 1;
                        }
                        else if (plainText[i] == '0' && plainText[j] == '0')
                        {
                            col = 0;
                        }
                    }
                }
            }

            if (S0[row, col] == 0)
            {
                plain[k++] = '0';
                plain[k++] = '0';
            }
            else if (S0[row, col] == 1)
            {
                plain[k++] = '0';
                plain[k++] = '1';
            }
            else if (S0[row, col] == 2)
            {
                plain[k++] = '1';
                plain[k++] = '0';
            }
            else if (S0[row, col] == 3)
            {
                plain[k++] = '1';
                plain[k++] = '1';
            }

            for (int i = 4; i < 6; i++)
            {
                for (int j = 6; j < 8; j++)
                {
                    if (i == 4 && j == 7)
                    {
                        if (plainText[i] == '1' && plainText[j] == '1')
                        {
                            row = 3;
                        }
                        else if (plainText[i] == '1' && plainText[j] == '0')
                        {
                            row = 2;
                        }
                        else if (plainText[i] == '0' && plainText[j] == '1')
                        {
                            row = 1;
                        }
                        else if (plainText[i] == '0' && plainText[j] == '0')
                        {
                            row = 0;
                        }
                    }
                    else if (i == 5 && j == 6)
                    {
                        if (plainText[i] == '1' && plainText[j] == '1')
                        {
                            col = 3;
                        }
                        else if (plainText[i] == '1' && plainText[j] == '0')
                        {
                            col = 2;
                        }
                        else if (plainText[i] == '0' && plainText[j] == '1')
                        {
                            col = 1;
                        }
                        else if (plainText[i] == '0' && plainText[j] == '0')
                        {
                            col = 0;
                        }
                    }
                }
            }

            if (S1[row, col] == 0)
            {
                plain[k++] = '0';
                plain[k++] = '0';
            }
            else if (S1[row, col] == 1)
            {
                plain[k++] = '0';
                plain[k++] = '1';
            }
            else if (S1[row, col] == 2)
            {
                plain[k++] = '1';
                plain[k++] = '0';
            }
            else if (S1[row, col] == 3)
            {
                plain[k++] = '1';
                plain[k++] = '1';
            }

            string result = new string(plain);
            return result;
        }

        private string PBox(string plainText)
        {
            char[] plain = new char[4];
            string temp = plainText;
            int[] P4 = { 2, 4, 3, 1 };
            int k = 0;

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i + 1 == P4[j])
                    {
                        plain[k++] = temp[i];
                    }
                }
            }


            return new string(plain);
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void KeyWithP10_TextChanged(object sender, EventArgs e)
        {

        }

        public void P10Key_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text.Trim();

            if (!IsValidBinary(key))
            {
                MessageBox.Show("Invalid input. Please enter a binary string consisting of 0s and 1s only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox1.TextLength != 10)
            {
                MessageBox.Show($"An error occurred:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                textBox1.ReadOnly = true;
                 key = textBox1.Text.ToString();
                int[] P10 = { 3, 5, 2, 7, 4, 10, 1, 9, 8, 6 };
                StringBuilder newKey = new StringBuilder(10);

                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (i + 1 == P10[j])
                        {
                            newKey.Append(key[i]);
                        }
                    }
                }

                textBox1.Text = newKey.ToString();
            }
            
        }

        private void IPButton_Click(object sender, EventArgs e)
        {

            string plain = textBox2.Text.Trim();

            if (!IsValidBinary(plain))
            {
                MessageBox.Show("Invalid input. Please enter a binary string consisting of 0s and 1s only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox2.TextLength!=8) {
                
                    MessageBox.Show($"An error occurred:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            } else {
                EndButton.Visible = false;

                ogPlain.Visible = true;
                textBox2.ReadOnly = true;
                if (roundNumber == 1)
                {
                    ogPlain.Text = textBox2.Text;
                }
                try
                {
                    if (roundNumber >= 2 && roundNumber % 2 == 0) { roundNumber++;
                        roundNum.Text = roundNumber.ToString();
                    }

                    plain = textBox2.Text.ToString();
                    int s = 0;
                    textBox2.Text = Perm(plain, s);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void expansion_TextChanged(object sender, EventArgs e)
        {

        }

        private void expButton_Click(object sender, EventArgs e)
        {
            try
            {
                string plain = textBox2.Text.ToString();
                expansion.Text = ExpansionPerm(plain);
                EndButton.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void xor_TextChanged(object sender, EventArgs e)
        {

        }

        private void xorButton_Click(object sender, EventArgs e)
        {
            string tempK1 = k1.Text.ToString();
            string tempPlainText = expansion.Text.ToString();

            char[] result = new char[tempK1.Length];

            for (int i = 0; i < tempK1.Length; i++)
            {
                if (tempK1[i] == tempPlainText[i])
                {
                    result[i] = '0';
                }
                else
                {
                    result[i] = '1';
                }
            }

            xor.Text = new string(result);
        }

        private void SubKeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                string key = textBox1.Text.ToString();
                int s = 1;
                k1.Text = generateSubKey(ref key, s);
                s++;
                k2.Text = generateSubKey(ref key, s);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = xor.Text.ToString();
                subsText.Text=Substitution(plainText);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void perm4_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = subsText.Text.ToString();
                p4.Text = PBox(plainText);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xor4button_Click(object sender, EventArgs e)
        {
            string plainText = textBox2.Text.ToString().Substring(0, 5);
            string plainText2 = p4.Text.ToString();
            char[] result = new char[plainText.Length];
            if (roundNumber % 2 == 1)
            {
                swapButton.Visible = true;

               

                for (int i = 0; i < 4; i++)
                {
                    if (plainText[i] == plainText2[i])
                    {
                        result[i] = '0';
                    }
                    else
                    {
                        result[i] = '1';
                    }
                }
                xor4.Text = new string(result);

                string temp1 = textBox2.Text.ToString();
                string temp2 = xor4.Text.ToString();

                char[] resultt = new char[temp1.Length];

                for (int i = 0; i < 4; i++)
                {
                    resultt[i] = temp2[i];
                    resultt[i + 4] = temp1[i+4];
                }

                textBox2.Text = new string(resultt);
                            }
            else
            {
                IPButton.Visible=true;
                EndButton.Visible = true;
                xorK2Button.Visible = false;
                xorButton.Visible = true;
                EndButton.Visible=true;
                roundNumber++;
                for (int i = 0; i < 4; i++)
                {
                    if (plainText[i] == plainText2[i])
                    {
                        result[i] = '0';
                    }
                    else
                    {
                        result[i] = '1';
                    }
                }
                xor4.Text = new string(result);
                string temp1 = textBox2.Text.ToString();
                string temp2 = xor4.Text.ToString();

                char[] resultt = new char[temp1.Length];

                for (int i = 0; i < 4; i++)
                {
                    resultt[i] = temp2[i];
                    resultt[i + 4] = temp1[i + 4];
                }

                textBox2.Text = new string(resultt);
                roundNum.Text = roundNumber.ToString();

            }

        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            
            EndButton.Visible = true;
                if (roundNumber % 2 != 0)
                {
                    roundNumber++;
                    string temp1 = textBox2.Text.ToString();
                    string temp2 = xor4.Text.ToString();

                    char[] result = new char[temp1.Length];

                    for (int i = 0; i < 4; i++)
                    {
                        result[i] = temp1[i+4];
                        result[i + 4] = temp1[i];
                    }

                    textBox2.Text = new string(result);
                    roundNum.Text = roundNumber.ToString();
                swapButton.Visible = false;
                xorButton.Visible = !xorButton.Visible;
                xorK2Button.Visible= !xorK2Button.Visible;
                IPButton.Visible = !IPButton.Visible;
                EndButton.Visible = true;

                }


        }

        private void xorK2Button_Click(object sender, EventArgs e)
        {
            string tempK2 = k2.Text.ToString();
            string tempPlainText = expansion.Text.ToString();

            char[] result = new char[tempK2.Length];

            for (int i = 0; i < tempK2.Length; i++)
            {
                if (tempK2[i] == tempPlainText[i])
                {
                    result[i] = '0';
                }
                else
                {
                    result[i] = '1';
                }
            }

            xor.Text = new string(result);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            try
            {
                int s = 1;
                ipInv.Text = Perm(textBox2.Text, s);
                xor4button.Visible = false;
                xorK2Button.Visible = false;
                EndButton.Visible = false;
                expButton.Visible = false;
                IPButton.Visible= false;
                SubKeyButton.Visible=false;
                SubsButton.Visible=false;
                swapButton.Visible=false;
                xorButton.Visible=false;
                perm4.Visible=false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xor4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipInv_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundNum_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
