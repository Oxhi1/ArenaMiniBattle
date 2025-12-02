using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public Slider musicSlider;
    public Slider sfxSlider;
    public AudioSettings audioSettings;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (pauseMenu != null)
        {
            bool isActive = pauseMenu.activeSelf;
            pauseMenu.SetActive(!isActive);
            Time.timeScale = isActive ? 1f : 0f;
        }
    }

    public void SetMusic(float v) { if (audioSettings!=null) audioSettings.SetMusic(v); }
    public void SetSFX(float v) { if (audioSettings!=null) audioSettings.SetSFX(v); }
}