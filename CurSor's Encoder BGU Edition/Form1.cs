using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CurSor_s_Encoder_BGU_Edition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CaesarEncode(string text, int k)
        {
            string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            alfabet += alfabet.ToLower();
            var letterQty = alfabet.Length;
            var retVal = "";

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                int index = alfabet.IndexOf(c);
                if (index < 0) retVal += c.ToString();
                else
                {
                    int codeIndex = (letterQty + index + k) % letterQty;
                    retVal += alfabet[codeIndex];
                }
            }
            return retVal;
        }

        string LosungEncode(string text, string k)
        {
            string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            alfabet += alfabet.ToLower();

            k = k.ToUpper();
            k += k.ToLower();
            string retVal = "";

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                int index = alfabet.IndexOf(c);
                if (index < 0) retVal += c.ToString();
                else retVal += k[index];
            }

            return retVal;
        }

        string PolibianEncode(string text, char[,] key)
        {
            text = text.ToUpper();
            string retVal = "";

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ') retVal += "| ";
                else
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (key[j, k] == text[i])
                        {
                            k++; j++;
                            retVal += k + "" + j + " ";
                            continue;
                        }
                    }
                }
            }
            return retVal;
        }

        private void cbxEncType_TextChanged(object sender, EventArgs e)
        {
            if (cbxEncType.Text == "Шифр Цезаря")
            {
                tbxKey.Visible = lblKey.Visible = true;
                tbxKey.Text = "";
            }
            else if (cbxEncType.Text == "Лозунговый шифр")
            {
                tbxKey.Text = "ДЯИНАБВГЕЁЖЗЙКЛМОПРСТУФХЦЧШЩЫЬЪЭЮ";
                tbxKey.Visible = lblKey.Visible = true;
            }
            else if (cbxEncType.Text == "Шифр Трисемуса")
            {
                tbxKey.Text = "ДЯИНАБВГЕЁЖЗЙКЛМОПРСТУФХЦЧШЩЫЬЪЭЮ";
                tbxKey.Visible = lblKey.Visible = true;
            }
            else
            {
                tbxKey.Text = "";
                tbxKey.Visible = lblKey.Visible = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(tbxBeginText.Text == "") lblTextEnd.Text = "------------------------------\r\n\r\n>>> PHURUM <<<\r\n\r\n> ERRATUM: Deficient";
            else if (cbxEncType.Text == "Шифр Цезаря")
            {
                try
                {
                    int key = Convert.ToInt32(tbxKey.Text);
                    lblTextEnd.Text = "------------------------------\r\n\r\n" + 
                        CaesarEncode(tbxBeginText.Text, Convert.ToInt32(tbxKey.Text));
                }
                catch
                {
                    MessageBox.Show("Ключ шифра Цезаря не должен содержать букв", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cbxEncType.Text == "Лозунговый шифр")
            {
                if (tbxKey.Text.Length < 33) MessageBox.Show("Ключ Лозунгового шифра должен быть длинной 33 символа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else lblTextEnd.Text = "------------------------------\r\n\r\n" +
                    LosungEncode(tbxBeginText.Text, tbxKey.Text);
            }
            else if (cbxEncType.Text == "Полибианский квадрат")
            {
                char[,] key =
                {
                { 'А', 'Б', 'В', 'Г', 'Д', 'Е' },
                { 'Ё', 'Ж', 'З', 'И', 'Й', 'К' },
                { 'Л', 'М', 'Н', 'О', 'П', 'Р' },
                { 'С', 'Т', 'У', 'Ф', 'Х', 'Ц' },
                { 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь' },
                { 'Э', 'Ю', 'Я', ' ', ' ', ' '}};

                lblTextEnd.Text = "------------------------------\r\n\r\n" +
                    PolibianEncode(tbxBeginText.Text, key);
            }
            else if (cbxEncType.Text == "Шифр Трисемуса")
            {
                if(tbxKey.Text.Length < 33) MessageBox.Show("Ключ шифра Трисемуса должен быть длинной 33 символа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string keylenght = tbxKey.Text;
                    char[,] key = new char[6, 6];

                    for (int i = 0; i < key.GetLength(0); i++)
                    {
                        for (int j = 0; j < key.GetLength(1); j++)
                        {
                            if(keylenght.Length != 0)
                            {
                                key[j, i] = keylenght[0];
                                keylenght = keylenght.Substring(1);
                            }
                        }
                    }

                    lblTextEnd.Text = "------------------------------\r\n\r\n" +
                        PolibianEncode(tbxBeginText.Text, key);
                }
            }
        }
    }
}
