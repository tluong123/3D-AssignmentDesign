using UnityEngine;

public class PlayAnimationOnKey : MonoBehaviour
{
    public Animator animator; // Drag your Animator here in the Inspector

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            animator.SetTrigger("PlayAnim"); // Make sure "PlayAnim" is a Trigger in your Animator
        }
    }
}
