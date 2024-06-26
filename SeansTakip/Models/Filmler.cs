﻿namespace SeansTakip.Models
{
    public partial class Filmler
    {
        public int id { get; set; }
        public string? movieName { get; set; }
        public TimeSpan timeOne { get; set; }
        public TimeSpan timeTwo { get; set; }
        public TimeSpan timeThree { get; set; }
        public TimeSpan timeFour { get; set; }

        public static bool control()
        {
            if (Program.homePage.movieNameTxt.Text == string.Empty)
                    return false;

            return true;
        }

        public static void clear()
        {
            Program.homePage.movieNameTxt.Text = string.Empty;
            Program.homePage.movieTimeOneDt.Value = DateTime.Parse("00:00:00");
            Program.homePage.movieTimeTwoDt.Value = DateTime.Parse("00:00:00");
            Program.homePage.movieTimeThreeDt.Value = DateTime.Parse("00:00:00");
            Program.homePage.movieTimeFourDt.Value = DateTime.Parse("00:00:00");
        }

        public static void saveDatas(Filmler movie)
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        context.MovieName.Add(movie);
                        context.SaveChanges();
                        MessageBox.Show("Datas Saved", "Data Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listDatas();
                        clear();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void listDatas()
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        List<Filmler> movie = context.MovieName.ToList();
                        Program.homePage.datasMovie.DataSource = movie;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
