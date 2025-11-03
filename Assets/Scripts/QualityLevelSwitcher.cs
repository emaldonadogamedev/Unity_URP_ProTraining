using UnityEngine;
using UnityEngine.InputSystem;
using UnityStandardAssets.CrossPlatformInput;

public class QualityLevelSwitcher : MonoBehaviour
{
    private int m_amountOfLevels;
    private int m_currentLevel;

    private void Start()
    {
        m_amountOfLevels = QualitySettings.count;
        m_currentLevel = QualitySettings.GetQualityLevel();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ToggleQualityLevel();
        }
    }

    // Call this method to change the quality level
    private void ToggleQualityLevel()
    {
        m_currentLevel = (m_currentLevel + 1) % m_amountOfLevels;
        
        // Set the new quality level. 
        // The 'false' parameter prevents immediate application of expensive changes.
        QualitySettings.SetQualityLevel(m_currentLevel, true); 
        Debug.Log("Quality level set to: " + QualitySettings.names[m_currentLevel]);
    }
}