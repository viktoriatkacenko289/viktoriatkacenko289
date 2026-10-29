using UnityEngine;

public class _0xca78fb95 : MonoBehaviour
{
    public bool IsOnlyWinGameEndEnabled;
    private void _0xc5dddad2()
    {
    }

    public bool IsTimerEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsSkipSplashEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xca78fb95>();
            DontDestroyOnLoad(this.gameObject);
            this._0xf8d4d439();
        }
        else
        {
            this._0xc5dddad2();
            Destroy(this.gameObject);
        }
    }

    private void _0xf8d4d439()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsBestScoreEnabled;
    public static _0xca78fb95 Instance;
    public bool IsTutorialEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsStoryEnabled;
    public bool IsCheckScoreEnabled;
}