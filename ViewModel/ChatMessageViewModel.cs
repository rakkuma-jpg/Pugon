using System;
using System.Collections.Generic;
using System.Text;
using Pugon.Model;

namespace Pugon.ViewModel
{
    public partial class ChatMessageViewModel
    {

        public UserProfileModel UserProfile { get; set; }

        public ChatMessageViewModel()
        {
            UserProfile = new UserProfileModel
            {
                BotImage = "loffai.png",
                ProfileName = "TinapAI",
                Image = "lindawalker.jpg"
            };

            UserProfile.ChatMessageInfo = new List<ChatMessageInfoModel>
                {
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.BotImage,
                        IsReceived = true,
                        Message = "Hi, Greetings! How can i help you today?",
                        Time = "5:30 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.Image,
                        Message = "Hello TinapAI! What will you recommend me to bake?",
                        Time = "5:32 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.BotImage,
                        IsReceived = true,
                        Message = "Start your morning with our filipino favorite, the Pandesal",
                        Time = "5:32 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.Image,
                        Message = "Ok thank you very much",
                        Time = "5:33 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.Image,
                        Message = "It is so yummy!",
                        Time = "5:34 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.BotImage,
                        IsReceived = true,
                        Message = "Great!, Enjoy your Pandesal!",
                        Time = "5:34 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.BotImage,
                        IsReceived = true,
                        Message = "Start your morning with our filipino favorite, the Pandesal",
                        Time = "5:35 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.Image,
                        Message = "Ok thank you very much",
                        Time = "5:33 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.Image,
                        Message = "It is so yummy!",
                        Time = "5:34 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.Image,
                        Message = "Hello TinapAI! What will you recommend me to bake?",
                        Time = "5:32 AM"
                    },
                    new ChatMessageInfoModel
                    {
                        UserAvatar = UserProfile.BotImage,
                        IsReceived = true,
                        Message = "Start your morning with our filipino favorite, the Pandesal",
                        Time = "5:32 AM"
                    }
                };
            
        }
    }
}
