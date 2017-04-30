using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public GameObject[] spies;
    public GameObject gameOverBar;

    public GameObject fade;
    public Color firstFadeColor;
    public Color lastFadeColor;
    public GameObject missionPopup;

    private float[] distances;
    private bool gameOver;
    private bool readyToQuit;
    private int mission;

    private void Start()
    {
        mission = 0;
        distances = new float[3];
        StartCoroutine(ShowTutorial());
    }


    void Update () {

        distances[0] = Vector2.Distance(spies[0].transform.position, spies[1].transform.position);
        distances[1] = Vector2.Distance(spies[0].transform.position, spies[2].transform.position);
        distances[2] = Vector2.Distance(spies[2].transform.position, spies[1].transform.position);

        if(mission == 0)
        {
            if (distances[0] < 1)
            {
                mission++;
                StartCoroutine(SlowMotionEffect());
                gameOverBar.SetActive(true);
                gameOverBar.GetComponent<AudioSource>().Play();
                gameOverBar.GetComponentInChildren<Text>().text = "CHARLOTTE AND FERDINAND\nSHARED SECRET INFORMATION";
            }
        }
        else if(mission == 1)
        {
            if (distances[1] < 1)
            {
                mission++;
                StartCoroutine(SlowMotionEffect());
                gameOverBar.SetActive(true);
                gameOverBar.GetComponent<AudioSource>().Play();
                gameOverBar.GetComponentInChildren<Text>().text = "ALEJANDRO AND CHARLOTTE\nSHARED SECRET INFORMATION";
            }
        }
        else if (mission == 2)
        {
            if (distances[2] < 1)
            {
                mission++;
                StartCoroutine(SlowMotionEffect());
                gameOverBar.SetActive(true);
                gameOverBar.GetComponent<AudioSource>().Play();
                gameOverBar.GetComponentInChildren<Text>().text = "FERDINAND AND ALEJANDRO\nSHARED SECRET INFORMATION";
            }
        }
        else if (mission == 3)
        {
            if (distances[0] < 1 && distances[1] < 1 && distances[2] < 1 && !gameOver)
            {
                mission++;
                gameOver = true;
                Time.timeScale = .05f;
                gameOverBar.SetActive(true);
                gameOverBar.GetComponent<AudioSource>().Play();
                gameOverBar.GetComponentInChildren<Text>().text = "THE REBELS SHARED ALL\n THE SECRET INFORMATION\n\n(press esc to quit the game)";
            }

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!readyToQuit)
            {
                GetComponent<ConsoleController>().ShowMessage("PRESS ESC AGAIN TO QUIT", false);
                StartCoroutine(QuitTimer());
                readyToQuit = true;
            }
            else
                Application.Quit();
        }

    }

    IEnumerator QuitTimer()
    {
        yield return new WaitForSeconds(4);
        readyToQuit = false;
    }

    IEnumerator ShowTutorial()
    {
        Instantiate(fade, new Vector3(0, 0, -9), Quaternion.identity).GetComponent<FadeBehavior>().ChangeFade(.5f, firstFadeColor, lastFadeColor);
        yield return new WaitForSeconds(5);
        GetComponent<ConsoleController>().ShowMessage("USE 'WASD' OR THE KEYBOARD ARROWS TO NAVIGATE", true);
        yield return new WaitForSeconds(5);
        GetComponent<ConsoleController>().CloseConsole();
        yield return new WaitForSeconds(1);
        GetComponent<ConsoleController>().ShowMessage("YOU CAN ZOOM BY USING THE MOUSE WHEEL", true);
        yield return new WaitForSeconds(5);
        GetComponent<ConsoleController>().CloseConsole();
        yield return new WaitForSeconds(1);
        GetComponent<ConsoleController>().ShowMessage("CLICK A HOUSE TO CHANGE A REBEL'S ROUTINE", true);
        yield return new WaitForSeconds(15);
        missionPopup.SetActive(true);
        yield return new WaitForSeconds(10);
        missionPopup.SetActive(false);
        yield return new WaitForSeconds(5);
        GetComponent<ConsoleController>().CloseConsole();
        yield return new WaitForSeconds(1);
        GetComponent<ConsoleController>().ShowMessage("EVERY REBEL HAS THEIR OWN ROUTINE", true);
    }

    IEnumerator SlowMotionEffect()
    {
        Time.timeScale = .05f;
        yield return new WaitForSeconds(.3f);
        Time.timeScale = 1;
        gameOverBar.SetActive(false);

        if (mission == 1)
            missionPopup.GetComponentInChildren<Text>().text = "MISSION 2/4\n\nMake Alejandro\ncontact Charlotte";
        else if (mission == 2)
            missionPopup.GetComponentInChildren<Text>().text = "MISSION 3/4\n\nMake Ferdinand\ncontact Alejandro";
        else if (mission == 3)
            missionPopup.GetComponentInChildren<Text>().text = "MISSION 4/4\n\nMake all rebels\ncontact each other";

        yield return new WaitForSeconds(2);
        missionPopup.SetActive(true);
        yield return new WaitForSeconds(10);
        missionPopup.SetActive(false);

    }

}