using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;
using CustomEventArgs;

namespace Proyectog15WF.Contollers
{
    public class VideoController
    {
        List<Video> videos = new List<Video>();
        AppForm view;
        public VideoController(Form view)
        {
            ChargeVideos();
            this.view = view as AppForm;
        }
        public void ChargeVideos() 
        {

            videos.Add(new Video("Joker", "Drama", "Crimen", "Joaquin Phoenix", "Todd Phillips", "WarnerBros", new DateTime(2019, 5, 12), "Muy buena", 122, 0, 0, "Masculino", "54", 720));

        }
        public void OnSearchTextChanged(object sender, SearchUserEventArgs e)
        {
            List<Video> resultVideos = new List<Video>();
            List<string> resultString = new List<string>();
            resultVideos = videos.Where(t =>
               t.VideoName.ToUpper().Contains(e.SearchText.ToUpper()) ||
               t.Genre.ToUpper().Contains(e.SearchText.ToUpper()) ||
               t.Category.ToUpper().Contains(e.SearchText.ToUpper()) ||
               t.Actor.ToUpper().Contains(e.SearchText.ToUpper()) ||
               t.Director.ToUpper().Contains(e.SearchText.ToUpper()) ||
               t.Studio.Contains(e.SearchText.ToUpper()) ||
               t.UploadDate.ToShortDateString().Contains(e.SearchText.ToUpper()) ||
               t.Description.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Duration.Equals(Convert.ToInt32(e.SearchText)) ||         
               t.Qualification.Equals(Convert.ToInt32(e.SearchText)) ||
               t.Reproduction.Equals(Convert.ToInt32(e.SearchText)) ||
               t.Sexo.ToUpper().Contains(e.SearchText.ToUpper()) ||
               t.Age.ToUpper().Contains(e.SearchText.ToUpper())||
               t.Resolution.Equals(e.SearchText.ToUpper()))       
               .ToList();
            if (resultVideos.Count > 0)
            {
                resultString.Add("-----Videos encontradas-----");
                foreach (Video s in resultVideos)
                    resultString.Add(s.ToString());
            }
            view.UpdateResults(resultString);
        }




    }
}
