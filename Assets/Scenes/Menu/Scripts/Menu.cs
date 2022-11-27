using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private GameObject showPanel;
    public Text showText;
    private string s1 = @"Какой продолжить? Ты сука не знаешь кто это писал?! 
Было бы больше денег и желания и еще бы трусы не оставляли след на бедрах, тогда бы может сделали эту функцию!";
    private string s2 = @"Блять, знал бы ты какой тут бюджет, то лишнее кнопки не тыкал от греха подальше.  
ЧТО ТЫ СОБРАЛСЯ НАСТРАИВАТЬ, А??!! Может еще в тех поддержку обратишься?";
    private string s3 = @"Вот и вали нахуй отсюда!";
    private string s4 = @"АХАХАХАХАХА, у нас нет денег, чтобы сделать эту функцию, 
приходи к нам лично и отдавай деньги, а лучше еды принеси";
    private string s5 = @"А вот хуй тебе, а не техподдержка, не заслужил";
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
