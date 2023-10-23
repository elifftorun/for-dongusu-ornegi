using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongusu_ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            lstSayilar.Items.Clear();
            int baslangic=Convert.ToInt32(txtBaslangic.Text);
            int bitis=Convert.ToInt32(txtBitis.Text);

            for (int i = baslangic; i <= bitis; i++)
            {
                lstSayilar.Items.Add(i);
            }

        }
    }
}
