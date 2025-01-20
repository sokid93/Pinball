using UnityEditor;

public class BuildScript
{
    public static void PerformBuild()
    {
        string buildPath = EditorUtility.SaveFolderPanel("Assets/Builds", "","");
        string[] scenes = new string[] { "Assets/SampleScene.unity", "Assets/SecondLevel.unity", "Assets/ThirdLevelA.unity", "Assets/ThirdLevelB.unity" };

        BuildPipeline.BuildPlayer(scenes, buildPath + "/Pinball.exe", BuildTarget.StandaloneWindows, BuildOptions.None);

        FileUtil.CopyFileOrDirectory("Assets/Templates/Readme.txt", buildPath + "Readme.txt");
    }
}
