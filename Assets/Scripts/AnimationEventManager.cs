using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationEventManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager gameManager;
    public AudioSource musicSource;
    public AudioSource effectsSource;
    [Header("Ink JSON")][SerializeField] private TextAsset inkJSON;
    void Start()
    {
        gameManager = GameManager.Instance;
    }

    private void PlayMusic(string clipName)
    {
        AudioClip clip = (AudioClip)Resources.Load("Sound/Music/"+clipName);
        musicSource.PlayOneShot(clip);
    }
    
    private void PlaySfx(string clipName)
    {
        AudioClip clip = (AudioClip)Resources.Load("Sound/Sfx/"+clipName);
        musicSource.PlayOneShot(clip);
    }

    private void PlayVoiceActing(string clipName)
    {
        AudioClip clip = (AudioClip)Resources.Load("Sound/Va_s/"+clipName);
        musicSource.PlayOneShot(clip);
    }

    private void SceneChange()
    {
        SceneManager.LoadScene(GameManager.NextSceneName);
    }

    private void TriggerSceneDialogue()
    {
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }

}
