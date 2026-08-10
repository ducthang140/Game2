using UnityEngine;
using DG.Tweening;

public class MainMenuAnimation : MonoBehaviour
{
    public RectTransform menu;

    private void Start()
    {
        menu.anchoredPosition = new Vector2(
            menu.anchoredPosition.x,
            800f
        );

        menu.DOAnchorPosY(0f, 0.8f)
            .SetEase(Ease.OutCubic)
            .SetUpdate(true);
    }
}