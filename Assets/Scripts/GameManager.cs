using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;
    public static GameManager instance;
    public GameObject readyText;
    public GameObject setText;
    public GameObject goText;
    public AudioSource readySetSFX;
    public AudioSource goSFX;
    public Animator player;
    public float audioDelay;
    public float levelDuration;
    public GameObject endScreen;
    public int currentCombo;
    public int maxCombo;
    public int hitTotal;
    public int missedTotal;
    public GameObject comboText;
    public TMP_Text comboTMP;
    public TMP_Text hitTMP;
    public TMP_Text missedTMP;
    public TMP_Text maxTMP;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        StartCoroutine(readySetGoTimer(1));
    }

    // Update is called once per frame
    void Update()
    {
        //if(startPlaying)
        //{
        //    theBS.hasStarted = true;
        //}
    }

    private IEnumerator readySetGoTimer(float wait)
    {
        yield return new WaitForSeconds(wait);
        print("Ready");
        readyText.SetActive(true);
        readySetSFX.Play();

        yield return new WaitForSeconds(wait);
        print("Set");
        setText.SetActive(true);
        readySetSFX.Play();

        yield return new WaitForSeconds(wait);
        print("GO!");
        goText.SetActive(true);
        goSFX.Play();

        yield return new WaitForSeconds(wait);
        readyText.SetActive(false);
        setText.SetActive(false);
        goText.SetActive(false);

        player.SetBool("IsRunning", true);
        //startPlaying = true;
        theBS.hasStarted = true;
        comboText.SetActive(true);
        yield return new WaitForSeconds(audioDelay);
        theMusic.Play();
        Invoke("LevelClear", levelDuration);
    }

    public void NoteHit()
    {
        Debug.Log("Hit On Time");

        currentCombo++;
        comboTMP.SetText("COMBO: " + currentCombo);
        hitTotal++;
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");

        if (currentCombo > maxCombo)
        {
            maxCombo = currentCombo;
        }

        currentCombo = 0;
        comboTMP.SetText("COMBO: " + currentCombo);
        missedTotal++;
    }

    public void LevelClear()
    {
        theBS.hasStarted = false;
        if (currentCombo > maxCombo)
        {
            maxCombo = currentCombo;
        }
        maxTMP.SetText("MAX COMBO: " + maxCombo);
        hitTMP.SetText("HIT SLIMES: " + hitTotal);
        missedTMP.SetText("MISSED SLIMES: " + missedTotal);
        endScreen.SetActive(true);
    }
}
