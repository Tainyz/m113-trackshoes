#if UNITY_EDITOR
using System;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

public class MsvcStdextWorkaround : IPreprocessBuildWithReport
{
    const string kWorkaroundFlag = "il2cpp\\external\\google\\sparsehash\\internal\\sparseconfig.h";

    public int callbackOrder => 0;

    public void OnPreprocessBuild(BuildReport report)
    {
        var clEnv = Environment.GetEnvironmentVariable("_CL_");

        if (string.IsNullOrEmpty(clEnv))
        {
            Environment.SetEnvironmentVariable("_CL_", kWorkaroundFlag);
        }
        else if (!clEnv.Contains(kWorkaroundFlag))
        {
            clEnv += " " + kWorkaroundFlag;
            Environment.SetEnvironmentVariable("_CL_", clEnv);
        }
    }
}

#endif // UNITY_EDITOR
