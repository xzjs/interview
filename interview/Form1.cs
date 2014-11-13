using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrB = new int[7];

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arrA = new int[7] { 49, 38, 65, 97, 76, 13, 27 };
            MergeSort(arrA, 0, 6);
            string result = null;
            foreach (var item in arrA)
            {
                result += item + " ";
            }
            MessageBox.Show(result);
        }

        void Merge(int[] a, int low, int mid, int high)
        {
            arrB = (int[])a.Clone(); ;
            int i, j, k;
            for (i = low, j = mid + 1, k = i; i <= mid && j <= high; k++)
            {
                if (arrB[i] < arrB[j])
                {
                    a[k] = arrB[i++];
                }
                else
                {
                    a[k] = arrB[j++];
                }
            }
            while (i <= mid)
            {
                a[k++] = arrB[i++];
            }
            while (j <= high)
            {
                a[k++] = arrB[j++];
            }
        }

        void MergeSort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(a, low, mid);
                MergeSort(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
    }
}
