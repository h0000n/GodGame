using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class SoundManager : Singleton<SoundManager>
    {
        public AudioSource BGMPlayer; // ����� ����ϱ� ���� �÷��̾�
        public AudioSource SFXPlayer; // ȿ���� ����ϱ� ���� �÷��̾�

        [SerializeField] public AudioClip[] BGMAudioClip; // ����� ����
        [SerializeField] private AudioClip[] SFXAudioClips; // ȿ���� ����

        public static float VolumeBGM = 1.0f; // ����� ����
        public static float VolumeSFX = 1.0f; // ȿ���� ����

        //Dictionary<key, value>�� ������� �ҷ��´�
        Dictionary<string, AudioClip> BGMaudioclipdic = new Dictionary<string, AudioClip>();
        Dictionary<string, AudioClip> SFXaudioclipdic = new Dictionary<string, AudioClip>();
        private void Awake()
        {
            //base.Awake();
            DontDestroyOnLoad(gameObject);
            //BGMPlayer = GameObject.Find("BGM").GetComponent<AudioSource>(); // BGM�÷��̾�
            //SFXPlayer = GameObject.Find("SFX").GetComponent<AudioSource>(); // ȿ�����÷��̾�

            // AudioClips���� �����Ŭ������ Dictionary���� ����
            foreach (AudioClip audioclip in BGMAudioClip)
            {
                BGMaudioclipdic.Add(audioclip.name, audioclip);
            }
            foreach (AudioClip audioclip in SFXAudioClips)
            {
                SFXaudioclipdic.Add(audioclip.name, audioclip);
            }
            //PlayBGMSound();
        }

        public void PlaySFXSound(string name, float volum = 1.0f)
        {
            if (SFXaudioclipdic.ContainsKey(name) == false) // ȿ������ ���ٸ�
            {
                Debug.Log(name + "�� audioClipsDic�� �����ϴ�.");
                return;
            }

            SFXPlayer.PlayOneShot(SFXaudioclipdic[name], volum * VolumeSFX);

        }

        public void PlayBGMSound(string name)
        {
            BGMPlayer.clip = BGMaudioclipdic[name];
            BGMPlayer.loop = true;
            BGMPlayer.Play();
        }

        private void Update()
        {
            BGMPlayer.volume = VolumeBGM;
            SFXPlayer.volume = VolumeSFX;
            if (Input.GetKeyDown(KeyCode.O))
            {
                Debug.Log(VolumeBGM);
                Debug.Log(VolumeSFX);
            }
        }
    }
}

