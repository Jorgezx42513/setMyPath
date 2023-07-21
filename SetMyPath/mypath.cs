using System.IO;

namespace SetMyPath
{
    public class mypath
    {
        private static string _path;
        public static string path
        {
            get { return _path;}
            set {_path = value; }
        }
        // Get current directory 
        public static string get_act_path()
        {
            path = null;
            return path = Directory.GetCurrentDirectory();
        }
        // Get current directory and enter in a folder
        public static string get_act_path(in string folder_name)
        {
            path = null;
            return path = $@"{Directory.GetCurrentDirectory()}\{folder_name}\";
        }
        /// <summary>
        /// Get name of your app and return the deploy app path
        /// </summary>
        /// <param name="nameApp">Name of app deployed</param>
        /// <returns>Set the production deploy app path</returns>
        public static string get_production_path(in string nameApp)
        {
            path = null;
            string[] splitPath = Directory.GetCurrentDirectory().Split(@"\");
            foreach (var item in splitPath)
            {
                path += $@"{item}\";
                if (item == nameApp)
                {
                    path += nameApp;
                    break;
                }
            }
            return path;
        }
        /// <summary>
        /// Set de raiz repository of its computer
        /// </summary>
        public static string get_disk_rep()
        {
            path = null;
            string[] splitPath = Directory.GetCurrentDirectory().Split(@"\");
            return path = splitPath[0];
        }
        /// <summary>
        /// Set the default repository of its computer
        /// </summary>
        public static string get_def_rep()
        {
            path = null;
            string[] splitPath = Directory.GetCurrentDirectory().Split(@"\");
            return path = $@"{splitPath[0]}\{splitPath[1]}\{splitPath[2]}";
        }
    }
}
