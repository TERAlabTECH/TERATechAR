using UnityEngine;
using UnityEngine.SceneManagement;


//Script para pasar de un nivel a otro. Este script va dentro del Game Controller
public class Planetas : MonoBehaviour
{
    [SerializeField] private Planeta Mercurio;
    [SerializeField] private Planeta Venus;
    [SerializeField] private Planeta Marte;
    [SerializeField] private Planeta Saturno;

    private Planeta[] planetas;

    // Awake is called when the script instance is being loaded.
    void Awake()
    {
        planetas = new Planeta[] { Mercurio, Venus, Marte, Saturno};
        ocultarPlanetas();
    }
    //En la primera escena, en al canvas, hay un botón en el que su OnClick function es este método
    //Depende de qué botón sea es con qué valor de n manda a llamar al método
    public void cargarNivel(int n)
    {
        if (n == 1)
        {
            SceneManager.LoadScene("Planetas");
        }

    }

    public void mostrarPlaneta(int n)
    {
        ocultarPlanetas();
        switch (n)
        {
            case 1:

                Mercurio.Show();
                Debug.Log("Mercurio");
                break;
            case 2:
                Venus.Show();
                Debug.Log("Venus");

                break;
            case 3:
                Marte.Show();
                Debug.Log("Marte");

                break;
            case 4:
                Saturno.Show();
                Debug.Log("Saturno");

                break;
        }

    }

    public void ocultarPlanetas()
    {
        Mercurio.Hide();
        Venus.Hide();
        Marte.Hide();
        Saturno.Hide();

        //foreach (var model in planetas)
        //{
        //    model.SetActive(false);
        //}
    }

}