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
}
