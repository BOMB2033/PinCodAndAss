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

    private string s1 = @"Какой продолжить? Ты сука не знаешь кто это писал?! 
Было бы больше денег и желания и еще бы трусы не оставляли след на бедрах, тогда бы может сделали эту функцию!";
    private string s2 = @"Блять, знал бы ты какой тут бюджет, то лишнее кнопки не тыкал от греха подальше.  
ЧТО ТЫ СОБРАЛСЯ НАСТРАИВАТЬ, А??!! Может еще в тех поддержку обратишься?";
    private string s3 = @"Вот и вали нахуй отсюда!";
    private string s4 = @"АХАХАХАХАХА, у нас нет денег, чтобы сделать эту функцию, 
приходи к нам лично и отдавай деньги, а лучше еды принеси";
    private string s5 = @"А вот хуй тебе, а не техподдержка, не заслужил";
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
