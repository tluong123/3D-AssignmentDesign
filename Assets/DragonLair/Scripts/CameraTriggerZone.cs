using UnityEngine;
using Unity.Cinemachine;

public class CinemachineCameraTrigger : MonoBehaviour
{
    public CinemachineCamera cameraToBoost;
    public int boostedPriority = 20;
    public int normalPriority = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger zone.");
            cameraToBoost.Priority = boostedPriority;
            Debug.Log("Boosted Camera Priority: " + cameraToBoost.Priority);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited trigger zone.");
            cameraToBoost.Priority = normalPriority;
            Debug.Log("Reset Camera Priority: " + cameraToBoost.Priority);
        }
    }
}
