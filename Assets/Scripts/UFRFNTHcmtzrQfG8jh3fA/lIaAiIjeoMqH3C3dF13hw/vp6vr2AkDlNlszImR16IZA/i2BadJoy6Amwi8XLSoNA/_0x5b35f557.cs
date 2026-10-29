using UnityEngine;
using UnityEngine.UI;

public class _0x5b35f557 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x51e11591.Instance._0xc5f3775b(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}