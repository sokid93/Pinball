using UnityEditor;

public class BuildScript
{
    public static void PerformBuild()
    {
        BuildPlayerOptions buildOptions = new BuildPlayerOptions();
        buildOptions.locationPathName = "Builds/Pinball.exe";
        buildOptions.scenes = new string[] { "Assets/SampleScene.unity", "Assets/SecondLevel.unity", "Assets/ThirdLevelA.unity", "Assets/ThirdLevelB.unity" };
        buildOptions.target = BuildTarget.StandaloneWindows;
        buildOptions.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(buildOptions);
    }
}
