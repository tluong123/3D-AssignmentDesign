using UnityEngine;

public class EnableDollyCameraTrigger : MonoBehaviour
{
    public GameObject dollyCamera;  // Assign the DollyCamera GameObject in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dollyCamera.SetActive(true);
            Debug.Log("DollyCamera enabled");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dollyCamera.SetActive(false);
            Debug.Log("DollyCamera disabled");
        }
    }
}
