using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.audio']/class[@name='ShortsKt']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/audio/ShortsKt", DoNotGenerateAcw=true)]
	public sealed partial class ShortsKt : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.audio']/class[@name='ShortsKt']/field[@name='BYTES_PER_SHORT']"
		[Register ("BYTES_PER_SHORT")]
		public const int BytesPerShort = (int) 2;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/audio/ShortsKt", typeof (ShortsKt));

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

		internal ShortsKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
