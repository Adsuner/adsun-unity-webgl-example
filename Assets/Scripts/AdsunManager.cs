using System.Runtime.InteropServices;
using UnityEngine;

public class AdsunManager : MonoBehaviour
{
    [DllImport("__Internal")] private static extern void AdsunShow(string blockId, bool debug);

    public string blockId = "YOUR_BLOCK_ID";
    public bool debug = true;

    public void Show()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        AdsunShow(blockId, debug);
#else
        OnAdsunReward(blockId);
#endif
    }

    public void OnAdsunReward(string id) { Debug.Log("Reward for " + id); }
    public void OnAdsunError(string reason) { Debug.Log("No reward: " + reason); }
}
