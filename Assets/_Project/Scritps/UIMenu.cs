using UnityEngine;

public class UIMenu : MonoBehaviour {

    public AudioClip m_SoundEffect_Over;


    public void OnMouseOver()
    {
        m_audioSource.clip = m_SoundEffect_Over;
        m_audioSource.Play();
    }


    private void Awake()
    {
        m_audioSource = GetComponent<AudioSource>();
    }


    private AudioSource m_audioSource;
}
