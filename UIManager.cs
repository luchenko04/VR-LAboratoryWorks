using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text hoverText;

    public static UIManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void ShowText(string text)
    {
        hoverText.text = text;
        hoverText.gameObject.SetActive(true);
    }
    public void HideText()
    {
        hoverText.gameObject.SetActive(false);
    }
}
