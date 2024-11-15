using UnityEngine;

public class TextDisplayOnHover : MonoBehaviour
{
    public string displayText;
    private void OnMouseEnter()
    {
        UIManager.Instance.ShowText(displayText);
    }
    private void OnMouseExit()
    {
        UIManager.Instance.HideText();
    }
}
