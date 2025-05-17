using UnityEngine;
using TMPro;

public class GameUIManager : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        playerNameText.text = "Player: " + playerName;
    }
}
