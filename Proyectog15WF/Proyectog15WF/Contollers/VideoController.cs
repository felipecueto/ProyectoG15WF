using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;
using CustomEventArgs;
using System.IO;

namespace Proyectog15WF.Contollers
{
    public class VideoController
    {
        List<Video> videos = new List<Video>();
        AppForm view;
        string curDir= Directory.GetCurrentDirectory();

        public VideoController(Form view)
        {
            ChargeVideos();
            this.view = view as AppForm;
            this.view.Searchingnamevideoorsong += OnSearchTextChanged;
            this.view.Reproducevideo += OnSelectedSongVideoEventArgs;
            this.view.Recivingvideo += OnverifyVideo;
            this.view.Videocaracteristics += OnVideocaracteristics;
        }
        public void ChargeVideos() 
        {

            videos.Add(new Video("LS.WEBM", "Drama", "Crimen", "Joaquin Phoenix", "Todd Phillips", "WarnerBros", new DateTime(2019, 5, 12), "Muy buena", 122, 0, 0, "Masculino", "54", "720"));

        }
        public void OnSearchTextChanged(object sender, SearchingSongorVideo e)
        {
            List<Video> resultVideos = new List<Video>();
            List<string> resultString = new List<string>();
            resultVideos = videos.Where(t =>
               t.VideoName.ToUpper().Contains(e.SearchTextSongVideo.ToUpper()) ||
               t.Genre.ToUpper().Contains(e.SearchTextSongVideo.ToUpper()) ||
               t.Category.ToUpper().Contains(e.SearchTextSongVideo.ToUpper()) ||
               t.Actor.ToUpper().Contains(e.SearchTextSongVideo.ToUpper()) ||
               t.Director.ToUpper().Contains(e.SearchTextSongVideo.ToUpper()) ||
               t.Studio.Contains(e.SearchTextSongVideo.ToUpper()) ||
               t.UploadDate.ToShortDateString().Contains(e.SearchTextSongVideo) ||
               t.Description.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Duration.ToString().Contains(e.SearchTextSongVideo.ToUpper()) ||         
               t.Qualification.ToString().Contains(e.SearchTextSongVideo.ToUpper()) ||
               t.Reproduction.ToString().Contains((e.SearchTextSongVideo.ToUpper())) ||
               t.Sexo.ToUpper().Contains(e.SearchTextSongVideo.ToUpper()) ||
               t.Age.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Resolution.ToString().Contains(e.SearchTextSongVideo.ToUpper()))       
               .ToList();
            if (resultVideos.Count > 0)
            {
                resultString.Add("-----Videos encontrados-----");
                foreach (Video s in resultVideos)
                    resultString.Add(s.ToString());
            }
            view.UpdateResultsvideoandsong(resultString);
        }
        public string OnSelectedSongVideoEventArgs(object sender, SelectVideoEventArgs e)
        {
            string reproduce = "";
            foreach (Video video in videos)
            {
                if (e.Selectedvideo.Contains(video.VideoName))
                {
                    reproduce = curDir + @"\" + video.VideoName;
                }
            }
            return reproduce;


        }
        public Video OnverifyVideo(object sender, ReturnVideoEventArgs e)
        {
            foreach (Video video in videos)
            {
                if (e.Verifyvideoinvideoofuser.Contains(video.VideoName))
                {
                    return video;
                }
            }
            return null;
        }
        public void OnVideocaracteristics(object sender,SendingvideocaracteristicsEventArgs e)
        {
            videos.Add(new Video(e.Videoname, e.Genero, e.Categoria, e.Actor, e.Director, e.Estudio, new DateTime(2019, 5, 12), e.Descripcion, 0, 0, 0, e.Sexo, e.Edad, e.Resolution));
        }


    }
}
