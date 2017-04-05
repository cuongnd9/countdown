using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpk.Value = DateTime.Now;
            
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpk.Value <= DateTime.Now)
            MessageBox.Show("Please select a reasonable time", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if(bunifuCheckbox1.Checked)
                {
                    string[] text =new string[] {tbTitle.Text,dtpk.Value.ToString() };
                    File.Instance.writeFile(text);
                    
                }
                else
                {
                    string[] text = new string[] {"",""};
                    File.Instance.writeFile(text);
                }
                Form2 f = new Form2(tbTitle.Text, dtpk.Value);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
           
         
         
      
        }

      

        private void dtpk_onValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] text=File.Instance.readFile();
            if (text[0] !="")
                tbTitle.Text = text[0];
            
            if (text[1] !="")
                dtpk.Value = Convert.ToDateTime(text[1]);
           
        }
    }
}
