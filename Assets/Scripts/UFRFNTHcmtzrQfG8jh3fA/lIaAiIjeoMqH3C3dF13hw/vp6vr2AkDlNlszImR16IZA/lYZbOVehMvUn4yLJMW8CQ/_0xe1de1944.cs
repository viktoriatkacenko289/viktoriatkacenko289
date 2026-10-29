using UnityEngine;
using UnityEngine.UI;

public class _0xe1de1944 : MonoBehaviour
{
    public Button NextTutorialButton;
    public Button TutorialEndButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x7f8d8525.Instance._0x8b4ff67b(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x51e11591.Instance._0xfa9d91a1());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x7f8d8525.Instance._0x8b4ff67b(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x7f8d8525.Instance._0x8b4ff67b(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x51e11591.Instance._0xfa9d91a1());
        }
    }

    public int EndTutorialPanelIndex = 1;
    public bool IsTutorialEndPanel;
    public int NextTutorialPanelIndex;
}