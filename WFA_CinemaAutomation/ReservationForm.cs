using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_CinemaAutomation.Entities;
using WFA_CinemaAutomation.Enum;

namespace WFA_CinemaAutomation
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }
        public ReservationForm(PictureBox pictureBox1)
        {
            InitializeComponent();
            this.pictureBox1=pictureBox1;
        }
        PictureBox pictureBox1;
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            rdbFemale.Checked = true;
            btnCancel.Enabled = false;
            if (this.pictureBox1!=null&&this.pictureBox1.Tag!=null) 
            {
                Ticket receivedTicket=this.pictureBox1.Tag as Ticket;
                txtSurnameName.Text=receivedTicket.SurnameName;
                txtSocialSecurityNo.Text=receivedTicket.SocialSecurityNo;
                if (receivedTicket.Gender==Gender.Female.ToString())
                {
                    rdbFemale.Checked=true;
                }
                else 
                {
                    rdbMale.Checked=true;
                }
                btnCancel.Enabled = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1 != null)
            {
                this.pictureBox1.BackgroundImage=Resource1.imageskirmizi;
            }
            Ticket ticket = new Ticket();
            if (pictureBox1.Tag!=null)
            {
                ticket=pictureBox1.Tag as Ticket;
            }
            else
            {
                ticket=new Ticket();
            }
            ticket.SurnameName=txtSurnameName.Text;
            ticket.SocialSecurityNo=txtSocialSecurityNo.Text;
            ticket.Gender=rdbFemale.Checked ? Gender.Female.ToString() : Gender.Male.ToString();
            ticket.TicketNumber=Form1.counter;
            this.pictureBox1.Tag = ticket;
            Ticket.TicketList.Add(ticket);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(this.pictureBox1 != null) 
            {
                DialogResult answer = MessageBox.Show("Are you sure want to cancel this ticket ?","Warning Ticket Cancel",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) 
                {
                    this.pictureBox1.Tag=null;
                    pictureBox1.BackgroundImage = Resource1.imagesmavi;
                    GC.Collect();
                    ClearForm();
                    this.Close();
                }
            }
        }

        void ClearForm()
        {
            rdbFemale.Checked = true;
            txtSocialSecurityNo.Text = string.Empty;
            txtSurnameName.Text = string.Empty;
        }
    }
}
