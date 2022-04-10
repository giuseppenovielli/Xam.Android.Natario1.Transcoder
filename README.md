# Xam.Android.Natario1.Transcoder
Xamarin.Android Binding https://github.com/natario1/Transcoder by Giuseppe Novielli

Natario1.Transcoder v0.10.4

Documentation Available https://github.com/natario1/Transcoder

# How To use
1.  Add nuget package https://www.nuget.org/packages/Xam.Android.Natario1.Transcoder/
2.  Copy and paste follow code
```
var audioStrategy = DefaultAudioStrategy.InvokeBuilder()
            .Channels(DefaultAudioStrategy.ChannelsAsInput)
            .SampleRate(44100)
            .BitRate(128000)
            .Build();

var timeStamp = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss.SSS").Format(new Date());
var name = "MP4_" + timeStamp + ".mp4";
var fileOutputPath = System.IO.Path.Combine(Application.Context.GetExternalFilesDir(Android.OS.Environment.DirectoryMovies).AbsolutePath, name);
var outputUri = AndroidX.Core.Content.FileProvider.GetUriForFile(context, DocumentOpenService.AUTHORITY, new Java.IO.File(fileOutputPath));
var outputFd = context.ContentResolver.OpenFileDescriptor(outputUri, "w");

var videoStrategy = DefaultVideoStrategy.Exact(640, 480).Build();
var listener = new TranscoderListener();

var t = Transcoder.Into(outputFd.FileDescriptor)
    .AddDataSource(context, inputUri)
    .SetVideoTrackStrategy(videoStrategy)
    .SetAudioTrackStrategy(audioStrategy)
    .SetListener(listener);
t.Transcode();
                  
public class TranscoderListener : Java.Lang.Object, ITranscoderListener
{
    public TranscoderListener()
    {
    }

    public void OnTranscodeCanceled()
    {
        System.Diagnostics.Debug.WriteLine("\n\n");
        System.Diagnostics.Debug.WriteLine("OnTranscodeCanceled");
    }

    public async void OnTranscodeCompleted(int p0)
    {
        System.Diagnostics.Debug.WriteLine("\n\n");
        System.Diagnostics.Debug.WriteLine("OnTranscodeCompleted");
        System.Diagnostics.Debug.WriteLine(p0);
    }

    public void OnTranscodeFailed(Java.Lang.Throwable p0)
    {
        System.Diagnostics.Debug.WriteLine("\n\n");
        System.Diagnostics.Debug.WriteLine("OnTranscodeFailed");
        System.Diagnostics.Debug.WriteLine(p0.ToString());
    }

    public void OnTranscodeProgress(double p0)
    {
        System.Diagnostics.Debug.WriteLine("\n\n");
        System.Diagnostics.Debug.WriteLine("OnTranscodeProgress");
        System.Diagnostics.Debug.WriteLine(p0.ToString());
    }
}           
```                  
                  

