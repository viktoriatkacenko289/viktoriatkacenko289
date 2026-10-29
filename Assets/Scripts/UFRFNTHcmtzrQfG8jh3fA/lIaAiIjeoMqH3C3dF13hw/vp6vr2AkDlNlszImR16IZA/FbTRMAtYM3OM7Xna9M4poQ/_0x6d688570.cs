using TMPro;
using UnityEngine;
using static _0xe06f358c;

public class _0x6d688570 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x979ea731;
            if (this.gameObject.TryGetComponent(out _0x979ea731))
                this.MoneyCountText = _0x979ea731;
        }

        this._0xa12ded5c();
    }

    public TMP_Text MoneyCountText;
    public void _0xa12ded5c()
    {
        this.MoneyCountText.text = _0x0eee97d9._0x0f7fe95d.ToString();
    }
}