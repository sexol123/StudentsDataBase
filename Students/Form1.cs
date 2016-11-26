using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Xml;

namespace Students
{

    public partial class Form1 : Form
    {
        private BindingList<Student> liststudents1;
        public string FileName;

        internal BindingList<Student> Liststudents1
        {
            get { return liststudents1; }

            set { liststudents1 = value; }
        }

        public bool AddExtension { get; set; }
        public bool CreatePrompt { get; set; }
        public bool OverwritePrompt { get; set; }

        public Form1()
        {


            InitializeComponent();
            liststudents1 = new BindingList<Student>();
            dataGridView1.DataSource = liststudents1;



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAddStud_Click(object sender, EventArgs e)
        {
            new FormAdd(liststudents1).ShowDialog();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[0].Value = textBoxfio.Text;
        }

        private void btRemStud_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var result = MessageBox.Show("Удалить студента  ?", "Уведомление", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (DialogResult.OK != result) return;
            ClFild();
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }

        public void ClFild()
        {
            textBoxfio.Clear();
            textBoxage.Clear();
            textBoxstep.Clear();
            textBoxadr.Clear();
            textBoxstep1.Clear();
        }

        private void TestButon_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            liststudents1.Add(new Student
            {
                FIO = "Васильев Василий Васильевич",
                age = 20,
                adres = "Vinnitsa",
                stepuha = 200000
            });
        }






        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {

            btPrint.Enabled = dataGridView1.Rows.Count != 0;
            btRemStud.Enabled = dataGridView1.Rows.Count != 0;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                btRemStud.Enabled = false;
                return;
            }
            //btRemStud.Enabled = true;
            textBoxfio.Text = dataGridView1.SelectedCells[0].Value.ToString();

            textBoxadr.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            textBoxage.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            textBoxstep.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxstep1.Text = dataGridView1.SelectedCells[3].Value.ToString();


        }



        private void checkBoxEdit_CheckedChanged(object sender, EventArgs e)
        {

            if (dataGridView1.ReadOnly == false)
            {
                // btRemStud.Enabled = true;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                btRemStud.Enabled = false;
            }
            //dataGridView1.ReadOnly = dataGridView1.ReadOnly == false;

        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.Filter = "SData files (*.SData)|*.SData|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Файли XML (*.xml)|*.xml";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.OverwritePrompt = true;
            FileName = null;
            saveFileDialog1.FileName = FileName ?? "StudentList";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            FileName = Path.GetFullPath(saveFileDialog1.FileName);
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(FileName, Encoding.Unicode);
                writer.WriteStartDocument();
                writer.WriteStartElement("DataGridViev");
                writer.WriteStartElement("StudentList");
                foreach (Student student in liststudents1)
                {
                    
                    writer.WriteStartElement("Student");
                    writer.WriteAttributeString("Stipendia", student.stepuha.ToString());
                    writer.WriteAttributeString("Adress", student.adres);
                    writer.WriteAttributeString("Age", student.age.ToString());
                    writer.WriteAttributeString("Name", student.FIO);
                    writer.WriteEndElement();
                   
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения дынных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }

        }


        private void btOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Фаилы XML (*.xml)|*.xml";
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                
                 return;
            }
            ClFild();
            FileName = dlg.FileName;
            liststudents1.Clear();
       
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(FileName);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "Student")
                        {
                            Student student = new Student
                            {
                                FIO = reader.GetAttribute("Name"),
                                age = int.Parse(reader.GetAttribute("Age")),
                                adres = reader.GetAttribute("Adress"),
                                stepuha = int.Parse(reader.GetAttribute("Stipendia"))
                                
                            };
                            
                            Liststudents1.Add(student);
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }




        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btClAll_Click(object sender, EventArgs e)
        {
            ClFild();
            liststudents1?.Clear();
            MessageBox.Show("Очищено","Список студентов",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}