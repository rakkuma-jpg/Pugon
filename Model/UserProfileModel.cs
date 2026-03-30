using System;
using System.Collections.Generic;
using System.Text;

namespace Pugon.Model
{
    public class UserProfileModel
    {
        private string? profileImage;
        public string ProfileImage
        {
            get { return App.ImageServerPath + this.profileImage; }
            set { this.profileImage = value; }
        }
        public string? BotImage { get; set; }
        public string? ProfileName { get; set; }
        public string? Image { get; set; }
        public List<ChatMessageInfoModel>? ChatMessageInfo { get; set; }
    }
}
