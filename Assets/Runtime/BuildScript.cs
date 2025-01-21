using UnityEditor;
using UnityEngine;
using System.IO;

public class BuildScript
{
    public static void PerformBuild()
    {
        string buildPath = "Builds";
        if (!System.IO.Directory.Exists(buildPath))
        {
            System.IO.Directory.CreateDirectory(buildPath);
        }

        string[] scenes = new string[] { "Assets/SampleScene.unity", "Assets/SecondLevel.unity", "Assets/ThirdLevelA.unity", "Assets/ThirdLevelB.unity" };

        BuildPipeline.BuildPlayer(scenes, buildPath + "/Pinball.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
