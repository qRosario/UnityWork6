using UnityEngine;
using UnityEngine.UI;

public class Hacking : MonoBehaviour
{
    [SerializeField] private GameObject _gameScreen;
    [SerializeField] private GameObject _victoryScreen;
    public Text firstPinText;
    public Text secondPinText;
    public Text thirdPinText;
    private int[] _pins = new int[3];
    private int[] _drill = new int[3];
    private int[] _hammer = new int[3];
    private int[] _key = new int[3];


    void Update()
    {
        for (int i = 0; i < _pins.Length; i++)
        {
            _pins[0] = int.Parse(firstPinText.text);
            _pins[1] = int.Parse(secondPinText.text);
            _pins[2] = int.Parse(thirdPinText.text);
            if (_pins[0] >= 10)
                _pins[0] = 10;
                firstPinText.text = _pins[0].ToString();
            if (_pins[1] >= 10)
                _pins[1] = 10;
                secondPinText.text = _pins[1].ToString();
            if (_pins[2] >= 10)
                _pins[2] = 10;
                thirdPinText.text = _pins[2].ToString();
            if (_pins[0] <= 0)
                _pins[0] = 0;
            firstPinText.text = _pins[0].ToString();
            if (_pins[1] <= 0)
                _pins[1] = 0;
            secondPinText.text = _pins[1].ToString();
            if (_pins[2] <= 0)
                _pins[2] = 0;
            thirdPinText.text = _pins[2].ToString();
            if (_pins[0] == 5 && _pins[1] == 5 && _pins[2] == 5)
            {
                _victoryScreen.SetActive(true);
            }
        }
    }
    public void DrillButton()
    {
        for (int i = 2; i < _drill.Length; i++)
        {
            _drill[0] = 1;
            _pins[0] += _drill[0];
            firstPinText.text = _pins[0].ToString();
            _drill[1] = 1;
            _pins[1] += _drill[1];
            secondPinText.text = _pins[1].ToString();
            _drill[2] = 1;
            _pins[2] += _drill[2];
            thirdPinText.text = _pins[2].ToString();
        }
    }
    public void HammerButton()
    {
        for (int i = 2; i < _hammer.Length; i++)
        {
            _hammer[0] = -2;
            _pins[0] += _hammer[0];
            firstPinText.text = _pins[0].ToString();
            _hammer[1] = 2;
            _pins[1] += _hammer[1];
            secondPinText.text = _pins[1].ToString();
            _hammer[2] = 2;
            _pins[2] += _hammer[2];
            thirdPinText.text = _pins[2].ToString();
        }
    }
    public void KeyButton()
    {
        for (int i = 2; i < _key.Length; i++)
        {
            _key[0] = -2;
            _pins[0] += _key[0];
            firstPinText.text = _pins[0].ToString();
            _key[1] = -2;
            _pins[1] += _key[1];
            secondPinText.text = _pins[1].ToString();
            _key[2] = -2;
            _pins[2] += _key[2];
            thirdPinText.text = _pins[2].ToString();
        }
    }
    public void Restart()
    {
        _victoryScreen.SetActive(false);
        firstPinText.text = 7.ToString();
        secondPinText.text = 3.ToString();
        thirdPinText.text = 3.ToString();
        for (int i = 0; i < _drill.Length; i++)
        {
            _drill[i] = 0;
            _hammer[i] = 0;
            _key[i] = 0;
        }
    }
}
