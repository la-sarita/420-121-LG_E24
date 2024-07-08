using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fichiers
{
    internal class Program
    {
        const string racine = "C:\\Users\\boumsar0\\OneDrive - Cégep Marie-Victorin\\Documents\\AEC\\Admin_reseau_secur_info\\Ete_2024\\Complement_programmation\\";
        static void Main(string[] args)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in driveInfos)
            {
                Console.WriteLine(driveInfo.Name);
            }

            DriveInfo lecteurC = new DriveInfo("C");
            Console.WriteLine($"{lecteurC.Name} : {lecteurC.AvailableFreeSpace} : {lecteurC.TotalFreeSpace}" +
                $" / {lecteurC.TotalSize} {lecteurC.DriveFormat} {lecteurC.DriveType} {lecteurC.IsReady} " +
                $"{lecteurC.RootDirectory.FullName} {lecteurC.VolumeLabel}");
            // ExempleDirectoryInfo();
            ExempleDirectory();
            ExempleFile();
            ExempleFileInfo();
        }

        public static void ExempleDirectoryInfo()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\banal1");
            directoryInfo.Create();
            DirectoryInfo[] directories = directoryInfo.GetDirectories("C:\\Users\\boumsar0\\OneDrive - Cégep Marie-Victorin\\Documents\\AEC\\Admin_reseau_secur_info\\");

            foreach (var directory in directories)
            {
                Console.WriteLine(directory.Name);
            }

            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();
                Console.WriteLine($"Le repertoire {directoryInfo.Name} a été supprimé!");
            }
            else
            {
                Console.WriteLine("Dossier innexistant!");
            }
        }

        public static void ExempleDirectory()
        {
            Directory.CreateDirectory(@"C:\banal2");
            string[] directories = Directory.GetDirectories("C:\\Users\\boumsar0\\OneDrive - Cégep Marie-Victorin\\Documents\\AEC\\Admin_reseau_secur_info");

            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }

            if(Directory.Exists("C:\\banal"))
            {
                Directory.Delete("C:\\banal");
                Console.WriteLine($"Le repertoire banal a été supprimé!");
            }
            else
            {
                Console.WriteLine("Dossier innexistant!");
            }
        }

        public static void ExempleFile()
        {
            //FileStream fileStream1 = File.Create(racine + "testFile.txt");
            FileStream fileStream2 = File.Open(racine + "testFile.txt", FileMode.Open);
            
            // opératons
            // Fermer le flux pour libérer les ressources
            //fileStream1.Dispose();
            fileStream2.Dispose();

        }

        public static void ExempleFileInfo()
        {
            string chemin = racine + "testFileInfo.txt";
            Console.WriteLine(chemin);
            FileInfo fileInfo = new FileInfo(chemin);
            //FileStream fileStream = fileInfo.Create();
            //FileStream fileStream = fileInfo.Open(FileMode.Open);
            fileInfo.Delete();
            // opératons
            //fileStream.Write("Test");
            // Fermer le flux pour libérer les ressources
            //fileStream.Dispose();
        }
    }
}
