using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackType']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/common/TrackType", DoNotGenerateAcw=true)]
	public sealed partial class TrackType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackType']/field[@name='AUDIO']"
		[Register ("AUDIO")]
		public static global::Com.Otaliastudios.Transcoder.Common.TrackType Audio {
			get {
				const string __id = "AUDIO.Lcom/otaliastudios/transcoder/common/TrackType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackType']/field[@name='VIDEO']"
		[Register ("VIDEO")]
		public static global::Com.Otaliastudios.Transcoder.Common.TrackType Video {
			get {
				const string __id = "VIDEO.Lcom/otaliastudios/transcoder/common/TrackType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/common/TrackType", typeof (TrackType));

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

		internal TrackType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/otaliastudios/transcoder/common/TrackType;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Common.TrackType ValueOf (string value)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/otaliastudios/transcoder/common/TrackType;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/otaliastudios/transcoder/common/TrackType;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Common.TrackType[] Values ()
		{
			const string __id = "values.()[Lcom/otaliastudios/transcoder/common/TrackType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Otaliastudios.Transcoder.Common.TrackType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Otaliastudios.Transcoder.Common.TrackType));
			} finally {
			}
		}

	}
}
