using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    private Controller Controller;
    private bool isClickOk = false;
    // Start is called before the first frame update
    void Start()
    {
        SetButtonEvemnt(Krosh, "Krosh");
        SetButtonEvemnt(Esc, "Esc");
        SetButtonEvemnt(Egik,"Egik");
        SetButtonEvemnt(Nusha, "Nusha");
        SetButtonEvemnt(KarKar, "KarKar");
        SetButtonEvemnt(Kopat,"Kapat");
        SetButtonEvemnt(Losysh,"Loshah");
        SetButtonEvemnt(Barash,"Barash");
        SetButtonEvemnt(Sova, "Sova");
        SetButtonEvemnt(PinCod, "PinCod");

    }

    // Update is called once per frame
    void Update()
    {
        Controller = GameObject.Find("Controller").GetComponent<Controller>();

        if (Controller.isOkPress && isClickOk)
        {
            isClickOk = false;
            GameObject.Find("NewScene").GetComponent<AudioSource>().Play();
            SceneManager.LoadScene(2);
        }
    }

    public void SetButtonEvemnt(UnityAction<BaseEventData> nevent, string namebutton)
    {
        Button btn = GameObject.Find(namebutton).GetComponent<Button>();
        EventTrigger trigger = btn.gameObject.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        // ������� ������ �����
        entry.eventID = EventTriggerType.PointerClick;
        // ���� ������� ����� entry.eventID = EventTriggerType.PointerEnter;
        // ���� ��� ������� entry.eventID = EventTriggerType.PointerExit;
        entry.callback = new EventTrigger.TriggerEvent();
        entry.callback.AddListener(nevent);
        // entry.callback.AddListener (OnMouseEnter);
        trigger.triggers.Add(entry);
    }

    public void PinCod(BaseEventData pointData)
    {
        Controller.ShowMessage("���� ���� �������, ����� �� ������ �� ����");
        Controller.isOkPress = false;
        isClickOk = true;

    }
    public void Esc(BaseEventData pointData)
    {
        SceneManager.LoadScene(0);
    }
    public void Sova(BaseEventData pointData)
    {
        Controller.ShowMessage("�� ����� ����� ������ ������, �� ����������");
    }
    public void Krosh(BaseEventData pointData)
    {
        Controller.ShowMessage("�� ����� ����� ������ ������, �� ����������");

    }
    public void Egik(BaseEventData pointData)
    {
        Controller.ShowMessage("�� ����� ����� ������ ������, �� ����������");

    }
    public void Barash(BaseEventData pointData)
    {
        Controller.ShowMessage("�� ����� ����� ������ ������, �� ����������");

    }
    public void Nusha(BaseEventData pointData)
    {
        Controller.ShowMessage("�� ����� ����� ������ ������, �� ����������");

    }
    public void KarKar(BaseEventData pointData)
    {
        Controller.ShowMessage("�� ����� ����� ������ ������, �� ����������");

    }
    public void Losysh(BaseEventData pointData)
    {
        Controller.ShowMessage("�� ����� ����� ������ ������, �� ����������");

    }
    public void Kopat(BaseEventData pointData)
    {
        Controller.ShowMessage("�� ����� ����� ������ ������, �� ����������");

    }


}
