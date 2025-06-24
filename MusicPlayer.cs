using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{           

    public class MusicPlayer
    {
    public delegate void PlayingController(string DesiredSong);


        public event PlayingController OnPlaying;
        public event PlayingController OnPaused;
        public event PlayingController OnStopped;
        public event PlayingController OnSkipped;



        public string DesiredSong { get; private set; } //set internally read publicly

        public void Play(string DesiredSong)
        {
            Console.WriteLine($"Playing the desired song: {DesiredSong}");
            //OnPlaying(DesiredSong);
            OnPlaying?.Invoke(DesiredSong); //use as a set event invocation
            
        }

        public void PauseSong(string DesiredSong)
        {
            Console.WriteLine($"Song {DesiredSong} paused");
            OnPaused(DesiredSong);
           //OnPaused?.Invoke() //use as a set event invocation


        }

        public void Stop(string DesiredSong)
        {
            Console.WriteLine($"{DesiredSong} stopped");
            OnStopped(DesiredSong);
            //OnStopped?.Invoke() //use as a set event invocation

        }

        public void SkipSong(string DesiredSong)
        {
            Console.WriteLine($"Song {DesiredSong} skipped");
            OnSkipped(DesiredSong);
            //OnSkipped?.Invoke() //use as a set event invocation

        }

        public void ProvideDesiredSong()
        {
            Console.WriteLine("Enter the song you would like to listen please: ");

            this.DesiredSong= Console.ReadLine();

            Console.WriteLine($"Thank you for choosing {this.DesiredSong}");
        }

        public void provideTheAction()
        {
            Console.WriteLine("Provide us the action (play/pause/stop/skip/change) please: ");

            string actionProvided = Console.ReadLine().ToLower();

            Console.WriteLine($"The action -{actionProvided}- registered");
            

            switch (actionProvided)
            {
                case "play":
                    Play(DesiredSong);
                    break;
                case "pause":
                    PauseSong(DesiredSong);
                    break;
                case "stop":
                    Stop(DesiredSong);
                    break;
                case "skip":
                    SkipSong(DesiredSong);
                    break;
                case "change":
                    ProvideDesiredSong();
                    break;
                default: Console.WriteLine("Incorrect action provided, try again, please");
                    break;
            };


            Console.WriteLine("For turning off the app press Q, please");
            String turnOff = Console.ReadLine();
           
            if(turnOff == "Q" || turnOff == "q")
            {
                Console.WriteLine("The app turned off. Thanks for using and wishing you a nice day");

            } else
            {
                Console.WriteLine("Thanks for staying with us");
                provideTheAction();
            }

           ;
            //public bool Handle





            //if(actionProvided == "Play")
            //{
            //    Play();
            //} else if(actionProvided == "Pause")
            //{
            //    PauseSong();

        //} else if(actionProvided == "Stop")
        //{
        //    Stop();
        //}
        //else if(actionProvided == "Skip")
        //{
        //    SkipSong();
        //} else 
        //{ Console.WriteLine("Incorrect action provided"); 
        //}
        }
}
}
