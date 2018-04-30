using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Менеджера_гостиницы
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }
        bool sotr = true;
        bool cli = true;
        bool num = true;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet3.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelDataSet3.Rooms);
            // TODO: This line of code loads data into the 'hotelDataSet2.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hotelDataSet2.Employees);
            // TODO: This line of code loads data into the 'hotelDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDataSet1.Clients);
            // TODO: This line of code loads data into the 'hotelDataSet.PermissionTypes' table. You can move, or remove it, as needed.
            this.permissionTypesTableAdapter.Fill(this.hotelDataSet.PermissionTypes);

        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sotr == true)
            {
                if (cli == true)
                {
                    this.Height = 428;
                    this.tabControl1.Location = new Point(12, 118);
                    label1.Visible = true;
                    label2.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    button4.Visible = true;
                    cli = false;
                    tabControl1.SelectTab(tabPage1);
                }
                else
                {
                    this.Height = 368;
                    this.tabControl1.Location = new Point(12, 58);
                    label1.Visible = false;
                    label2.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    button4.Visible = false;
                    cli = true;
                }
            }
            else
            {
                this.Height = 368;
                this.tabControl1.Location = new Point(12, 58);
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button4.Visible = false;
                sotr = true;
            }
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cli == true)
            {
                if (sotr == true)
                {
                    this.Height = 428;
                    this.tabControl1.Location = new Point(12, 118);
                    label1.Visible = true;
                    label2.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    button4.Visible = true;
                    sotr = false;
                }
                else
                {
                    this.Height = 368;
                    this.tabControl1.Location = new Point(12, 58);
                    label1.Visible = false;
                    label2.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    button4.Visible = false;
                    sotr = true;
                }
            }
            else
            {
                this.Height = 368;
                this.tabControl1.Location = new Point(12, 58);
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button4.Visible = false;
                cli = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
