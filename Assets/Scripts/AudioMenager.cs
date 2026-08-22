using UnityEngine;
using UnityEngine.Audio;

public class AudioMenager : MonoBehaviour
{
    [SerializeField]
    private AudioSource[] bgm;
    public AudioSource[] BGM {  get { return bgm; } }

    [SerializeField]
    private AudioSource[] sfx;
    public AudioSource[] SFX { get { return sfx; } }

    [SerializeField]
    private AudioMixer audioMixer;

    public AudioMenager instance;

    void Awake()
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
        {
            bgm[i].Stop();
        }
    }

    public void PlayBGM(int i)
    {
        StopAllBGM();

        if (i <  bgm.Length)
        {
            bgm[i].Play();
        }
    }

    public void PlaySFX(int i)
    {
        if (i < sfx.Length)
        {
            sfx[i].PlayOneShot(sfx[i].clip);
        }
    }

    public void LoadCurrentMasterVolume()
    {
        return PlayerPrefs.GetFloat("master", 0f);
    }

    public void AdjustMasterVolume(float volume)
    {
        audioMixer.SetFloat("master", volume);
        PlayerPrefs.SetFloat("master", volume);
        PlayerPrefs.Save();
    }
}
