using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw4
{
    public partial class FormMovieSearch : Form
    {
        public FormMovieSearch()
        {
            InitializeComponent();

            dataGridPopActor.DataSource = Program.HWclient.getPopularActors();
            dataGridPopDirector.DataSource = Program.HWclient.getPopularDirectors();
            comboBoxSearchBy.SelectedItem = "Search By";
            labelSearchInput.Text = "";
            labelRating.Text = "";
            labelReview.Text = "";
            labelDirector.Text = "";
            dataGridMovieD.Visible = false;
            dataGridMovies.Visible = true;
            dataGridMovies.Location = new Point(288, 115);
            dataGridMovieD.Location = new Point(288, 115);
            dataGridMovies.Height = 231;
            dataGridMovieD.Height = 231;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            Object selectedOp = comboBoxSearchBy.SelectedItem;
            String input = textBoxSearch.Text;
            labelSearchInput.Text = input;
            //searches movies by actor
            if (selectedOp.ToString() == "Actor")
            {
                dataGridMovies.Visible = true;
                dataGridMovieD.Visible = false;
                Hollywood.Actor myActor = Program.HWclient.getActor(input);
                dataGridMovies.DataSource = myActor.movies;
                labelSearchInput.Text = myActor.name;
            }
            //searches movies by director
            if (selectedOp.ToString() == "Director")
            {
                dataGridMovies.Visible = false;
                dataGridMovieD.Visible = true;
                Hollywood.Director myDirector = Program.HWclient.getDirector(input);
                dataGridMovies.DataSource = myDirector.movies;
                labelSearchInput.Text = myDirector.name;
            }
            //searches movies by keyword
            if (selectedOp.ToString() == "Keyword")
            {
                dataGridMovies.Visible = true;
                dataGridMovieD.Visible = false;
                dataGridMovies.DataSource = Program.HWclient.searchMovies(null, null, null, null, null, null, input);
            }
        }
        //gets the movies of the other genres that was selected
        private void listSearchGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            Object selectedOp = listSearchGenre.SelectedItem;
            String genre = selectedOp.ToString();
            dataGridMovies.DataSource = Program.HWclient.searchMovies(genre, null, null, null, null, null, null);
            labelSearchInput.Text = genre;
        }
        //gets the sci-fi movies
        private void picBoxSciFi_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies("Sci-fi", null, null, null, null, null, null);
            labelSearchInput.Text = "Sci-fi";
        }
        //gets the action movies
        private void picBoxAction_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies("Action", null, null, null, null, null, null);
            labelSearchInput.Text = "Action";
        }
        //gets the fantasy movies
        private void picBoxFantasy_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies("Fantasy", null, null, null, null, null, null);
            labelSearchInput.Text = "Fantasy";
        }
        //gets the comedy movies
        private void picBoxComedy_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies("Comedy", null, null, null, null, null, null);
            labelSearchInput.Text = "Comedy";
        }
        //gets the rated r movies
        private void picBoxR_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies(null, null, "R", null, null, null, null);
            labelSearchInput.Text = "Rated R";
        }
        //gets the rated nc movies
        private void picBoxNC_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies(null, null, "NC-17", null, null, null, null);
            labelSearchInput.Text = "Rated NC-17";
        }
        //gets the rated pg-13 moives
        private void picBoxPG13_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies(null, null, "PG-13", null, null, null, null);
            labelSearchInput.Text = "Rated PG-13";
        }
        //gets the rated ur moives
        private void picBoxUR_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies(null, null, "UR", null, null, null, null);
            labelSearchInput.Text = "Rated UR";
        }
        //gets the rated nr movies
        private void picBoxNR_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies(null, null, "NR", null, null, null, null);
            labelSearchInput.Text = "Rated NR";
        }
        //gets the rated pg movies
        private void picBoxPG_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies(null, null, "PG", null, null, null, null);
            labelSearchInput.Text = "Rated PG";
        }
        //gets the rated g movies
        private void picBoxG_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            dataGridMovies.DataSource = Program.HWclient.searchMovies(null, null, "G", null, null, null, null);
            labelSearchInput.Text = "Rated G";
        }
        //gets the selected movies info
        private void dataGridMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = dataGridMovies.CurrentRow.Cells[0].Value.ToString();
            string released = dataGridMovies.CurrentRow.Cells[1].Value.ToString();
            labelTitle.Text = title + " (" + released + ")";
            Hollywood.Movie myMovie = Program.HWclient.getMovie(title, released);
            labelRating.Text = myMovie.rating;
            labelReview.Text = myMovie.review;
            labelDirector.Text = myMovie.director;
            dataGridActor.DataSource = myMovie.actors;
            dataGridGenres.DataSource = myMovie.genres;
        }
        //searches the movies the actor has acted in
        private void dataGridPopActor_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            string actor = dataGridPopActor.CurrentRow.Cells[0].Value.ToString();
            labelSearchInput.Text = actor;
            Hollywood.Actor myActor = Program.HWclient.getActor(actor);
            dataGridMovies.DataSource = myActor.movies;
        }
        //searches the movie the selected Director has directed
        private void dataGridPopDirector_Click(object sender, EventArgs e)
        {
            dataGridMovies.Visible = false;
            dataGridMovieD.Visible = true;
            string director = dataGridPopDirector.CurrentRow.Cells[0].Value.ToString();
            labelSearchInput.Text = director;
            Hollywood.Director myDirector = Program.HWclient.getDirector(director);
            dataGridMovieD.DataSource = myDirector.movies;
        }
        //gets all the movies the actor selected was in 
        private void dataGridActor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            string actor = dataGridActor.CurrentRow.Cells[0].Value.ToString();
            labelSearchInput.Text = actor;
            Hollywood.Actor myActor = Program.HWclient.getActor(actor);
            dataGridMovies.DataSource = myActor.movies;
        }
        //gets the info about the selected movie
        private void dataGridMovieD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = dataGridMovieD.CurrentRow.Cells[0].Value.ToString();
            string released = dataGridMovieD.CurrentRow.Cells[1].Value.ToString();
            labelTitle.Text = title + " (" + released + ")";
            Hollywood.Movie myMovie = Program.HWclient.getMovie(title, released);
            labelRating.Text = myMovie.rating;
            labelReview.Text = myMovie.review;
            labelDirector.Text = myMovie.director;
            dataGridActor.DataSource = myMovie.actors;
            dataGridGenres.DataSource = myMovie.genres;
        }
        //gets all of the movies that are the genre selected
        private void dataGridGenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridMovies.Visible = true;
            dataGridMovieD.Visible = false;
            string genre = dataGridGenres.CurrentRow.Cells[0].Value.ToString();
            labelSearchInput.Text = genre;
            dataGridMovies.DataSource = Program.HWclient.searchMovies(genre, null, null, null, null, null, null);


        }
    }
}
