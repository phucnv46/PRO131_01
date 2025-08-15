using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131_01.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Form? curentForm;

        private void ChangeForm(Form form)
        {
            if (curentForm != null)
            {
                curentForm.Close();
            }

            curentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void menu1_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {
            switch (e.Value.ID)
            {
                default: ChangeForm(new FormBanHang());
                    break;
                case "bh":
                    {
                        ChangeForm(new FormBanHang());
                        break;
                    }

                case "sp":
                    {
                        ChangeForm(new FormQLSP());
                        break;
                    }
            }
        }
    }
}
