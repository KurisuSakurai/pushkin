using UnityEngine;

[CreateAssetMenu(fileName = "Page", menuName = "Game/Author")]
[Icon("Assets/_Project/Author/Icons/poet.png")]
public class Author : ScriptableObject
{
    [field: DisplayName("ФИО")]
    [field: Tooltip("Вводи что хочешь")]
    [field: SerializeField] public string Name { get; private set; }
}
