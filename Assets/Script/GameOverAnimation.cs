using UnityEngine;
using DG.Tweening;

public class GameOverUI : MonoBehaviour
{
    public float animationDuration = 0.4f;

    private void Awake()
    {
        // Hide the panel at the beginning
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);

        // Start small
        transform.localScale = Vector3.zero;

        // Pop up
        transform.DOScale(Vector3.one, animationDuration)
            .SetEase(Ease.OutBack)
            .SetUpdate(true);
    }
}
