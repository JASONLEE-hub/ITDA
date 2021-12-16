using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SlidingManager : MonoBehaviour
{
    public RectTransform on2, on3, card;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        on2.DOAnchorPos(new Vector2(2000,0), speed);
    }

    public void On2Button()
    {
        on2.DOAnchorPos(new Vector2(0, 0), speed);
    }

    public void CloseOn2Button()
    {
        on2.DOAnchorPos(new Vector2(2000, 0), speed);
    }

    public void On3Button()
    {
        on3.DOAnchorPos(new Vector2(0, 0), speed);
    }

    public void CloseOn3Button()
    {
        on3.DOAnchorPos(new Vector2(2000, 0), speed);
    }

    public void CardButton()
    {
        card.DOAnchorPos(new Vector2(0, 0), speed);
    }

    public void CloseCardButton()
    {
        card.DOAnchorPos(new Vector2(0, 3000), speed);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
