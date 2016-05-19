using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;

namespace BambooTray.App
{
    public class SpeechController
    {
        SpeechSynthesizer speaker = new SpeechSynthesizer();
        private List<string> Queue = new List<string>();

        public List<string> Voices { get; private set; }
        public string SelectedVoice { get; set; }
        public bool Speaking { get; private set; }

        public SpeechController()
        {
            speaker.SpeakCompleted += speaker_SpeakCompleted;
            Speaking = false;
            Voices = speaker.GetInstalledVoices().Where(v => v.Enabled).Select(v => v.VoiceInfo.Name).ToList();
        }

        void speaker_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            Speaking = false;
            Play(Queue.FirstOrDefault());
        }

        public void Play(string words)
        {
            if (string.IsNullOrEmpty(words))
                return;

            if (Speaking)
            {
                Queue.Add(words);
            }
            else
            {
                Speaking = true;
                Queue.RemoveAll(words.Equals);
                speaker.SelectVoice(Voices.Contains(SelectedVoice) ? SelectedVoice : Voices.FirstOrDefault());
                speaker.SpeakAsync(words);
            }
        }
    }
}