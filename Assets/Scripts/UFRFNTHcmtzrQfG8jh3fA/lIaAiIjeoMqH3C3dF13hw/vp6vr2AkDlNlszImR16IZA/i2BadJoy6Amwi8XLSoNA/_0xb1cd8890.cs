using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xb1cd8890 : MonoBehaviour
{
    public Button Button;
    public bool IsLoadCurrentScene;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x51e11591.Instance._0x05618a99(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x51e11591.Instance._0x05618a99(this.LoadSceneId));
    }

    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}