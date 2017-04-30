using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleController : MonoBehaviour {

    public GameObject console;

	public void ShowMessage(string msg, bool permanent)
    {
        StopAllCoroutines();
        console.SetActive(true);
        console.GetComponentInChildren<Text>().text = msg;

        if (!permanent)
        {
            StartCoroutine(CloseTiming());
        }
    }

    public void CloseConsole()
    {
        console.GetComponentInChildren<Text>().text = "";
        console.SetActive(false);
    }

    IEnumerator CloseTiming()
    {
        yield return new WaitForSeconds(3);
        console.GetComponentInChildren<Text>().text = "";
        console.SetActive(false);
    }

}
