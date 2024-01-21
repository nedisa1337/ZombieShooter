using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;

    public Slider healthSlider;
    public CinemachineVirtualCamera virtualCamera;
    public EnemyAiTutorial enemyAi;

    CharacterLocomotion locomotionScript;
    CharacterAiming aimingScript;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        if (health > 0)
        {
            health -= damage;
        }
        else return;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("EndGame");
    }

    private void Update()
    {
        if(health <= 0) 
        {
            health = 0;
            animator.SetBool("isDead", true);
            Destroy(locomotionScript);
            Destroy(aimingScript);
            if(virtualCamera != null) Destroy(virtualCamera.gameObject);
            Invoke(nameof(RestartLevel), 2f);
            PlayerPrefs.SetFloat("SurvivingTime", Time.time);
        }
        healthSlider.value = health;
    }
}
