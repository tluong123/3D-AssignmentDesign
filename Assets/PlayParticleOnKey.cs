using UnityEngine;

public class PlayParticleOnKey : MonoBehaviour
{
    public ParticleSystem particleEffect; // Assign your particle system in the Inspector
    public KeyCode keyToPress = KeyCode.F;

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (particleEffect != null)
            {
                particleEffect.Play();
            }
            else
            {
                Debug.LogWarning("No ParticleSystem assigned!");
            }
        }
    }
}
