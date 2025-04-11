using UnityEngine;

public class PlayerSpawnMover : MonoBehaviour
{
    void Start()
    {
        Transform spawn = GameObject.Find("PlayerSpawn")?.transform;
        GameObject xrRig = GameObject.Find("XR Origin (XR Rig)");

        if (spawn != null && xrRig != null)
        {
            xrRig.transform.position = spawn.position;
            xrRig.transform.rotation = spawn.rotation;
            Debug.Log("[PlayerSpawnMover] XR Rig moved to PlayerSpawn.");
        }
        else
        {
            Debug.LogWarning("[PlayerSpawnMover] Could not find PlayerSpawn or XR Rig.");
        }
    }
}
