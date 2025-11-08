using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace FlappyBirdEditor
{
    public class FlappyBird : MonoBehaviour
    {
        private static FlappyBird i = new FlappyBird();
        public float JumpForce;
        private Rigidbody2D Rigibody;
        private bool levelStart;
        public GameObject GameController;
        private int Score;
        public Text ScoreText;
        private void Start()
        {
           
        }
        private void Awake()
        {
            Rigibody = this.gameObject.GetComponent<Rigidbody2D>();
            levelStart = false;
            Rigibody.gravityScale = 0;
            //Debug.Log((Rigibody != null) ? "Rigibody2D Has Founded" : "Cannot Find Rigibody2D");
            Score = 0;

        }
        void Update()
        {
            
            transform.rotation = Quaternion.identity; 
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                if (levelStart == false)
                {
                    levelStart = true;
                    Rigibody.gravityScale = 0.75f;
                    GameController.GetComponent<PipeGenerator>().EnableGeneratePipe = true;
                   
                }
                BirdPositionUp();
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
                ReloadScenes();
            
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Score += 1;
            ScoreText.text = Score.ToString();
        }
        public void ReloadScenes()
        {
            if (Score >= 1)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
        public static FlappyBird gI(){
            if (i == null) {
                i = new FlappyBird();
            }
            return i;
        }
        public void BirdPositionUp() //Move Up
        {
            Rigibody.velocity = Vector2.up * JumpForce;
        }
    }
}