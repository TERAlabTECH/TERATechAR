using UnityEngine;

public class CustomTrackable : DefaultObserverEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Debug.Log("Encontrado!");
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        Debug.Log("Perdido!");

    }
}
