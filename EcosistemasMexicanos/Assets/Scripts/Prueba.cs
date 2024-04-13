//using UnityEngine;
//using System;
//using System.Collections.Generic;
//using UnityEngine.UI;
//using TMPro;
//using System.Numerics;
//using Vector3 = UnityEngine.Vector3;

//// Como un futuro paso podemos:
////      - hacer que se randomice también la posición inicial de cada personaje
////      - en vez de que se tengan que inicializar cada personaje individualmente, podríamos generarlos dinámicamente en este script

//public class GameController : MonoBehaviour
//{

//    public static GameController Instance;

//    [Header("Scripts")]
//    public CargarNivel referenciaCargarNivel; //El script que se encarga de la transición entre niveles

//    [Header("Personaje Tipo 1")]
//    [SerializeField] private GameObject personaje1Tipo1;
//    [SerializeField] private GameObject personaje2Tipo1;
//    [SerializeField] private GameObject personaje3Tipo1;

//    [Header("Suelo")]//Agregamos un suelo a la experiencia para que no se pierdan los modelos con el suelo real
//    [SerializeField] private GameObject suelo; //Debería de ser cuadrado, no rectangular

//    //Personajes de tipo 1 (son del mismo modelo) y se mueven en trayectoria circular
//    private Personaje p1T1;
//    private Personaje p2T1;
//    private Personaje p3T1;

//    //Variables internas a la clase
//    private Personaje[] pT; //Arreglo de los personajes de tipo 1 
//    private Vector3[] pT1initialOffset; //Arreglo para guardar las posiciones iniciales de los modelos tipo 1
//    private Vector3[] pT2initialOffset; //Arreglo para guardar las posiciones iniciales de los modelos tipo 2
//    private Vector3[] pT3initialOffset; //Arreglo para guardar las posiciones iniciales de los modelos tipo 3
//    //private Vector3[] pT4initialOffset;
//    //private Vector3[] pT5initialOffset;

//    //Es un arreglo y no un único valor pq no queremos que los tamaños de movimiento sean iguales
//    private float[] pT1Radio; //Arreglo de los radios para los movimientos para los personajes tipo 1
//    private float[] pT1Speed; //Arreglo de las velocidades para los movimientos de los personajes tipo 1


//    //Se llama al inicio (1 vez) cuando se carga el juego
//    private void Start()
//    {
//        //Para que la velocidad de cada personaje sea diferente entre partidas
//        pT1Speed = new float[] {
//            UnityEngine.Random.Range(0.8f, 6),
//            UnityEngine.Random.Range(0.8f, 6),
//            UnityEngine.Random.Range(0.8f, 6),
//        };

//        if (nivel == 1 || nivel == 2)
//        {
//            if (nivel == 1)
//            {
//                //Toma los game objects dados (ej. los modelos) y los guarda como personajes
//                p1T1 = personaje1Tipo1.gameObject.GetComponent<Personaje>();
//                p2T1 = personaje2Tipo1.gameObject.GetComponent<Personaje>();
//                p3T1 = personaje3Tipo1.gameObject.GetComponent<Personaje>();


//                //Hay que recalcular la posición de los modelos para que estén en relación del "piso" virtual y no del origen
//                pT1initialOffset = new Vector3[] {
//                    p1T1.gameObject.transform.position - suelo.transform.position,
//                    p2T1.gameObject.transform.position - suelo.transform.position,
//                    p3T1.gameObject.transform.position - suelo.transform.position
//                };



//            }


//        }

//    } //FIN DEL METODO START

//    //Se llama en cada frame
//    void Update()
//    {
//        timeCounter += Time.deltaTime;
//        if (!gano)
//        {
//            if (nivel == 1)
//            {
//                moverPersonajeTipo1();
//                moverPersonajeTipo2();
//                moverPersonajeTipo3();
//            }
//        }

//    }

//    //Necesita estar este metodo para que Unity compile
//    public void ButtonClicked(ButtonClickHandler btnHandler)
//    {
//        // Your logic here
//    }

//    private void Awake()
//    {
//        if (Instance == null)
//            Instance = this;
//        else
//            Destroy(gameObject);
//    }

//    //Mueve los objetos en una trayectoria circular
//    public void moverPersonajeTipo1()
//    {
//        float x, z;
//        float radioCirculo;

//        //Esta en un for para que el movimiento de cada tipo sea igual pero en diferentes magnitudes
//        for (int i = 0; i < 3; i++)
//        {
//            radioCirculo = pT1Radio[i];
//            x = suelo.gameObject.transform.position.x + pT1initialOffset[i].x - (float)Math.Pow(-1, i) * (radioCirculo * Mathf.Cos(timeCounter * pT1Speed[i]));
//            z = suelo.gameObject.transform.position.z + pT1initialOffset[i].z - (float)Math.Pow(-1, i) * (radioCirculo * Mathf.Sin(timeCounter * pT1Speed[i]));

//            switch (i)
//            {
//                case 0:
//                    p1T1.transform.position = new Vector3(x, suelo.gameObject.transform.position.y + 0.04f, z);
//                    break;
//                case 1:
//                    p2T1.transform.position = new Vector3(x, suelo.gameObject.transform.position.y + 0.04f, z);
//                    break;
//                case 2:
//                    p3T1.transform.position = new Vector3(x, suelo.gameObject.transform.position.y + 0.04f, z);
//                    break;
//            }
//        }
//    }


//    private Color makeRGBcolor(float r, float g, float b)
//    {
//        return new Color(r / 255f, g / 255f, b / 255f);
//    }
//}
