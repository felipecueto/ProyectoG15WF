using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Proyectog15WF;
using System.Windows.Forms;
using CustomEventArgs;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyectog15WF.Contollers
{
    public class ArtistController
    {
        List<Artist> artists = new List<Artist>();
        AppForm view;
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        public ArtistController(Form view)
        {
            this.view = view as AppForm;
            DeserializeData();
        }
        public void SerializeData()
        {
            try
            {
                FileStream FS = new FileStream("Artist.Bin", FileMode.Create, FileAccess.Write, FileShare.None);
                binaryFormatter.Serialize(FS, artists);
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
                FileStream FS = new FileStream("Artist.bin", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                artists = (List<Artist>)binaryFormatter.Deserialize(FS);
                FS.Close();

            }
            catch
            {

            }
        }
        
    }
}
