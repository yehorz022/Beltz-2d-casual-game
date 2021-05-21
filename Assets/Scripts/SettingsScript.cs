using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] private Transform box;
    [SerializeField] private CanvasGroup background;

    private void OnEnable()
    {
        background.alpha = 0;
        background.LeanAlpha(1, 0.6f);
        box.localPosition = new Vector2(0, Screen.height);
        box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
    }

    public void CloseSettings()
    {
        background.LeanAlpha(0, 0.6f);
        box.LeanMoveLocalY(Screen.height, 0.6f).setEaseInExpo().setOnComplete(OnComplete);
    }

    private void OnComplete()
    {
        gameObject.SetActive(false);
    }
}