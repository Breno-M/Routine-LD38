using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour {

    public GameObject text;
    public GameObject logo;
    public GameObject fade;
    public Color firstFadeColor;
    public Color lastFadeColor;

    private bool started;

    private void Awake()
    {
        Cursor.visible = false;
    }

    void Update () {

        if (Input.anyKey && !started)
        {
            StartCoroutine(Manage());
            started = true;
        }

	}
	
	IEnumerator Manage()
    {
        logo.SetActive(false);
        yield return new WaitForSeconds(.6f);
        GameObject.Find("Music").GetComponent<MusicBehavior>().Play();
        yield return new WaitForSeconds(1.4f);
        Instantiate(fade, new Vector3(0, 0, -9), Quaternion.identity).GetComponent<FadeBehavior>().ChangeFade(.5f, firstFadeColor, lastFadeColor);
        text.SetActive(true);
        yield return new WaitForSeconds(5);
        Instantiate(fade, new Vector3(0, 0, -9), Quaternion.identity).GetComponent<FadeBehavior>().ChangeFade(.5f, firstFadeColor, lastFadeColor);
        text.GetComponent<TextMesh>().text = "IN A PLACE WHERE ALL YOUR MOVEMENTS ARE\nOBSERVED BY THE CENTRAL PLANNERS";
        yield return new WaitForSeconds(5);
        Instantiate(fade, new Vector3(0, 0, -9), Quaternion.identity).GetComponent<FadeBehavior>().ChangeFade(.5f, firstFadeColor, lastFadeColor);
        text.GetComponent<TextMesh>().text = "THREE REBELS NEED TO SECRETLY SHARE A VERY IMPORTANT\nINFORMATION THAT WILL CHANGE THE WORLD";
        yield return new WaitForSeconds(5);
        Instantiate(fade, new Vector3(0, 0, -9), Quaternion.identity).GetComponent<FadeBehavior>().ChangeFade(.5f, firstFadeColor, lastFadeColor);
        text.GetComponent<TextMesh>().text = "AS A MEMBER OF THE CIVIL SURVEILLANCE\nAGENCY, YOU CAN HELP THEM";
        yield return new WaitForSeconds(5);
        Instantiate(fade, new Vector3(0, 0, -9), Quaternion.identity).GetComponent<FadeBehavior>().ChangeFade(.5f, firstFadeColor, lastFadeColor);
        text.GetComponent<TextMesh>().text = "ARRANGE THE REBELS' ROUTINES SO THAT\nTHEY MEET AT SOME POINT IN THE CITY";
        yield return new WaitForSeconds(5);
        Instantiate(fade, new Vector3(0, 0, -9), Quaternion.identity).GetComponent<FadeBehavior>().ChangeFade(.5f, firstFadeColor, lastFadeColor);
        text.GetComponent<TextMesh>().text = "AFTER ALL, IT'S A SMALL WORLD";
        yield return new WaitForSeconds(5);
        Cursor.visible = true;
        SceneManager.LoadScene(1);
    }
    //
}
