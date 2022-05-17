using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;
public class JsonReadd : MonoBehaviour
{

    public Text Name, Pass, Total, Current;

    public void Reading_Json_File() {
       string  JsonFile= File.ReadAllText(Application.dataPath + "/Resources/text.json");
        Player_Data player_data = JsonUtility.FromJson<Player_Data>(JsonFile);
      
        
        Name.text = player_data.Player_Name;
        Pass.text = player_data.Passward;
        Total.text = player_data.Total_Score;
        Current.text = player_data.Current_Score;
       
    }
}
