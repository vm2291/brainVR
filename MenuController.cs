using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Public variables to hold references to the brain models in the Unity Editor
    public GameObject brainModel1;
    public GameObject brainModel2;
    public GameObject brainModel3;
   



    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;

    // Start is called before the first frame update
    void Start()
    {
        // Initially show brainModel4 and hide the others
       
        HideModel(brainModel1);
        HideModel(brainModel2);
        HideModel(brainModel3);
    }

    // Method called when the user clicks on Brain Model 1
    public void OnBrainModel1Clicked()
    {
        // Show Brain Model 1 and hide the others, including brainModel4
        ShowModel(brainModel1);
        HideModel(brainModel2);
        HideModel(brainModel3);
       
    }

    // Method called when the user clicks on Brain Model 2
    public void OnBrainModel2Clicked()
    {
        // Show Brain Model 2 and hide the others, including brainModel4
        ShowModel(brainModel2);
        HideModel(brainModel1);
        HideModel(brainModel3);
       
    }

    // Method called when the user clicks on Brain Model 3
    public void OnBrainModel3Clicked()
    {
        // Show Brain Model 3 and hide the others, including brainModel4
        ShowModel(brainModel3);
        HideModel(brainModel1);
        HideModel(brainModel2);
       
    }

    // Method to show a specific model
    private void ShowModel(GameObject model)
    {
        // Set the model to active to make it visible
        model.SetActive(true);
    }

    // Method to hide a specific model
    private void HideModel(GameObject model)
    {
        // Set the model to inactive to hide it
        model.SetActive(false);
    }
 // Public method to enable Animators on all doors
    public void EnableAllDoorAnimators()
    {
        // Enable the Animator component on each door
        EnableAnimator(door1);
        EnableAnimator(door2);
        EnableAnimator(door3);
        EnableAnimator(door4);
        EnableAnimator(door5);
    }

    // Helper method to enable an Animator component on a GameObject
    private void EnableAnimator(GameObject obj)
    {
        // Check if the GameObject and its Animator component exist
        if (obj != null)
        {
            Animator animator = obj.GetComponent<Animator>();
            if (animator != null)
            {
                // Enable the Animator component
                animator.enabled = true;
            }
        }
    }
     public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                    Application.Quit();
        #endif
    }
}


