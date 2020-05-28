﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Proyectog15WF;
using System.Windows.Forms;
using CustomEventArgs;
using System.IO;


namespace Proyectog15WF.Contollers
{
    public class Songcontroller
    {
        List<Song> songs = new List<Song>();
        AppForm view;
        string curDir = Directory.GetCurrentDirectory();

        public Songcontroller(Form view)
        {
            Chargesong();
            this.view = view as AppForm;
            this.view.Searchingnamevideoorsong += OnSearchTextChanged;
            this.view.Reproducesong += OnSelectedSongVideoEventArgs;
            this.view.Recivingsong += OnverifySong;
            this.view.Songcaracteristics += OnrecivingSongCaracteristics;
        }

        public void Chargesong()
        {

            songs.Add(new Song("UNITED.mp3", "Hip-Hop", "Dadddy Yankee", "El cartel: The big Boss", "Cartel Records", new DateTime(2007, 4, 24), "Tu me dejaste caer pero ella me levanto llamale poca mujer..", 4, "Reggaeton", 0, 0, "Masculino", "30"));

        }
        public void OnSearchTextChanged(object sender, SearchingSongorVideo e)
        {
            List<Song> resultSongs = new List<Song>();
            List<string> resultString = new List<string>();
            resultSongs = songs.Where(t =>
               t.Namesong.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Genre.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Composer.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Discography.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Studio.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Publicationyear.ToShortDateString().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Lyrics.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Duration.ToString().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Category.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Qualification.ToString().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Reproduction.ToString().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Sexo.ToUpper().Contains(e.SearchTextSongVideo.ToUpper())||
               t.Age.ToUpper().Contains(e.SearchTextSongVideo.ToUpper()))
           .ToList();
            if (resultSongs.Count > 0)
            {
                resultString.Add("-----Canciones encontradas-----");
                foreach (Song s in resultSongs)
                    resultString.Add(s.ToString());
            }
            view.UpdateResultsvideoandsong(resultString);
            
        }
        public string OnSelectedSongVideoEventArgs(object sender, SelectSongEventArgs e)
        {
            string reproduce = "";
            foreach (Song song in songs)
            {
                if (e.Selectedsong.Contains(song.Namesong))
                {
                    reproduce = curDir + @"\" + song.Namesong;
                }
            }
            return reproduce;


        }
        public Song OnverifySong(object sender, ReturnsongEventArgs e)
        {   
            foreach(Song cancion  in songs)
            {
                if (e.Verifysonginsongofuser.Contains(cancion.Namesong))
                {
                    return cancion;
                }
            }
            return null;
        }
        public void OnrecivingSongCaracteristics(object sender, SendingsongcaracteristicsEventArgs e)
        {
            songs.Add(new Song(e.Nombrecancion, e.Genero, e.Compositor, e.Discografia, e.Estudio, new DateTime(2007, 4, 24), e.Letra, 0, e.Categoria, 0, 0, e.Sexo, e.Edad));

        }


    }
    





}
