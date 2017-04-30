using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class MissionBahavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject missionPopup;

    public void OnPointerEnter(PointerEventData eventData)
    {
        missionPopup.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        missionPopup.SetActive(false);
    }

}
