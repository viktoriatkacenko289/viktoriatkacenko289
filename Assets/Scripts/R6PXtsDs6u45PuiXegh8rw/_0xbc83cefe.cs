using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// One cell of the reel window. The sprite is drawn Simple with preserveAspect so a 512x512
// generated PNG keeps its proportions whatever the cell is sized to (CLAUDE-unity.md F.2a).
public sealed class _0xbc83cefe : MonoBehaviour
{
    // The winning-symbol pop. Scale is driven from 1 rather than a literal size, so it is
    // correct whatever the cell was laid out at.
    public void _0x3fc7bc7c(float _0x42f1021b)
    {
        if (this._root == null)
            return;
        DOTween.Kill(this._root);
        this._root.localScale = Vector3.one;
        Sequence _0xe3185e9e = DOTween.Sequence().SetLink(this._root.gameObject);
        _0xe3185e9e.AppendInterval(_0x42f1021b);
        _0xe3185e9e.Append(this._root.DOScale(1.12f, 0.14f).SetEase(Ease.OutQuad));
        _0xe3185e9e.Append(this._root.DOScale(1f, 0.14f).SetEase(Ease.InQuad));
    }

    public void _0xbba9dfe0(bool _0xdd29d38e)
    {
        if (this._image == null)
            return;
        this._image.color = _0xdd29d38e ? new Color(1f, 1f, 1f, 0.45f) : Color.white;
    }

    public void _0x84b295ce(float _0x2919a020)
    {
        if (this._root == null)
            return;
        Vector2 _0x428b7712 = this._root.anchoredPosition;
        this._root.anchoredPosition = new Vector2(_0x428b7712.x, _0x2919a020);
    }

    public RectTransform _0x7b4042fc
    {
        get
        {
            return this._root;
        }
    }

    [SerializeField]
    private Image _image;
    private void OnDestroy()
    {
        if (this._root != null)
            DOTween.Kill(this._root);
    }

    public void _0x583140b7(int _0x852573b7, Sprite _0x3c9a9d3d)
    {
        this._0x678723c0 = _0x852573b7;
        if (this._image == null)
            return;
        this._image.sprite = _0x3c9a9d3d;
        this._image.preserveAspect = true;
        this._image.enabled = _0x3c9a9d3d != null;
        this._image.color = Color.white;
    }

    private int _0x678723c0 = -1;
    public int _0x825021f9
    {
        get
        {
            return this._0x678723c0;
        }
    }

    [SerializeField]
    private RectTransform _root;
}