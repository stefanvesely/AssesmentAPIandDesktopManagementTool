using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAdminApp.Data.Services;
using WinFormsAdminApp.DataModel;
using WinFormsAdminApp.UniveralClasses;

namespace WinFormsAdminApp.DockingForms
{
    public partial class Stores : Form
    {
        private FullInteractionService _fic;
        private LoadingClass loading = new LoadingClass();
        private List<Store> stores = new List<Store>();
        public Stores()
        {
            InitializeComponent();
            _fic = new FullInteractionService(new TestDBEntities());
            UpdateForm();
        }

        private async void UpdateForm ()
        {
            loading.ShowLoading();
            stores.Clear();
            dgvStores.Rows.Clear();
            stores = await _fic.GetAllStores();
            foreach (Store store in stores)
            {
                dgvStores.Rows.Add(store.StoreID, store.StoreName, store.Address, store.Telephone, store.Active);
            }
            loading.CloseLoading();
        }

        private async void btnNew_Click(object sender, EventArgs e)
        {
            await _fic.AddStore(new Store()
            {
                StoreName = tbNewName.Text,
                Address = rtbNewAddress.Text,
                Telephone = tbNewTelephone.Text,
            });
            UpdateForm();
        }

        private void dgvStores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUpdateName.Text = dgvStores.Rows[dgvStores.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rtbUpdateAddress.Text = dgvStores.Rows[dgvStores.CurrentCell.RowIndex].Cells[2].Value.ToString();
            tbUpdateTelephone.Text = dgvStores.Rows[dgvStores.CurrentCell.RowIndex].Cells[3].Value.ToString();
            cbUpdateActive.Checked =Convert.ToBoolean(dgvStores.Rows[dgvStores.CurrentCell.RowIndex].Cells[4].Value.ToString());
            tbUpdateName.Enabled = true;
            tbUpdateTelephone.Enabled = true;
            rtbUpdateAddress.Enabled = true;
            cbUpdateActive.Enabled = true;
            btnSaveUpdate.Enabled = true;
        }

        private async void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            await _fic.UpdateStore(new Store()
            {
                StoreID =int.Parse(dgvStores.Rows[dgvStores.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                StoreName = tbUpdateName.Text,
                Telephone = tbUpdateTelephone.Text,
                Address = rtbUpdateAddress.Text,
                Active = cbUpdateActive.Checked
            });
            UpdateForm();
        }
    }
}
