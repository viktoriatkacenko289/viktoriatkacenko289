using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x411dd6a7 : MonoBehaviour
{
    private bool _0xbc3bfb84 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Start()
    {
    // Content.SetActive(false);
    }

    public void _0x79dffccb()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public Image ContentImage;
    public bool IsOnlyYScale;
    public float scaleDuration = 0.4f;
    private void _0x75264d43()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x75264d43();
    }

    public TMP_Text ContentMainText;
    public bool IsScaledDownOnAwake = true;
    public Ease ease = Ease.OutSine;
    public TMP_Text ContentHeaderText;
    public static void HideAllPops()
    {
        _0x8f0aa4a3.Instance._0xed11e002();
    }

    public GameObject Content;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentAdditionalText;
}