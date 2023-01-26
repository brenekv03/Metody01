using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posledniClen;
            int diference;
            MessageBox.Show("Součet prvků posloupnosti je : " + SoucetArPosl(5,7,6,out posledniClen,out diference) + "\nDifeference je: " + diference + "\nPoslední člen: " + posledniClen);
        }
        static private int SoucetArPosl(int a1, int a2, int n, out int posledniClen, out int diference)
        {
            int soucetPrvku = 0;
            diference = a2- a1;
            posledniClen = a1;
            soucetPrvku = posledniClen;
            for(int i = 0;i<n-1;i++)
            {
                int cislo = posledniClen + diference;
                soucetPrvku += cislo;
                posledniClen = cislo;
            }
            return soucetPrvku;
        }
    }
}
