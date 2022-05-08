using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;
using Windows.Media.Core;

namespace P3JoseMiguelVillacanas
{
    class Atributos
    {
        MediaPlayer mP = new MediaPlayer();
        int diamantes=0;
        double volumen = 100;
        int nivelActual;
        bool [] niveles = { true, false, false, false };  

        public async void initMusica()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("HimnoDelMadrid.mp3");

            mP.AutoPlay = false;
            mP.Source = MediaSource.CreateFromStorageFile(file);
            mP.Play();
        }

        public void setDiamantes(int d)
        {
            diamantes += d;
        }
        public int getDiamantes()
        {
            return diamantes;
        }

        public void setNivel(int index)
        {
            niveles[index] = true;
        }
        public bool getNivel(int index)
        {
            return niveles[index];
        }

        public void setNivelActual(int i)
        {
            nivelActual = i;
        }
        public int getNivelActual()
        {
            return nivelActual;
        }

        public void changeVolume(double v)
        {
            mP.Volume = v;
        }

    }
}
