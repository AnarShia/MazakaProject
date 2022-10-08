using System.Text.Json.Serialization;

namespace MazakaNet.Models.Resources;

public class UserInfo
{
    [JsonPropertyName("avatarBig")]
    public object AvatarBig { get; set; }

    [JsonPropertyName("avatarMedium")]
    public object AvatarMedium { get; set; }

    [JsonPropertyName("avatarS640")]
    public object AvatarS640 { get; set; }

    [JsonPropertyName("avatarSmall")]
    public object AvatarSmall { get; set; }

    [JsonPropertyName("businessAccountId")]
    public int BusinessAccountId { get; set; }

    [JsonPropertyName("completedCount")]
    public int CompletedCount { get; set; }

    [JsonPropertyName("completedToday")]
    public int CompletedToday { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("imageId")]
    public object ImageId { get; set; }

    [JsonPropertyName("inboxProject")]
    public long InboxProject { get; set; }

    [JsonPropertyName("isBizAdmin")]
    public bool IsBizAdmin { get; set; }

    [JsonPropertyName("isPremium")]
    public bool IsPremium { get; set; }

    [JsonPropertyName("joinDate")]
    public DateTime JoinDate { get; set; }

    [JsonPropertyName("karma")]
    public int Karma { get; set; }

    [JsonPropertyName("karmaTrend")]
    public string KarmaTrend { get; set; }

    [JsonPropertyName("premiumUntil")]
    public object PremiumUntil { get; set; }

    [JsonPropertyName("token")]
    public object Token { get; set; }

    [JsonPropertyName("tzInfo")]
    public TzInfo TzInfo { get; set; }

    [JsonPropertyName("autoReminder")]
    public int AutoReminder { get; set; }

    [JsonPropertyName("dateFormat")]
    public int DateFormat { get; set; }

    [JsonPropertyName("defaultReminder")]
    public DefaultReminder DefaultReminder { get; set; }

    [JsonPropertyName("mobileHost")]
    public object MobileHost { get; set; }

    [JsonPropertyName("mobileNumber")]
    public object MobileNumber { get; set; }

    [JsonPropertyName("nextWeek")]
    public int NextWeek { get; set; }

    [JsonPropertyName("sortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("startDay")]
    public int StartDay { get; set; }

    [JsonPropertyName("startPage")]
    public string StartPage { get; set; }

    [JsonPropertyName("theme")]
    public int Theme { get; set; }

    [JsonPropertyName("timeFormat")]
    public int TimeFormat { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("fullName")]
    public string FullName { get; set; }

    [JsonPropertyName("language")]
    public Language Language { get; set; }

    [JsonPropertyName("password")]
    public object Password { get; set; }

    [JsonPropertyName("timeZone")]
    public object TimeZone { get; set; }
}