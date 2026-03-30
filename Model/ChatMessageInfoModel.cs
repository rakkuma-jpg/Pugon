using System;
using System.Collections.Generic;
using System.Text;

namespace Pugon.Model
{
    public class ChatMessageInfoModel
    {
        private string? imagePath;
        private string? userAvatar;
        public bool IsReceived { get; set; }
        public string? Message { get; set; }
        public string? Time { get; set; }
        public string UserAvatar
        {
            get { return App.ImageServerPath + userAvatar; }
            set { this.userAvatar = value; }
        }

        public string ImagePath
        {
            get {return App.ImageServerPath + imagePath; }
            set { this.imagePath = value; }
        }
    }
}
