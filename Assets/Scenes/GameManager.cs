using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField]private TMP_Text paddle1ScoreText;
    [SerializeField]private TMP_Text paddle2ScoreText;

    [SerializeField]private Transform paddle1Transform;
    [SerializeField]private Transform paddle2Transform;
    [SerializeField]private Transform ballTransform;

    private int paddle1Score;
    private int paddle2Score;

}
