using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211220_RomanLetters
{
    public partial class Form1 : Form
    {
        List<string> letters = new List<string> {"I","V","X","L","C","D","M"};

        public Form1()
        {
            InitializeComponent();
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            ConvertIfValid();
        }

        void ConvertIfValid()
        {
            int? number = GetNumber();

            if (number != null)
            {
                output_label.Text= ConvertMethod((int)number);
            }

            else
            {
                output_label.Text = "";
            }
        }

        int? GetNumber()
        {
            int? number = null;
            int temp_number = 0;

            try
            {
                temp_number = Convert.ToInt32(input_textbox.Text);

                if (temp_number > 3999)
                {
                    MessageBox.Show("Lütfen 3999'dan küçük bir sayı giriniz.");
                }

                else if (temp_number <= 0)
                {
                    MessageBox.Show("Lütfen 0'dan büyük bir sayı giriniz.");
                }

                else
                {
                    number = temp_number;
                    //output_label.Text = ConvertMethod(number);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen bir tam sayı giriniz.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Lütfen 3999'dan küçük bir sayı giriniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return number;
        }

        string ConvertMethod(int number)
        {
            string text = "";

            for (int i = 3; i >= 0; i--)
            {
                int division = number / Convert.ToInt32(Math.Pow(10, i));

                number = number % Convert.ToInt32(Math.Pow(10, i));

                switch (division)
                {
                    case 1:
                        text += letters[i * 2];
                        break;
                    case 2:
                        text += letters[i * 2] + letters[i * 2];
                        break;
                    case 3:
                        text += letters[i * 2] + letters[i * 2] + letters[i * 2];
                        break;
                    case 4:
                        text += letters[i * 2] + letters[i * 2 + 1];
                        break;
                    case 5:
                        text += letters[i * 2 + 1];
                        break;
                    case 6:
                        text += letters[i * 2 + 1] + letters[i * 2];
                        break;
                    case 7:
                        text += letters[i * 2 + 1] + letters[i * 2] + letters[i * 2];
                        break;
                    case 8:
                        text += letters[i * 2 + 1] + letters[i * 2] + letters[i * 2] + letters[i * 2];
                        break;
                    case 9:
                        text += letters[i * 2] + letters[i * 2 + 2];
                        break;
                    default:
                        break;
                }
            }

            return text;
        } 

        private void deconvert_button_Click_1(object sender, EventArgs e)
        {
            DeconvertIfValid();
        }

        void DeconvertIfValid()
        {
            string input_text = input_textbox2.Text.ToUpper();

            input_text=input_text.Replace("İ", "I");

            output_label2.Text = (DeconvertMethod(input_text)).ToString();

            if (output_label2.Text == "0")
            {
                MessageBox.Show("Lütfen geçerli bir metin girişi yapınız.");
            }
        }

        int DeconvertMethod(string text)
        {
            text += "ööö";
            int number = 0;

            while (text[0] == 'M')
            {
                number += 1000;
                text = text.Remove(0, 1);
            }

            for (int i = 2; i >= 0; i--)
            {
                if (text[0].ToString() == letters[2 * i + 1])
                {
                    if (text[1].ToString() == letters[2 * i])
                    {
                        if (text[2].ToString() == letters[2 * i])
                        {
                            if (text[3].ToString() == letters[2 * i])
                            {
                                number += 8 * Convert.ToInt32(Math.Pow(10, i));
                                text = text.Remove(0, 4);
                            }

                            else
                            {
                                number += 7 * Convert.ToInt32(Math.Pow(10, i));
                                text = text.Remove(0, 3);
                            }
                        }

                        else
                        {
                            number += 6 * Convert.ToInt32(Math.Pow(10, i));
                            text = text.Remove(0, 2);
                        }
                    }

                    else
                    {
                        number += 5 * Convert.ToInt32(Math.Pow(10, i));
                        text = text.Remove(0, 1);
                    }
                }

                else if (text[0].ToString() == letters[2 * i])
                {
                    if (text[1].ToString() == letters[2 * i + 1])
                    {
                        number += 4 * Convert.ToInt32(Math.Pow(10, i));
                        text = text.Remove(0, 2);
                    }

                    else if (text[1].ToString() == letters[2 * i])
                    {
                        if (text[2].ToString() == letters[2 * i])
                        {
                            number += 3 * Convert.ToInt32(Math.Pow(10, i));
                            text = text.Remove(0, 3);
                        }

                        else
                        {
                            number += 2 * Convert.ToInt32(Math.Pow(10, i));
                            text = text.Remove(0, 2);
                        }
                    }

                    else
                    {
                        number += Convert.ToInt32(Math.Pow(10, i));
                        text = text.Remove(0, 1);
                    }
                }
            }

            text = text.Trim('ö');

            return (text.Length == 0 ? number : 0);
        }
    }    
}
