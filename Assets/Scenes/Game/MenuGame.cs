using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuGame : MonoBehaviour
{
    private Controller Controller;
    private GameObject panelMenu;
    private GameObject panelMap;
    // Start is called before the first frame update
    void Start()
    {
        
        panelMenu = GameObject.Find("PanelMenu");
        panelMap = GameObject.Find("PanelMap");
        SetButtonEvemnt(OkMenu, "OkMenu");
        SetButtonEvemnt(Esc, "Esc");
        SetButtonEvemnt(MapButton, "MapButton");
        SetButtonEvemnt(MapButtonExit, "MapButtonExit");
        panelMenu.SetActive(false);
        panelMap.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetButtonEvemnt(UnityAction<BaseEventData> nevent, string namebutton)
    {
        Button btn = GameObject.Find(namebutton).GetComponent<Button>();
        EventTrigger trigger = btn.gameObject.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        // событие щелчка мышью
        entry.eventID = EventTriggerType.PointerClick;
        // Мышь событие входа entry.eventID = EventTriggerType.PointerEnter;
        // Мышь вне события entry.eventID = EventTriggerType.PointerExit;
        entry.callback = new EventTrigger.TriggerEvent();
        entry.callback.AddListener(nevent);
        // entry.callback.AddListener (OnMouseEnter);
        trigger.triggers.Add(entry);
    }
    public void Esc(BaseEventData pointData)
    {
        panelMenu.SetActive(true);
    }
    public void MapButton(BaseEventData pointData)
    { 
            panelMap.SetActive(true);
    }
    public void MapButtonExit(BaseEventData pointData)
    {
        panelMap.SetActive(false);        
    }
        public void OkMenu(BaseEventData pointData)
    {
        panelMenu.SetActive(false);
    }

}
