using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using CustomEventArgs;

namespace Proyectog15WF.Contollers
{
    public class PlaylistController
    {
        List<Playlist> playlist = new List<Playlist>();
        AppForm view;

        public PlaylistController(Form view)
        {
            Initialize();
            this.view = view as AppForm;
            //this.view.OnDownloadButonClicked += OnDownloadButonClicked;
        }

        public void Initialize()
        {

        }

        public void OnCreatePlaylist(object sender, AddPlaylistEventArgs e)
        {
            playlist.Add(new Playlist("Favorites Songs"));
        }
    }
}
