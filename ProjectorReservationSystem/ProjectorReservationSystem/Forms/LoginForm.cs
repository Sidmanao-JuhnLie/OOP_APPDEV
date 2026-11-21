using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectorReservationSystem.Controls;
using ProjectorReservationSystem.Helpers;

namespace ProjectorReservationSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnMin.Text = "";
            btnClose.Text = "";

            // The window is borderless, so the two top-bar buttons must do their job.
            btnMin.Click += (s, e) => WindowState = FormWindowState.Minimized;
            btnClose.Click += (s, e) => Close();

            // Purple border on the rounded input wrapper while its TextBox has focus.
            HookFocusRing(txtEmail, pnlEmailBox);
            HookFocusRing(txtPassword, pnlPasswordBox);
        }

        private static void HookFocusRing(TextBox box, RoundedPanel host)
        {
            host.Click += (s, e) => box.Focus();
            box.Enter += (s, e) => host.BorderColor = Theme.Brand;
            box.Leave += (s, e) => host.BorderColor = Theme.BarGray;
        }

        // TODO (authentication): the project does not contain any login/database code yet,
        // so btnSubmit has no Click handler. When your teammate's authentication method is
        // available, wire it here, e.g.  btnSubmit.Click += btnSubmit_Click;
        // Read the inputs from txtEmail.Text and txtPassword.Text.
        // (Both boxes are now EMPTY until the user types; the grey hint text is PlaceholderText.)

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
