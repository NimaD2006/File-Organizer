using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOrganizer.Class
{
    public class Tools
    {
        public static string GetSubfolderName(string extension)
        {
            switch (extension)
            {
                //IMAGE
                case ".png":
                case ".jpg":
                case ".ai":
                case ".bmp":
                case ".jif":
                case ".ico":
                case ".jped":
                case ".webp":
                case ".psd":
                case ".svg":
                case ".tif":
                case ".tiff":
                case ".gif":
                    return "Image";
                //TEXT
                case ".txt":
                    return "Text";
                //VIDEO
                case ".mkv":
                case ".mp4":
                case ".avi":
                    return "Video";
                //AUDIO
                case ".mp3":
                case ".wav":
                case ".aif":
                    return "Audio";
                //DOCUMENT
                case ".pdf":
                case ".doc":
                case ".pptx":
                    return "Document";
                //FONT
                case ".fnt":
                case ".fon":
                case ".otf":
                case ".ttf":
                    return "Font";
                //PROGRAMMING
                case ".cs":
                case ".py":
                case ".java":
                case ".c":
                case ".cpp":
                case ".js":
                case ".json":
                case ".html":
                case ".css":
                case ".swift":
                case ".vb":
                case ".php":
                case ".pl":
                case ".sh":
                    return "Programming";
                //OTHER
                default:
                    return "Other";
            }
        }
    }
}
