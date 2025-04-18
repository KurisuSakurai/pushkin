using UnityEngine;
using UnityEngine.UI;

public class OpenPageButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private PageGalleryPrefab _pageContainer;
    [SerializeField] private PageUI _pageUI_Prefab;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        _pageUI_Prefab.Instantiate(_pageContainer.Page);
    }
}
