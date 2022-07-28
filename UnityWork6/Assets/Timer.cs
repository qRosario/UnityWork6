using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text timerText;
    bool timerRunning = false;
    [SerializeField] private GameObject _menuScreen;
    [SerializeField] private GameObject _looseScreen;
    [SerializeField] private GameObject _gameScreen;

    void Start()
    {
        timerText.text = timeStart.ToString();
        _menuScreen.SetActive(true);
        _looseScreen.SetActive(false);
    }
    // ������ � ������������ ������ �� ��� ���������
    void Update()
    {
        if (timerRunning == true)
        {
            timeStart -= Time.deltaTime;
            timerText.text = Mathf.Round(timeStart).ToString();
        }
        if (timeStart < 0)
        {
            timerRunning = false;
            _menuScreen.SetActive(false);
            _looseScreen.SetActive(true);
        }
    }
    // ������ ������� �� ������� ������
    public void GameTimer()
    {
        timerRunning = true;
    }
    // ���������� ��� ���������� �����
    public void Restart()
    {
        _gameScreen.SetActive(true);
        _looseScreen.SetActive(false);
        timerRunning = true;
        timeStart = 30f;
        
    }
}
