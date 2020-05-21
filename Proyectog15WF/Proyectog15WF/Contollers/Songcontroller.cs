using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Proyectog15WF;
using System.Windows.Forms;
using CustomEventArgs;


namespace Proyectog15WF.Contollers
{
    public class Songcontroller
    {
        List<Song> songs = new List<Song>();
        AppForm view;

        public Songcontroller(Form view)
        {   

            this.view = view as AppForm;
           
        }

        public void Chargesong()
        {

            songs.Add(new Song("Ella me levanto", "Hip-Hop", "Dadddy Yankee", "El cartel: The big Boss", "Cartel Records", new DateTime(2007, 4, 24), "Tu me dejaste caer pero ella me levanto llamale poca mujer..", 4, "Reggaeton", 0, 0, "Masculino", "30"));

        }
        public void OnSearchTextChanged(object sender, SearchUserEventArgs e)
        {
            List<Song> resultSongs = new List<Song>();
            List<string> resultString = new List<string>();
            resultSongs = songs.Where(t =>
               t.Namesong.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Genre.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Composer.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Discography.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Studio.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Publicationyear.ToShortDateString().Contains(e.SearchText.ToUpper())||
               t.Lyrics.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Duration.Equals(Convert.ToInt32(e.SearchText))||
               t.Category.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Qualification.Equals(Convert.ToInt32(e.SearchText))||
               t.Reproduction.Equals(Convert.ToInt32(e.SearchText))||
               t.Sexo.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Age.ToUpper().Contains(e.SearchText.ToUpper()))
           .ToList();
            if (resultSongs.Count > 0)
            {
                resultString.Add("-----Canciones encontradas-----");
                foreach (Song s in resultSongs)
                    resultString.Add(s.ToString());
            }
            view.UpdateResults(resultString);
        }



    }
    





}
