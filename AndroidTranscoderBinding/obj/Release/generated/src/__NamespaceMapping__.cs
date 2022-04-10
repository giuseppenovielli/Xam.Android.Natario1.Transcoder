using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder", Managed="Com.Otaliastudios.Transcoder")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.common", Managed="Com.Otaliastudios.Transcoder.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.internal.audio", Managed="Com.Otaliastudios.Transcoder.Internal.Audio")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.internal.audio.remix", Managed="Com.Otaliastudios.Transcoder.Internal.Audio.Remix")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.internal.media", Managed="Com.Otaliastudios.Transcoder.Internal.Media")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.internal.pipeline", Managed="Com.Otaliastudios.Transcoder.Internal.Pipeline")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.internal.utils", Managed="Com.Otaliastudios.Transcoder.Internal.Utils")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.internal.video", Managed="Com.Otaliastudios.Transcoder.Internal.Video")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.resample", Managed="Com.Otaliastudios.Transcoder.Resample")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.resize", Managed="Com.Otaliastudios.Transcoder.Resize")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.sink", Managed="Com.Otaliastudios.Transcoder.Sink")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.source", Managed="Com.Otaliastudios.Transcoder.Source")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.strategy", Managed="Com.Otaliastudios.Transcoder.Strategy")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.stretch", Managed="Com.Otaliastudios.Transcoder.Stretch")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.thumbnail", Managed="Com.Otaliastudios.Transcoder.Thumbnail")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.time", Managed="Com.Otaliastudios.Transcoder.Time")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.otaliastudios.transcoder.validator", Managed="Com.Otaliastudios.Transcoder.Validator")]

delegate float _JniMarshal_PP_F (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPD_V (IntPtr jnienv, IntPtr klass, double p0);
delegate void _JniMarshal_PPDD_V (IntPtr jnienv, IntPtr klass, double p0, double p1);
delegate IntPtr _JniMarshal_PPF_L (IntPtr jnienv, IntPtr klass, float p0);
delegate int _JniMarshal_PPI_I (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate long _JniMarshal_PPJ_J (IntPtr jnienv, IntPtr klass, long p0);
delegate IntPtr _JniMarshal_PPJ_L (IntPtr jnienv, IntPtr klass, long p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLILII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, int p3, int p4);
delegate long _JniMarshal_PPLJ_J (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

