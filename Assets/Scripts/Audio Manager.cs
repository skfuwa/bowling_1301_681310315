using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    public AudioSource[] bgm;


    [SerializeField]
    private AudioMixer mixer;

    public static AudioManager instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    
    void Update()
    {
        
    }
    private void StopAllBGM()
    {
        for (int i = 0; i < bgm.Length; i++)
            bgm[i].Stop();
    }
    public void PlayBGM(int i)
    {
        StopAllBGM();

        if (i < bgm.Length)
            bgm[i].Play();
    }
    public void AdjustMasterVolume(float volume)
    {
        mixer.SetFloat("master", volume);
    }
}
