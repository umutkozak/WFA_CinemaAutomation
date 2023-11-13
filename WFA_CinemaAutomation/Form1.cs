using WFA_CinemaAutomation.Entities;
using WFA_CinemaAutomation.Enum;

namespace WFA_CinemaAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DesignForm();
        }
        public static int counter = 0;
        public void DesignForm()
        {

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <=12; j++)
                {
                    counter++;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width=50;
                    pictureBox.Height=50;
                    pictureBox.BackgroundImage=Resource1.imagesmavi;
                    pictureBox.BackgroundImageLayout=ImageLayout.Stretch;
                    panel1.Controls.Add(pictureBox);
                    pictureBox.Click+=PictureBox_Click;
                    if (i%2==0)
                    {
                        pictureBox.Location=new Point(150+(pictureBox.Width+5)*j, 10+(pictureBox.Height+5)*i);
                    }
                    else
                    {
                        pictureBox.Location=new Point(260+(pictureBox.Width+5)*j, 10+(pictureBox.Height+5)*i);
                        if (j%8==0)
                        {
                            break;
                        }
                    }

                }
            }
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            var clicked = sender as PictureBox;
            ReservationForm reservationForm = new ReservationForm(clicked);
            reservationForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            int total=0,female=0,male=0;
            foreach (Ticket item in Ticket.TicketList)
            {
                if(item.Gender==Gender.Female.ToString()) 
                {
                    female++;
                }
                else
                {
                    male++;
                }
            }
            total=female+male;
            MessageBox.Show($"Total Audience : {total}\nTotal Female : {female}\nTotal Male : {male}");
        }
    }
}