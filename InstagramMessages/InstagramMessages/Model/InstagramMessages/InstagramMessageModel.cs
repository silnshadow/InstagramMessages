using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramMessages.Model.InstagramMessages
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Like
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }

    public class Conversation
    {
        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("likes")]
        public List<Like> Likes { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("media_owner")]
        public string MediaOwner { get; set; }

        [JsonProperty("media_share_caption")]
        public string MediaShareCaption { get; set; }

        [JsonProperty("media_share_url")]
        public string MediaShareUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("profile_share_username")]
        public string ProfileShareUsername { get; set; }

        [JsonProperty("profile_share_name")]
        public string ProfileShareName { get; set; }

        [JsonProperty("story_share")]
        public string StoryShare { get; set; }

        [JsonProperty("story_share_type")]
        public string StoryShareType { get; set; }

        [JsonProperty("mentioned_username")]
        public string MentionedUsername { get; set; }

        [JsonProperty("video_call_action")]
        public string VideoCallAction { get; set; }

        [JsonProperty("heart")]
        public string Heart { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }
    }

    public class DirectMessage
    {
        [JsonProperty("participants")]
        public List<string> Participants { get; set; }

        [JsonProperty("conversation")]
        public List<Conversation> Conversation { get; set; }
    }
}
