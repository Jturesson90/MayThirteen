using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.GameCenter;
using GooglePlayGames;
using UnityEngine.SceneManagement;

public class LittleRockstarGoogleGame : MonoBehaviour
{



    /*
	 	*Leaderboard
	 	*/



    public string LEVEL_1
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_1;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_1;
#endif
        }
    }
    public string LEVEL_2
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_2;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_2;
#endif
        }
    }
    public string LEVEL_3
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_3;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_3;
#endif
        }
    }
    public string LEVEL_4
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_4;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_4;
#endif
        }
    }
    public string LEVEL_5
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_5;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_5;
#endif
        }
    }
    public string LEVEL_6
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_6;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_6;
#endif
        }
    }
    public string LEVEL_7
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_7;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_7;
#endif
        }
    }
    public string LEVEL_8
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_8;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_8;
#endif
        }
    }
    public string LEVEL_9
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_9;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_9;
#endif
        }
    }
    public string LEVEL_10
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_10;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_10;
#endif
        }
    }
    public string LEVEL_11
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_11;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_11;
#endif
        }
    }
    public string LEVEL_12
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_12;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_12;
#endif
        }
    }
    public string LEVEL_13
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_13;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_13;
#endif
        }
    }
    public string LEVEL_14
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_14;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_14;
#endif
        }
    }
    public string LEVEL_15
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_15;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_15;
#endif
        }
    }
    public string LEVEL_16
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_16;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_16;
#endif
        }
    }
    public string LEVEL_17
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_17;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_17;
#endif
        }
    }
    public string LEVEL_18
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_18;

#else
            return LittleRockstarGPGSConstants.leaderboard_level_18;
#endif
        }
    }
    public string LEVEL_19
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_19;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_19;
#endif
        }
    }
    public string LEVEL_20
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.leaderboard_20;

#else
             return LittleRockstarGPGSConstants.leaderboard_level_20;
#endif
        }
    }

    public string CLEARED_5
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.completed_5;


#else
            return LittleRockstarGPGSConstants.achievement_cleared_5;
#endif
        }
    }
    public string CLEARED_10
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.completed_10;


#else
            return LittleRockstarGPGSConstants.achievement_cleared_10;
#endif
        }
    }
    public string CLEARED_15
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.completed_15;


#else
            return LittleRockstarGPGSConstants.achievement_cleared_15;
#endif
        }
    }
    public string CLEARED_20
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.completed_20;


#else
            return LittleRockstarGPGSConstants.achievement_cleared_20;
#endif
        }
    }

    public string STAR_5
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.superstars_5;

#else
            return LittleRockstarGPGSConstants.achievement_5__superstars;
#endif
        }
    }
    public string STAR_10
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.superstars_10;


#else
           return LittleRockstarGPGSConstants.achievement_10_superstars;
#endif
        }
    }
    public string STAR_15
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.superstars_15;
#else
            return LittleRockstarGPGSConstants.achievement_15_superstars;
#endif
        }
    }
    public string STAR_20
    {
        get
        {
#if UNITY_IOS
            return LittleRockstarGameCenterConstants.superstars_20;


#else
        return LittleRockstarGPGSConstants.achievement_20_superstars;
#endif
        }
    }

    public void UpdateAchievemnts(int stars, int levels)
    {

        HandleStarUpdateAchievemnts(stars);
        HandleClearedAchievemnts(levels);
    }
    private void HandleStarUpdateAchievemnts(int stars)
    {
        if (stars >= 20)
        {
            AchievmentUnlocked(STAR_20);
        }
        if (stars >= 15)
        {
            AchievmentUnlocked(STAR_15);
        }
        if (stars >= 10)
        {
            AchievmentUnlocked(STAR_10);
        }
        if (stars >= 5)
        {
            AchievmentUnlocked(STAR_5);
        }

    }

    private void HandleClearedAchievemnts(int levels)
    {
        if (levels >= 20)
        {
            AchievmentUnlocked(CLEARED_20);
        }
        if (levels >= 15)
        {
            AchievmentUnlocked(CLEARED_15);
        }
        if (levels >= 10)
        {
            AchievmentUnlocked(CLEARED_10);
        }
        if (levels >= 5)
        {
            AchievmentUnlocked(CLEARED_5);
        }

    }
    private void AchievmentUnlocked(string name)
    {
        if (LoggedIn())
            Social.ReportProgress(name, 100.0f, (bool success) =>
            {
                // handle success or failure
            });
    }
    bool LoggedIn()
    {
        return Social.localUser.authenticated;
    }
    void Start()
    {

#if UNITY_IOS
        GameCenterPlatform.ShowDefaultAchievementCompletionBanner(true);
#else
         GooglePlayGames.PlayGamesPlatform.Activate();
#endif


        LogInGooglePlus();
    }


    public void ToggleLogin()
    {
        if (!Social.localUser.authenticated)
        {
            LogInGooglePlus();
        }
        else
        {
            LogOutGooglePlus();
        }
    }
    public void LogInGooglePlus()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                //	mStatusText = "Welcome " + Social.localUser.userName;

            }
            else
            {
                //	mStatusText = "Authentication failed.";

            }
        });

    }
    public void LogOutGooglePlus()
    {
#if UNITY_ANDROID
        ((GooglePlayGames.PlayGamesPlatform)Social.Active).SignOut();
#endif
    }

    public void ShowAchievements()
    {
        if (LoggedIn())
        {
            Social.ShowAchievementsUI();
        }
        else
        {
            LogInGooglePlus();
        }
    }

    public void ShowLeaderboard()
    {

        if (!LoggedIn())
        {
            LogInGooglePlus();
            return;
        }
        CheckForLostHighscores();

        if (SceneManager.GetActiveScene().name == "Menu")
        {
            Social.ShowLeaderboardUI();
        }
        else if (SceneManager.GetActiveScene().name != "Splash" && SceneManager.GetActiveScene().name != "LevelSelectionLobby")
        {
            ShowLeaderboardAtLevel(SceneManager.GetActiveScene().name);
        }

    }


    private void ShowLeaderboardAtLevel(string level)
    {
        string leaderboard = "";
        switch (level)
        {

            case "Level1":
                leaderboard = LEVEL_1;
                break;
            case "Level2":
                leaderboard = LEVEL_2;
                break;
            case "Level3":
                leaderboard = LEVEL_3;
                break;
            case "Level4":
                leaderboard = LEVEL_4;
                break;
            case "Level5":
                leaderboard = LEVEL_5;
                break;
            case "Level6":
                leaderboard = LEVEL_6;
                break;
            case "Level7":
                leaderboard = LEVEL_7;
                break;
            case "Level8":
                leaderboard = LEVEL_8;
                break;
            case "Level9":
                leaderboard = LEVEL_9;
                break;
            case "Level10":
                leaderboard = LEVEL_10;
                break;
            case "Level11":
                leaderboard = LEVEL_11;
                break;
            case "Level12":
                leaderboard = LEVEL_12;
                break;
            case "Level13":
                leaderboard = LEVEL_13;
                break;
            case "Level14":
                leaderboard = LEVEL_14;
                break;
            case "Level15":
                leaderboard = LEVEL_15;
                break;
            case "Level16":
                leaderboard = LEVEL_16;
                break;
            case "Level17":
                leaderboard = LEVEL_17;
                break;
            case "Level18":
                leaderboard = LEVEL_18;
                break;
            case "Level19":
                leaderboard = LEVEL_19;
                break;
            case "Level20":
                leaderboard = LEVEL_20;
                break;
            default:
                leaderboard = LEVEL_1;
                break;
        }
#if UNITY_IOS
        GameCenterPlatform.ShowLeaderboardUI(leaderboard, TimeScope.AllTime);
#else
          PlayGamesPlatform.Instance.ShowLeaderboardUI(leaderboard);
#endif


    }
    public void PostScoreToLeaderboard(int level, long time)
    {
        string id = GetIDTag(level);
#if UNITY_IOS
        time /= 10;
#endif
        if (!id.Equals(" "))
        {

            Social.ReportScore(time, id, (bool success) =>
            {
                // handle success or failure

                if (!success)
                {
                    var notUploadedHighscores = new NotUploadedHighscores();
                    notUploadedHighscores.SaveHighScoreAtLevel(level, time);
                }
                else
                {

                }
            });
        }

    }
    private void PostScoreToLeaderboardFromLostHighscore(int level, long time)
    {
        string id = GetIDTag(level);
        if (id.Equals(" "))
            return;
#if UNITY_IOS
        time /= 10;
#endif

        Social.ReportScore(time, id, (bool success) =>
        {
            if (success)
            {
                var notUploadedHighscores = new NotUploadedHighscores();
                notUploadedHighscores.ResetScoreAt(level);
            }
        });

    }
    private void CheckForLostHighscores()
    {
        var notUploadedHighscores = new NotUploadedHighscores();
        long[] lostHighscores = notUploadedHighscores.GetLostHighscores();
        for (int i = 0; i < lostHighscores.Length; i++)
        {
            if (lostHighscores[i] < long.MaxValue)
            {
                PostScoreToLeaderboardFromLostHighscore(i + 1, lostHighscores[i]);
            }
        }
    }
    private string GetIDTag(int level)
    {
        string id = " ";
        switch (level)
        {
            case 1:
                id = LEVEL_1;
                break;
            case 2:
                id = LEVEL_2;
                break;
            case 3:
                id = LEVEL_3;
                break;
            case 4:
                id = LEVEL_4;
                break;
            case 5:
                id = LEVEL_5;
                break;
            case 6:
                id = LEVEL_6;
                break;
            case 7:
                id = LEVEL_7;
                break;
            case 8:
                id = LEVEL_8;
                break;
            case 9:
                id = LEVEL_9;
                break;
            case 10:
                id = LEVEL_10;
                break;
            case 11:
                id = LEVEL_11;
                break;
            case 12:
                id = LEVEL_12;
                break;
            case 13:
                id = LEVEL_13;
                break;
            case 14:
                id = LEVEL_14;
                break;
            case 15:
                id = LEVEL_15;
                break;
            case 16:
                id = LEVEL_16;
                break;
            case 17:
                id = LEVEL_17;
                break;
            case 18:
                id = LEVEL_18;
                break;
            case 19:
                id = LEVEL_19;
                break;
            case 20:
                id = LEVEL_20;
                break;
            default:
                id = " ";
                break;

        }
        return id;
    }

}
