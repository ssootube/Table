using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table
{
    //플레이 언어를 바꾸려면 language 변수만 바꾸면 됩니다.
    //To change the play language, you only need to change the language variable.
    string language = "KO"; // "KO" or "EN"

    private Table() { }
    private static Table _instance = null;
    public static Table Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Table();
            return _instance;
        }
    }

    //불러온 언어 데이터가 저장될 리스트 입니다.
    //This is a list of imported language data to be saved.
    private static List<Dictionary<string, object>> dic = null;

    public void init()
    {
        if (dic == null)
            dic = CSVReader.Read("texts");
    }

    //이름이 name인 Text 오브젝트의 placeholder값을 key값에 해당하는 텍스트로 세팅합니다.
    //Sets the placeholder value of a Text object named name to the text corresponding to the key value.
    public void setPlaceholder(string name, string key)
    {
        GameObject.Find(name).GetComponent<InputField>().placeholder.GetComponent<Text>().text = getText(key);
    }

    //이름이 name인 버튼의 text를 key로 key값에 해당하는 텍스트로 세팅합니다.
    //Sets the text of the button named name to the text corresponding to the key value with the key.
    public void setButton(string name, string key)
    {
        GameObject.Find(name).GetComponentInChildren<Text>().text = getText(key);
    }

    //key값을 가지는 텍스트를 불러옵니다.
    //Gets the text with the key value.
    public string getText(string key)
    {
        if (language == "KO")
            return (string)dic[0][key];
        else if (language == "EN")
            return (string)dic[1][key];
        return "";
        
    }
}
