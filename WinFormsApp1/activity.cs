using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class activity : Form
    {
        private bool _Haschange;
        private bool _Isnewact;
        public activity()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            this.lsta.Enabled = false;
            this.btndelete.Enabled = false;
            this.btnsafe.Enabled = false;
            this.btncancel.Enabled = false;
            this.btnadd.Enabled = true;
            this.txta.Enabled = false;

            //enable/disable the listbox based on number items
            this.lsta.Enabled = this.lsta.Items.Count > 0;
            this.lsta.SelectedIndex = -1;

            _Haschange = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Addnewa();
        }

        private void Addnewa()
        {
            if (_Haschange) {
                if (MessageBox.Show("Guardar cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (!this.SaveChanges()) {
                        return;
                    }
                }
            }
            btncancel.Enabled = true;
            btnadd.Enabled = true;
            btnsafe.Enabled = true;

            txta.Enabled = true;
            txta.Clear();
            txta.Focus();

            _Isnewact = true;
        }

        private bool SaveChanges()
        {
            if (txta.Text.Length == 0) {
                MessageBox.Show("Debe escribir un nombre para la actividad", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_Isnewact)
            {
                this.lsta.Items.Add(txta.Text);
                this.Reset();
            }
            else
            {
                this.lsta.Items[lsta.SelectedIndex] = txta.Text;
                MessageBox.Show("Guardado correctamente");
            }
            return true;
        }

        private void btnsafe_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
        }

        private void activity_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Guardar cambios?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (this.SaveChanges())
                {

                    e.Cancel = true;
                    return;
                }
            }
            else if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.deleteact();
        }

        private void deleteact()
        {
            if (MessageBox.Show("Desea eliminar la actividad?", "Confirmar Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if(lsta.SelectedIndex >=0 && lsta.SelectedIndex < lsta.SelectedItems.Count)
                {
                    this.lsta.Items.RemoveAt(lsta.SelectedIndex);
                    Reset();
                }
            }
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            _Haschange = true;
        }
    }
}
