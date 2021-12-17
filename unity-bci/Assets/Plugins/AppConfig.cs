/// <summary>
/// Contain configuration of a specific App.
/// </summary>
static class AppConfig
{
    public static string AppUrl = "wss://localhost:6868";
    public static string AppName = "UnityTest";

    /// <summary>
    /// Name of directory where contain tmp data and logs file.
    /// </summary>
    public static string TmpAppDataDir = "UnityTest";
    public static string ClientId = "LeuJtw2FlJdYwEVSbBtsHlgqqQX94G9CCkk9EZze";
    public static string ClientSecret = "A37NSHjLzV0PQ9rOJDj8yeCDHDzBdOB9MPX9XWoAbACDZJeVGDtyW41LxI1qZeQenzXWSFCjpwOwV5Iwfx4vrIh3WqhiR0ligZfA91f4afSOZJb5HWW954fzDJEmu4fB";
    public static string AppVersion = "1.0.0 Dev";

    /// <summary>
    /// License Id is used for App
    /// In most cases, you don't need to specify the license id. Cortex will find the appropriate license based on the client id
    /// </summary>
    public static string AppLicenseId = "";
}