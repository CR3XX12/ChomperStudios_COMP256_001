using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class RollerAgent : Agent
{
    Rigidbody rBody;
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }
    public Transform Target;
    public override void OnEpisodeBegin()
    {
        // If the Agent fell, zero its momentum
        if (this.transform.localPosition.y < 0f)
        {
            this.rBody.angularVelocity = Vector3.zero;
            this.rBody.velocity = Vector3.zero;
            this.transform.localPosition = new Vector3(0, 0.5f, 0);
        }
        this.transform.localPosition = new Vector3(Random.value * 8 - 4, 0.5f, Random.value * 8 - 4);
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        // Target and Agent positions
        sensor.AddObservation(Target.localPosition); //3 floats
        sensor.AddObservation(this.transform.localPosition); //3 floats

        // Agent velocity
        sensor.AddObservation(rBody.velocity.x); //1 floats
        sensor.AddObservation(rBody.velocity.z); //1 floats
    }
    // Total 8 floats
    public float forceMultiplier=10;
    public override void OnActionReceived(ActionBuffers actions)
    {

        Vector3 controlSignal = Vector3.zero;
        controlSignal.x = actions.ContinuousActions[0]; //force x
        controlSignal.z = actions.ContinuousActions[1]; // force z
        rBody.AddForce(controlSignal * forceMultiplier);


        float distanceToTarget = Vector3.Distance(this.transform.localPosition,
            Target.localPosition);
        // Reached target
        if (distanceToTarget < 1.42f)
        {
            SetReward(1.0f);
            EndEpisode();
        }
        else if (this.transform.localPosition.y < 0f)
        {
            //fell off
            EndEpisode();
        }
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var continuousActionsOut = actionsOut.ContinuousActions;
        continuousActionsOut[0] = Input.GetAxis("Horizontal");
        continuousActionsOut[1] = Input.GetAxis("Vertical");
    }


}
