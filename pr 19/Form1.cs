using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------------------------
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2(); // создание объекта класса Form2
            newF.Show(); // открытие формы newF
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // закрытие формы
        }
        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // очистка текстовых полей
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "Введите число!"); // всплывающая подсказка для textBox2
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(textBox3, "сюда тоже введите число!"); // всплывающая подсказка для textBox3
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(textBox1, "тут будет ваш результат!"); // всплывающая подсказка для textBox1
        }

        private void btn_Math1_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_Math1, "Выполнить расчет");
        }
        private void btn_Math1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btn_Close1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_Close1, "выход из приложения");
        }

       
    }

}
