using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xb452ac30 : MonoBehaviour
{
    private void Update()
    {
        this._0x795b2ffd();
    }

    private void _0x795b2ffd()
    {
        if (this._0x4d65bf73.canvasRenderer.GetColor() != this._0x8af44c08.canvasRenderer.GetColor())
            this._0x8af44c08.canvasRenderer.SetColor(this._0x4d65bf73.canvasRenderer.GetColor());
    }

    private TMP_Text _0x8af44c08;
    private Image _0x4d65bf73;
}