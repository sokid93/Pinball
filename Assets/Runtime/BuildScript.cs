using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;

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

        BuildReport report = BuildPipeline.BuildPlayer(buildOptions);
        BuildSummary summary = report.summary;

        if(summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeded: " + summary.totalSize + " bytes");
        }

        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build failed");
        }
    }
}
