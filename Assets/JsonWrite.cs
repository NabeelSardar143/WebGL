using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class JsonWrite : MonoBehaviour
{

    public InputField Name, Pass, Total, Current;

    Player_Data player_data = new Player_Data();

    public void outputJson()
    {
        
        player_data.Player_Name = Name.text;
        player_data.Passward = Pass.text;
        player_data.Total_Score = Total.text;
        player_data.Current_Score = Current.text;
        string strOutPut = JsonUtility.ToJson(player_data);
        File.WriteAllText(Application.dataPath + "/Resources/text.json", strOutPut);


    }

}
