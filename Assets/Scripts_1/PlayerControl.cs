using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace PlayerControl
{
    public class PlayerControl3D : MonoBehaviour
    {

        [SerializeField]
        PlayerInput controPlayer;

        Vector3 move;

        [SerializeField]
        protected float velocidad;

        [SerializeField]
        //Variables global de rigibody
        protected Rigidbody rb;
        [SerializeField]
        protected Animator anim;


        void OnMove(InputValue value)
        {
            Vector2 moveAxis = value.Get<Vector2>();

            //move 3D
            move= new Vector3(moveAxis.x*velocidad,0,moveAxis.y*velocidad);

           
        }



        // Start is called before the first frame update
        void Awake()
        {
            
                rb = GetComponent<Rigidbody>();
            
            if(anim != null)
            anim = GetComponent<Animator>();
        }


        protected void Control3D()
        {
            Vector3 gravity = new Vector3(0, rb.velocity.y, 0);

            Movimiento3D(rb, gravity);

            bool animActive = move.x < 0 || move.x > 0 ? true : false;

            //anim.SetBool("Run", animActive);
        }

        void Movimiento3D(Rigidbody rb, Vector3 g)
        {
            Vector3 gravity = g;
            rb.velocity = move + gravity;
        }

       

    }


    public class PlayerControl2D : MonoBehaviour
    {

        [SerializeField]
        PlayerInput controPlayer;

       protected Vector3 move;

        [SerializeField]
        protected float velocidad;

        [SerializeField]
        protected Rigidbody2D rb2d;

        [SerializeField]
        protected Animator anim;


        void OnMove(InputValue value)
        {
            Vector2 moveAxis = value.Get<Vector2>();


            //move 2d
            move = new Vector3(moveAxis.x * velocidad, 0, 0);
        }



        // Start is called before the first frame update
        void Awake()
        {


            rb2d = GetComponent<Rigidbody2D>();

            anim = GetComponentInChildren<Animator>();
        }


       

        public void Control2D()
        {
            Vector3 gravity = new Vector3(0, rb2d.velocity.y, 0);

            Movimiento2D(rb2d, gravity);

            bool animActive = move.x < 0 || move.x > 0 ? true : false;

            anim.SetBool("Run", animActive);


        }


       public void Movimiento2D(Rigidbody2D rb, Vector3 g)
        {
            Vector3 gravity = g;
            rb.velocity = move + gravity;
        }

    }

}

