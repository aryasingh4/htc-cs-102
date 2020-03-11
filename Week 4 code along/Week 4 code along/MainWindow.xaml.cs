using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Week_4_code_along
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Movie> movieList { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            movieList = new ObservableCollection<Movie>();
            lvMovies.ItemsSource = movieList;
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in movieList)
            {
                movie.ShowDetails();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Movie movie = new Movie(titleInput.Text, Convert.ToInt32(ReleaseYearInput.Text), Convert.ToDouble(RottenTomatoes.Text));

            movieList.Add(movie);
            titleInput.Clear();
            ReleaseYearInput.Clear();
            RottenTomatoes.Clear(); 
            
           
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
            }
        }


    }
}
