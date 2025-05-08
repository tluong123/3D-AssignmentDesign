using UnityEngine;
using Unity.Cinemachine;
using System.Collections;

public class FOVReducer : MonoBehaviour
{
    public CinemachineCamera virtualCamera;
    public float targetFOV = 10f;
    public float decreaseSpeed = 6f;
    public GameObject objectToToggle;

    void Start()
    {
        StartCoroutine(ToggleObjectAfterDelay());
    }

    void Update()
    {
        if (virtualCamera != null)
        {
            var lens = virtualCamera.Lens;
            if (lens.FieldOfView > targetFOV)
            {
                lens.FieldOfView = Mathf.MoveTowards(lens.FieldOfView, targetFOV, decreaseSpeed * Time.deltaTime);
                virtualCamera.Lens = lens;
            }
        }
    }

    IEnumerator ToggleObjectAfterDelay()
    {
        yield return new WaitForSeconds(5f); // Wait 5 seconds from scene start
        if (objectToToggle != null)
            objectToToggle.SetActive(false);

        yield return new WaitForSeconds(10f); // Wait another 5 seconds
        if (objectToToggle != null)
            objectToToggle.SetActive(true);
    }
}
