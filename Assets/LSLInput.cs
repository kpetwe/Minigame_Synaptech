using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LSL;

// Not our code
public class LSLInput : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    EnemyMovement script;    
    public string StreamType = "EEG";
    public float scaleInput = 0.1f;

    StreamInfo[] streamInfos;
    StreamInlet streamInlet;

    float[] sample;
    private int channelCount = 0;

    void Start() {
        script = enemy.GetComponent<EnemyMovement>();
    }

    void Update()
    {
        if (streamInlet == null)
        {

            streamInfos = LSL.LSL.resolve_stream("type", StreamType, 1, 0.0);
            if (streamInfos.Length > 0)
            {
                for(int i = 0; i < streamInfos.Length; i++) {
                    if(streamInfos[i].source_id() == "stressdata") {
                         streamInlet = new StreamInlet(streamInfos[i]);
                        channelCount = streamInlet.info().channel_count();
                        streamInlet.open_stream();
                    }
                   
                }
                
            }
        }

        if (streamInlet != null)
        {
            sample = new float[channelCount];
            double lastTimeStamp = streamInlet.pull_sample(sample, 0.0f);
            if (lastTimeStamp != 0.0)
            {
                script.Process(sample, lastTimeStamp);
                while ((lastTimeStamp = streamInlet.pull_sample(sample, 0.0f)) != 0)
                {
                    script.Process(sample, lastTimeStamp);
                    Debug.Log(string.Join(" ", sample));
                }
            }
        }
    }
}