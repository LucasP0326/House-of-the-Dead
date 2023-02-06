using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerScript : MonoBehaviour
{
    // Timer Variables
    [SerializeField] private TextMeshProUGUI timerUI; // Attach TMP object to this slot
    [SerializeField] private float mainTimer; // Change this value to your liking in Unity

    private float timer;
    private bool canCount = false;
    private bool doOnce = false;
    private bool hasPressedKey = false;

    // Ticking Audio
    public AudioClip tickingSound;
    static AudioSource audioSrc;

    public GameObject TimerObject; // This is your Timer text in the Canvas

    public Target Player; //Be sure to find this in TimerScript inspector, and click dropdown to select ruby controller.


    // Start is called before the first frame update
    void Start()
    {
        // Timer
        timer = mainTimer;
        TimerObject.SetActive(false);

        DontDestroyOnLoad(gameObject);

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Timer Button Code

            if (hasPressedKey == false)
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    timer = mainTimer;
                    canCount = true;
                    doOnce = false;
                    TimerObject.SetActive(true);

                    hasPressedKey = true;

                    PlaySound(tickingSound);
                }
            }
        

        // Timer functionality
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            timerUI.text = "Time: " + timer.ToString("F");
        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            timerUI.text = "Time: " + timer.ToString("0.00");

            StopSound(tickingSound);


     
        }
    }

    // Audio Stuff
    public void PlaySound(AudioClip clip)
    {
        audioSrc.PlayOneShot(clip);
    }
    public void StopSound(AudioClip clip)
    {
        audioSrc.Stop();
    }

    public void WinTrigger()
    {
        canCount = false;
        doOnce = true;
        timerUI.text = "Time: " + timer.ToString("0.00");
        StopSound(tickingSound);
    }

    public void LoseTrigger()
    {
        canCount = false;
        doOnce = true;
        timerUI.text = "Time: " + timer.ToString("0.00");

        StopSound(tickingSound);
    }
}
