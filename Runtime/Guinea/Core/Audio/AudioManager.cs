using FMODUnity;
using FMOD.Studio;
using UnityEngine;
// using Cysharp.Threading.Tasks;

namespace Guinea.Core.Audio
{
    public class AudioManager
    {
        public static FMOD.Studio.System StudioSystem => RuntimeManager.StudioSystem;
        public static void PlayOneShot(EventReference eventReference, Vector3 worldPosition)
        {
            RuntimeManager.PlayOneShot(eventReference,worldPosition);
        }

        public static EventInstance CreateEventInstance(EventReference eventReference)
        {
            EventInstance eventInstance = RuntimeManager.CreateInstance(eventReference);
            return eventInstance;
        }

        public static void LoadBank(string bankName)
        {
            RuntimeManager.LoadBank(bankName);
        }
        public static void LoadBank(TextAsset textAsset)
        {
            RuntimeManager.LoadBank(textAsset);
        }
        public static void UnloadBank(string bankName)
        {
            RuntimeManager.UnloadBank(bankName);
        }
        public static void UnloadBank(TextAsset textAsset)
        {
            RuntimeManager.UnloadBank(textAsset);
        }
    }
}