using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private GameObject showPanel;
    public Text showText;
    private string s1 = @"����� ����������? �� ���� �� ������ ��� ��� �����?! 
���� �� ������ ����� � ������� � ��� �� ����� �� ��������� ���� �� ������, ����� �� ����� ������� ��� �������!";
    private string s2 = @"�����, ���� �� �� ����� ��� ������, �� ������ ������ �� ����� �� ����� ��������.  
��� �� �������� �����������, �??!! ����� ��� � ��� ��������� ����������?";
    private string s3 = @"��� � ���� ����� ������!";
    private string s4 = @"�����������, � ��� ��� �����, ����� ������� ��� �������, 
������� � ��� ����� � ������� ������, � ����� ��� �������";
    private string s5 = @"� ��� ��� ����, � �� ������������, �� ��������";
    // Start is called before the first frame update
    void Start()
    {
        showPanel = GameObject.Find("ShowPanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartG()
    {

    }
    public void ContinueG()
    {
        showPanel.SetActive(true);
        showText.text = s1;
    }
    public void OptionsG()
    {
        showPanel.SetActive(true);
        showText.text = s2;

    }
    public void ExitG()
    {
        showPanel.SetActive(true);
        showText.text = s3;

    }
    public void DnatG()
    {
        showPanel.SetActive(true);
        showText.text = s4;

    }
    public void TexPodG()
    {
        showPanel.SetActive(true);
        showText.text = s5;

    }
    public void OkG()
    {
        showPanel.SetActive(false);
    }
}
