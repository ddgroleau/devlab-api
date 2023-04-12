using Microsoft.Extensions.Configuration;

namespace Core.Utility;

public static class AppConfig
{
    public static IConfiguration AppSettings { get; private set; }

    public static void AddAppSettings(IConfiguration config) => AppSettings = config;
    
    public static void LoadEnv()
    {
        try
        {
            string solutionName = "devlab-api";
            string currentDir = Environment.CurrentDirectory ?? "";
            string solutionDir = currentDir.Substring(0, currentDir.IndexOf(solutionName) + solutionName.Length);
            string fullPath = Path.Combine(solutionDir, ".env");
        
            if (!File.Exists(fullPath)) return;

            foreach (string line in File.ReadAllLines(fullPath))
            {
                var parts = line.Split('=',StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2) continue;

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
        catch (Exception e)
        {
            return;
        }
    }
}