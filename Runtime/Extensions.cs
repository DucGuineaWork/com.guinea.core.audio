using FMOD;
using FMOD.Studio;

public static class Extensions 
{
    public static void Release(this FMOD.Studio.EventInstance eventInstance)
    {
        if(eventInstance.isValid())
        {
            eventInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
            eventInstance.release();
        }
    }

    public static void SetParameterByName(this EventInstance eventInstance, string parameterName, float value)
    {
        eventInstance.setParameterByName(parameterName, value);
    }

    public static RESULT GetParameterByName(this EventInstance eventInstance, string parameterName, out float value)
    {
        return eventInstance.getParameterByName(parameterName, out value);
    }

    public static RESULT SetVolume(this Bus bus, float volume)
    {
        return bus.setVolume(volume);
    }
}
