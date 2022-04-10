using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/media/MediaFormatConstants", DoNotGenerateAcw=true)]
	public partial class MediaFormatConstants : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='KEY_AVC_PPS']"
		[Register ("KEY_AVC_PPS")]
		public const string KeyAvcPps = (string) "csd-1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='KEY_AVC_SPS']"
		[Register ("KEY_AVC_SPS")]
		public const string KeyAvcSps = (string) "csd-0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='KEY_LEVEL']"
		[Register ("KEY_LEVEL")]
		public const string KeyLevel = (string) "level";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='KEY_PROFILE']"
		[Register ("KEY_PROFILE")]
		public const string KeyProfile = (string) "profile";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='KEY_ROTATION_DEGREES']"
		[Register ("KEY_ROTATION_DEGREES")]
		public const string KeyRotationDegrees = (string) "rotation-degrees";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='MIMETYPE_AUDIO_AAC']"
		[Register ("MIMETYPE_AUDIO_AAC")]
		public const string MimetypeAudioAac = (string) "audio/mp4a-latm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='MIMETYPE_AUDIO_RAW']"
		[Register ("MIMETYPE_AUDIO_RAW")]
		public const string MimetypeAudioRaw = (string) "audio/raw";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='MIMETYPE_VIDEO_AVC']"
		[Register ("MIMETYPE_VIDEO_AVC")]
		public const string MimetypeVideoAvc = (string) "video/avc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='MIMETYPE_VIDEO_H263']"
		[Register ("MIMETYPE_VIDEO_H263")]
		public const string MimetypeVideoH263 = (string) "video/3gpp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatConstants']/field[@name='MIMETYPE_VIDEO_VP8']"
		[Register ("MIMETYPE_VIDEO_VP8")]
		public const string MimetypeVideoVp8 = (string) "video/x-vnd.on2.vp8";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/media/MediaFormatConstants", typeof (MediaFormatConstants));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected MediaFormatConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
