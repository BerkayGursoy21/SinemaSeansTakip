using SeansTakip.Models;


namespace SeansTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Buttons

        private void saveMovieBtn_Click(object sender, EventArgs e)
        {
            if (Filmler.control())
            {
                Filmler movie = new Filmler()
                {
                    movieName = movieNameTxt.Text,
                    timeOne = movieTimeOneDt.Value.TimeOfDay,
                    timeTwo = movieTimeTwoDt.Value.TimeOfDay,
                    timeThree = movieTimeThreeDt.Value.TimeOfDay,
                    timeFour = movieTimeFourDt.Value.TimeOfDay
                };

                Filmler.saveDatas(movie);
                Seanslar.fillMovie();
            }
            else
            {
                MessageBox.Show("Do Not Leave Blank Fields or Enter Valid Data Format.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveMovieTheaterBtn_Click(object sender, EventArgs e)
        {
            if (SinemaSalon.control())
            {
                SinemaSalon movieTheater = new SinemaSalon()
                {
                    movieTheaterName = movieTheaterNameTxt.Text,
                    movieTheaterCapacity = int.Parse(movieTheaterCapacityTxt.Text)
                };

                SinemaSalon.saveDatas(movieTheater);
                Seanslar.fillMovieTheaters();
            }
            else
            {
                MessageBox.Show("Do Not Leave Blank Fields or Enter Valid Data Format.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveSessionBtn_Click(object sender, EventArgs e)
        {
            if (Seanslar.control())
            {
                Seanslar session = new Seanslar()
                {
                    movieName = sMovieNameCombo.SelectedItem.ToString(),
                    movieTheaterName = sMovieTheaterNameCombo.SelectedItem.ToString(),
                    movieDate = sMovieDateDt.Value.Date,
                    movieTime = TimeSpan.Parse(sMovieTimeCombo.SelectedItem.ToString())
                };

                Seanslar.saveDatas(session);
            }
            else
            {
                MessageBox.Show("Do Not Leave Blank Fields or Enter Valid Data Format.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveCustomerBtn_Click(object sender, EventArgs e)
        {
            if (Customer.control())
            {
                Customer customer = new Customer()
                {
                    sessionID = Convert.ToInt32(datasSessions.SelectedRows[0].Cells[0].Value),
                    customerName = customerNameTxt.Text,
                    customerSurname = customerSurnameTxt.Text,
                    customerIDNumber = customerIDNumberTxt.Text,
                    cardNumber = cardNumberTxt.Text,
                    validityMonth = int.Parse(validityMonthCombo.SelectedItem.ToString()),
                    validityYear = int.Parse(validityYearCombo.SelectedItem.ToString()),
                    securityCode = int.Parse(securityCodeTxt.Text)
                };

                Customer.saveDatas(customer);
            }
            else
            {
                MessageBox.Show("Do Not Leave Blank Fields or Enter Valid Data Format.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Buttons

        #region Form

        private void HomePage_Load(object sender, EventArgs e)
        {
            Seanslar.fillSMovieDateDt();

            Customer.fillValidityMonthCombo();
            Customer.fillValidityYearCombo();

            Filmler.listDatas();
            SinemaSalon.listDatas();
            Seanslar.fillMovie();
            Seanslar.fillMovieTheaters();
            Seanslar.listDatas();
            Customer.listDatas();
        }

        private void HomePage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }

        #endregion Form

        #region DataViews

        private void datasMovie_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Program.existsDB())
            {
                datasMovie.Columns[0].HeaderText = "ID";
                datasMovie.Columns[1].HeaderText = "Movie Name";
                datasMovie.Columns[2].HeaderText = "Movie Time 1";
                datasMovie.Columns[3].HeaderText = "Movie Time 2";
                datasMovie.Columns[4].HeaderText = "Movie Time 3";
                datasMovie.Columns[5].HeaderText = "Movie Time 4";

                datasMovie.Columns[0].Visible = false;
            }
        }

        private void datasMovieTheater_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Program.existsDB())
            {
                datasMovieTheater.Columns[0].HeaderText = "ID";
                datasMovieTheater.Columns[1].HeaderText = "Movie Theater Name";
                datasMovieTheater.Columns[2].HeaderText = "Movie Theater Capasity";

                datasMovieTheater.Columns[0].Visible = false;
            }
        }

        private void datasSession_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Program.existsDB())
            {
                datasSession.Columns[0].HeaderText = "ID";
                datasSession.Columns[1].HeaderText = "Movie Name";
                datasSession.Columns[2].HeaderText = "Movie Theater Name";
                datasSession.Columns[3].HeaderText = "Movie Date";
                datasSession.Columns[4].HeaderText = "Movie Time";

                datasSession.Columns[0].Visible = false;
            }
        }

        private void datasSessions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Program.existsDB())
            {
                datasSessions.Columns[0].HeaderText = "ID";
                datasSessions.Columns[1].HeaderText = "Movie Name";
                datasSessions.Columns[2].HeaderText = "Movie Theater Name";
                datasSessions.Columns[3].HeaderText = "Movie Date";
                datasSessions.Columns[4].HeaderText = "Movie Time";

                datasSessions.Columns[0].Visible = false;
            }
        }

        #endregion DataViews

        private void sMovieNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seanslar.fillMovieTimes();
        }

        private void movieNameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
