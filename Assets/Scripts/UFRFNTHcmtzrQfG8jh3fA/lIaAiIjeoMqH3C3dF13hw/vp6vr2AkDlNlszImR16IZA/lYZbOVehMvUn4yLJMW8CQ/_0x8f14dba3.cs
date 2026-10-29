using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8f14dba3 : MonoBehaviour
{
    public void _0x418a979b()
    {
        this._0x11e8d7b2();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public float ScaleDuration = 0.4f;
    public TMP_Text MainText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xecb47eab();
    }

    private void _0xbfa8af69()
    {
        if (this.OuterBackground != null)
        {
            Image _0x4c783b81 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x4c783b81, true);
            _0x4c783b81.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public GameObject Content;
    private void _0x11e8d7b2()
    {
        if (this.OuterBackground != null)
        {
            Image _0x219bdc93 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x219bdc93, true);
            _0x219bdc93.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0x24a2eec7()
    {
        if (this.OuterBackground != null)
        {
            Image _0x6022922c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x6022922c, true);
            _0x6022922c.DOFade(1f, 0f);
        }
    }

    private void _0xecb47eab()
    {
        if (this.OuterBackground != null)
        {
            Image _0x440c8ae5 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x440c8ae5, true);
            _0x440c8ae5.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public TMP_Text HeaderText;
    public void Show()
    {
        this._0xbfa8af69();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x7f8d8525.Instance._0xaa121859(_0x7f8d8525.Instance.CurrentPanelIndex);
            });
        }
    }

    public bool IsScaledDownOnAwake = true;
    private bool _0x81fb01c8 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public Ease Ease = Ease.OutSine;
    public void _0x312d7078()
    {
        this._0x24a2eec7();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x7f8d8525.Instance._0xaa121859(_0x7f8d8525.Instance.CurrentPanelIndex);
    }

    public GameObject OuterBackground;
}