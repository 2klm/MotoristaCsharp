using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using testInterfaceModele.Forms;

namespace testInterfaceModele
{
    public partial class MainForm : Form
    {
        //Champs
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructeur
        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structures
        private struct CouleursRGB
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(250, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Méthodes
        private void ActiverBouton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactiverBouton();
                //Bouton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Bordure à gauche du bouton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icone du formulaire actif
                currentChildFormIcon.IconChar = currentBtn.IconChar;
                currentChildFormIcon.IconColor = color;
            }
        }

        private void DesactiverBouton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            currentBtnLabel.Text = childForm.Text;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ActiverBouton(sender, CouleursRGB.color1);
            OpenChildForm(new FormMenu());
        }

        private void btnAchats_Click(object sender, EventArgs e)
        {
            ActiverBouton(sender, CouleursRGB.color2);
            OpenChildForm(new FormAchats());
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            ActiverBouton(sender, CouleursRGB.color3);
            OpenChildForm(new FormCompte());
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            ActiverBouton(sender, CouleursRGB.color4);
            OpenChildForm(new FormConnexion());
        }

        private void btnPanier_Click(object sender, EventArgs e)
        {
            ActiverBouton(sender, CouleursRGB.color5);
            OpenChildForm(new FormPanier());
        }

        private void btnChocolat_Click(object sender, EventArgs e)
        {
            ActiverBouton(sender, CouleursRGB.color6);
            OpenChildForm(new FormChocolat());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DesactiverBouton();
            leftBorderBtn.Visible = false;
            currentChildFormIcon.IconChar = IconChar.Home;
            currentChildFormIcon.IconColor = Color.MediumSlateBlue;
            currentBtnLabel.Text = "Home";
        }

        //Evenements drag form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgrandir_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
