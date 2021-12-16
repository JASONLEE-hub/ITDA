using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public string Name;
    public string Age;
    public string Country;
    public string DAY;
    public bool First;
    public bool clear1;
    public bool clear2;
    public bool clear3;

  public void Save()
    {
        PlayerPrefs.SetString("Name", Name);
        PlayerPrefs.SetString("Age", Age);
        PlayerPrefs.SetString("Country", Country);
        PlayerPrefs.SetString("DAY", DAY);
        DataManager2.SetBool("First", First);
        DataManager2.SetBool("clear1", clear1);
        DataManager2.SetBool("clear2", clear2);
        DataManager2.SetBool("clear3", clear3);

    }
    public void Load()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            Name = PlayerPrefs.GetString("Name");
            Age = PlayerPrefs.GetString("Age");
            Country = PlayerPrefs.GetString("Country");
            DAY = PlayerPrefs.GetString("DAY");
            First = DataManager2.GetBool("First");
            clear1 = DataManager2.GetBool("clear1");
            clear2 = DataManager2.GetBool("clear2");
            clear3 = DataManager2.GetBool("clear3");
        }
    }
}
