using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        text.text = "You survived for: " + (PlayerPrefs.GetFloat("SurvivingTime")).ToString();
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
