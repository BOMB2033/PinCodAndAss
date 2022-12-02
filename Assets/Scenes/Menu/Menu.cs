using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject showPanel;
    public Text showText;
    private bool isExit = false;
    private Controller Controller;

    private string s1 = @"����� ����������? �� ���� �� ������ ��� ��� �����?! 
���� �� ������ ����� � ������� � ��� �� ����� �� ��������� ���� �� ������, ����� �� ����� ������� ��� �������!";
    private string s2 = @"�����, ���� �� �� ����� ��� ������, �� ������ ������ �� ����� �� ����� ��������.  
��� �� �������� �����������, �??!! ����� ��� � ��� ��������� ����������?";
    private string s3 = @"��� � ���� ����� ������!";
    private string s4 = @"�����������, � ��� ��� �����, ����� ������� ��� �������, 
������� � ��� ����� � ������� ������, � ����� ��� �������";
    private string s5 = @"� ��� ��� ����, � �� ������������, �� ��������";
    private Button buttonOk;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GameObject.Find("Controller").GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.isOkPress && isExit)
        {
            Application.Quit();
            Controller.isOkPress = false;
        }
    }

    public void StartG()
    {
        SceneManager.LoadScene(1);
    }
    public void ContinueG()
    { 
        Controller.ShowMessage(s1);
    }
    public void OptionsG()
    {
        Controller.ShowMessage(s2);

    }
    public void ExitG()
    {
        Controller.ShowMessage(s3);
        Controller.isOkPress = false;
        isExit = true;
    }
    public void DnatG()
    {
        Controller.ShowMessage(s4);

    }
    public void TexPodG()
    {
        Controller.ShowMessage(s5);

    }
    
}
