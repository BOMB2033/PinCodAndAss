using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    private GameObject showPanel;
    private Text showText;
    public bool isOkPress = false;
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Controller");
        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }


    }
    public void OkG(BaseEventData pointData)
    {
        GameObject.Find("ShowPanel").SetActive(false);        
        isOkPress = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("NewScene").GetComponent<NewSceneControl>().newScene)
        {
            GameObject.Find("NewScene").GetComponent<NewSceneControl>().newScene = false;
            SetButtonEvemnOk();
            
            showPanel = GameObject.Find("ShowPanel");
            showText = GameObject.Find("ShowText").GetComponent<Text>();
            if (SceneManager.sceneCount == 2)
            {
                showPanel.SetActive(false);
            }
        }
    }

    private void SetButtonEvemnOk()
    {
        Button btn = GameObject.Find("ButtonOk").GetComponent<Button>();
        EventTrigger trigger = btn.gameObject.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        // событие щелчка мышью
        entry.eventID = EventTriggerType.PointerClick;
        // Мышь событие входа entry.eventID = EventTriggerType.PointerEnter;
        // Мышь вне события entry.eventID = EventTriggerType.PointerExit;
        entry.callback = new EventTrigger.TriggerEvent();
        entry.callback.AddListener(OkG);
        // entry.callback.AddListener (OnMouseEnter);
        trigger.triggers.Add(entry);
    }
    public void ShowMessage(string str)
    {
        showPanel.SetActive(true);
        showText.text = str;
    }

}
