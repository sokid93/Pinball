using UnityEditor;
using UnityEngine;

public class BuildScript
{
    [MenuItem("Build/Build WebGL")]
    public static void PerformBuild()
    {
        BuildPlayerOptions buildOptions = new BuildPlayerOptions();
        buildOptions.scenes = new string[] { "Assets/SampleScene.unity", "Assets/SecondLevel.unity", "Assets/ThirdLevelA.unity", "Assets/ThirdLevelB.unity" };
        buildOptions.locationPathName = "Builds/WebGL";
        buildOptions.target = BuildTarget.WebGL;
        buildOptions.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(buildOptions);
    }
}
