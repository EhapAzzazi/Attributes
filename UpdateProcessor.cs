using System;

namespace Assembilies
{
    /// <summary>
    /// Using ObsoleteAttribute in this class
    /// 
    /// </summary>
    class UpdateProcessor
    {
        public static void DownloadAndInstall(Updates[] updates)
        {
            foreach (var update in updates)
            {
                Console.WriteLine($"Downloading {update}.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"Installing {update}.");
                System.Threading.Thread.Sleep(1000);
            }
        }
        [Obsolete("Consider, this method not be available starting from the next release.")]
        public static void Download(Updates[] updates)
        {
            foreach (var update in updates)
            {
                Console.WriteLine($"Downloading {update}.");
                System.Threading.Thread.Sleep(800);
            }
        }
        [Obsolete("Consider, this method not be available starting from the next release.")]
        public static void Install(Updates[] updates)
        {
            foreach (var update in updates)
            {
                Console.WriteLine($"Installing {update}.");
                System.Threading.Thread.Sleep(800);
            }
        }
    }
}
