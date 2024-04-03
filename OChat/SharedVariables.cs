using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OChat
{
    internal class SharedVariables
    {
        public static string fileDataUserPath = "./Data/user.txt";
        public static string fileDataMessagePath = "./Data/data.txt";
        public static string folderDataImagesPath = "./Data/images/";
        public static string onlineImagePath = "./Data/images/onl.png";
        public static string offlineImagePath = "./Data/images/off.png";

        public static int userID;
        public static string userAvatarPath;
        public static string userName;
    }
}
