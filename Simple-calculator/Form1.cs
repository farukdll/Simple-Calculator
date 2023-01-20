using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple__calculator
{
    public partial class Form1 : Form
    {
        private char _process;
        private bool _screen_clear;
        private int _first_digit;
        public Form1()
        {
            InitializeComponent();
        }

        private void number_0_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "0";
        }

        private void number_1_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "1";
        }

        private void number_2_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "2";
        }

        private void number_3_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "3";
        }

        private void number_4_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "4";
        }

        private void number_5_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "5";
        }

        private void number_6_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "6";
        }

        private void number_7_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "7";
        }

        private void number_8_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "8";
        }

        private void number_9_button_Click(object sender, EventArgs e)
        {
            if (_screen_clear)
            {
                screen_label.Text = "";
                _screen_clear = false;
            }

            if (screen_label.Text == "0")
                screen_label.Text = "";

            screen_label.Text += "9";
        }

        private void backslash_button_Click(object sender, EventArgs e)
        {
            _process = '/';
            _screen_clear = true;
            _first_digit = Convert.ToInt32(screen_label.Text);
        }

        private void star_button_Click(object sender, EventArgs e)
        {
            _process = '*';
            _screen_clear = true;
            _first_digit = Convert.ToInt32(screen_label.Text);
        }

        private void negative_button_Click(object sender, EventArgs e)
        {
            _process = '-';
            _screen_clear = true;
            _first_digit = Convert.ToInt32(screen_label.Text);
        }

        private void positive_button_Click(object sender, EventArgs e)
        {
            _process = '+';
            _screen_clear = true;
            _first_digit = Convert.ToInt32(screen_label.Text);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            screen_label.Text = "0";
        }

        private void equals_button_Click(object sender, EventArgs e)
        {
            int secont_number = Convert.ToInt32(screen_label.Text);
            int result;

            switch (_process)
            {
                case '+': result = _first_digit + secont_number; break;
                case '-': result = _first_digit - secont_number; break;
                case '*': result = _first_digit * secont_number; break;
                case '/': result = _first_digit / secont_number; break;
                default: result = 0; break;
            }

            screen_label.Text = Convert.ToString(result);
        }
    }
}
