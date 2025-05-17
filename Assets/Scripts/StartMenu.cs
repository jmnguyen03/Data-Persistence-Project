using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class StartMenu : MonoBehaviour
{
    public TMP_InputField nameInputField;


    public void StartGame()
    {
        string playerName = nameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();  // optional, ensures it's saved immediately
        SceneManager.LoadScene("main"); // replace with your game scene name
    }
}
