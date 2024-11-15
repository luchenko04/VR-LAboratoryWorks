using UnityEngine;

public class SpeakerToggle : MonoBehaviour
{
    public AudioSource speakerAudio;

    private bool isPlaying = false;

    private void OnMouseDown()
    {
        if (speakerAudio == null)
        {
            Debug.LogWarning("file not found");
            return;
        }

        if (isPlaying)
        {
            speakerAudio.Stop();
            isPlaying = false;
        }
        else
        {
            speakerAudio.Play();
            isPlaying = true;
        }
    }
}

