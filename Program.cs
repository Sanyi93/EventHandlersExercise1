// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography.X509Certificates;
using MusicPlayerApp;

MusicPlayer musicPlayer = new MusicPlayer();

//events
//can be overwritten as follows:
//musicPlayer.OnPlaying += OnPlayingMessage;
musicPlayer.OnPlaying += new MusicPlayer.PlayingController(OnPlayingMessage);
musicPlayer.OnPaused += new MusicPlayer.PlayingController(OnPausedMessage);
musicPlayer.OnStopped += new MusicPlayer.PlayingController(OnStoppedMessage);
musicPlayer.OnSkipped += new MusicPlayer.PlayingController(OnSkippedMessage);

Subscriber subscriber1 = new Subscriber("Martin");
Subscriber subscriber2 = new Subscriber("John");

musicPlayer.OnPlaying += subscriber1.SongPlayedHandler;
musicPlayer.OnPaused += subscriber1.SongPausedHandler;
musicPlayer.OnStopped += subscriber1.SongStoppedHandler;
musicPlayer.OnSkipped += subscriber1.SongSkippedHandler;

musicPlayer.OnPlaying += subscriber2.SongPlayedHandler;
musicPlayer.OnPaused += subscriber2.SongPausedHandler;
musicPlayer.OnStopped += subscriber2.SongStoppedHandler;
musicPlayer.OnSkipped += subscriber2.SongSkippedHandler;




//events methods
static void OnPlayingMessage( string DesiredSong)
{
    Console.WriteLine($"Event triggered: Song {DesiredSong} played");
}

static void OnPausedMessage(string DesiredSong)
{
    Console.WriteLine($"Event triggered: Song paused by Song {DesiredSong}");
}
static void OnStoppedMessage(string DesiredSong)
{
    Console.WriteLine($"Event triggered: Song Stopped by Song {DesiredSong}");
}
static void OnSkippedMessage(string DesiredSong)
{
    Console.WriteLine($"Event triggered: OnSkipped by song {DesiredSong}");
}

musicPlayer.ProvideDesiredSong();
musicPlayer.provideTheAction();




//AI suggested changes:
//// Main application loop
//bool continueApp = true;
//while (continueApp)
//{
//    continueApp = musicPlayer.HandleActionInput(); // HandleActionInput should return true to continue, false to quit
//}

//Console.WriteLine("Application has shut down gracefully.");



//executing methods that are to trigger the events

//musicPlayer.Play();
//musicPlayer.PauseSong();
//musicPlayer.Stop();
//musicPlayer.SkipSong();


