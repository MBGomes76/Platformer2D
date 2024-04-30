using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TMP_Text FruitText;

    private int _fruitCount = 0;

    public RuntimeAnimatorController MainCharacterAnimator;
    public RuntimeAnimatorController CatAnimator;

    // Awake is called before Start method
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddFruit()
    {
        FruitText.text = $"Fruits : {++_fruitCount}";
    }
}
