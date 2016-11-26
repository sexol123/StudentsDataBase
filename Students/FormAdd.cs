﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Students
{
    public partial class FormAdd : Form
    {
		void ClFild()
        {
            textBoxfio.Clear();
            textBoxadr.Clear();
        }
        private BindingList<Student> _liststudents;

        public FormAdd(BindingList<Student> List)
        {
            _liststudents = List;
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student st = new Student();

            if (string.IsNullOrWhiteSpace(textBoxfio.Text))
            {
                MessageBox.Show("Введите ФИО", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //
                return;
            }
            st.FIO = textBoxfio.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(textBoxadr.Text))
            {
                MessageBox.Show("Введите адресс", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            st.adres = textBoxadr.Text.Trim();
            int age;
            if (!Int32.TryParse(comboBoxage.Text, out age))
            {
                MessageBox.Show("Введите возраст", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            st.age = age;
            int stepuha;
            if (!Int32.TryParse(comboBoxstep.Text, out stepuha))
            {
                MessageBox.Show("Введите степуху", "Ошибка ввода", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            st.stepuha = stepuha;
            
               _liststudents.Add(st);
            ClFild();
            MessageBox.Show("Студент успешно добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxfio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxstep_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
