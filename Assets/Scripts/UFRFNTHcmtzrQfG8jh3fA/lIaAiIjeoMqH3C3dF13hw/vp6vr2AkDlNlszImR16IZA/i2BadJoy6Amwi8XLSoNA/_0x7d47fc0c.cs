using UnityEngine;
using UnityEngine.UI;

public class _0x7d47fc0c : MonoBehaviour
{
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x8f0aa4a3.Instance._0xb67ca9cc();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x8f0aa4a3.Instance._0xed11e002());
        else
            this.Button.onClick.AddListener(() => _0x8f0aa4a3.Instance._0x885f3061(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
    public bool IsShowLastPop;
    public int PopToShowIndex;
}