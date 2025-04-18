using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PageUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _pageName;
    [SerializeField] private TMP_Text _pageDescription;
    [SerializeField] private Image _image;
    [SerializeField] private Image _imageMask;
    [SerializeField] private Button _closeButton;
    [SerializeField] private TMP_Text _author;
    
    private Page _page;

    public PageUI Instantiate(Page page)
    {
        gameObject.SetActive(false);
        PageUI instance = Instantiate(this);
        gameObject.SetActive(true);
        
        instance.Init(page);
        return instance;
    }
    
    private void Init(Page page)
    {
        _page = page;
        _image.sprite = _page.Image;
        _pageName.text = _page.Name;
        _pageDescription.text = _page.Description;
        if (_page.Author == null)
        {
            Debug.LogError($"[<color=yellow>ОШИБКА ЗАПОЛНЕНИЯ КАРТИН</color>] Автор картины {_page} не найден", _page);
            _author.text = $"Автор неизвестен  {_page.BornDate}г.";
        }
        else
        {
            _author.text = $"{_page.Author.Name}  {_page.BornDate}г."; 
        }
        
        gameObject.SetActive(true);
        
        int imageWight = _page.Image.texture.width;
        int imageHeight = _page.Image.texture.height;
        
        Vector2 resultSize = new Vector2(800, 800);

        if (imageWight < imageHeight)
        {
            float modifier = resultSize.y / imageHeight;
            resultSize.x = imageWight * modifier;
        }
        else
        {
            float modifier = resultSize.x / imageWight;
            resultSize.y = imageHeight * modifier;
        }
        
        _image.sprite = _page.Image;
        _image.rectTransform.sizeDelta = resultSize;
    }

    private void OnEnable()
    {
        _closeButton.onClick.AddListener(OnCloseClick);
    }

    private void OnDisable()
    {
        _closeButton.onClick.RemoveListener(OnCloseClick);
    }

    private void OnCloseClick()
    {
        Destroy(gameObject);
    }
}
