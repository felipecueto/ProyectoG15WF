using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;
using CustomEventArgs;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyectog15WF.Contollers
{
    public class VideoController
    {
        List<Video> videos = new List<Video>();
        AppForm view;
        string curDir= Directory.GetCurrentDirectory();
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        DateTime aDate = DateTime.Now;
        public VideoController(Form view)
        {
            ChargeVideos();
            this.view = view as AppForm;
            this.view.Searchingnamevideoorsong += OnSearchTextChanged;
            this.view.Reproducevideo += OnSelectedSongVideoEventArgs;
            this.view.Recivingvideo += OnverifyVideo;
            this.view.Videocaracteristics += OnVideocaracteristics;
            this.view.verifyVideoExist += OnverifyVideoExist;
            this.view.Totalitsofvideos += OnTotalitsofvideos;
            DeserializeData();
        }

        public void SerializeData()
        {
            try
            {
                FileStream FS = new FileStream("Videos.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                binaryFormatter.Serialize(FS, videos);
                FS.Close();
            }

            catch
            {

            }
        }

        public void DeserializeData()
        {

            try
            {
                FileStream FS = new FileStream("Videos.bin", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                videos = (List<Video>)binaryFormatter.Deserialize(FS);
                FS.Close();
               

            }
            catch(Exception e)
            {
               

            }
        }

        public void OnSerialize(object sender, EventArgs e)
        {
            SerializeData();
        }
        public void ChargeVideos() 
        {

            
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
            SerializeData();
        }
        public string OnSelectedSongVideoEventArgs(object sender, SelectVideoEventArgs e)
        {
            string reproduce = "";
            foreach (Video video in videos)
            {
                if (e.Selectedvideo.Contains(video.VideoName))
                {
                    reproduce = video.Path;
                }
            }
            SerializeData();
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
            SerializeData();
            return null;
        }
        public void OnVideocaracteristics(object sender,SendingvideocaracteristicsEventArgs e)
        {
            videos.Add(new Video(e.Videoname, e.Genero, e.Categoria, e.Actor, e.Director, e.Estudio, Convert.ToDateTime(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss")), e.Descripcion, e.duracion, 0, 0, e.Sexo, e.Edad, e.Resolution,e.path,e.byts));
            SerializeData();
        }
        public bool OnverifyVideoExist(object sender, VideosExistEventsArtgs e)
        {
            foreach (Video video in videos)
            {
                if (video.VideoName == e.VideoNameText)
                {
                    return true;
                }
            }
            SerializeData();
            return false;
        }
        public List<string> OnTotalitsofvideos(object sender, SendingVideosEventArgs e)
        {
            List<string> modeartistsongs = new List<string>();
            foreach (Video video in videos)
            {
                if (video.Actor == e.Sendinguser || video.Director==e.Sendinguser)
                {
                    modeartistsongs.Add(video.VideoName);
                }
            }
            SerializeData();
            return modeartistsongs;
        }
    }
}
