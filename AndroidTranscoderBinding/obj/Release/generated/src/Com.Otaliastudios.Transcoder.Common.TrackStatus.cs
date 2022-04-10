using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackStatus']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/common/TrackStatus", DoNotGenerateAcw=true)]
	public sealed partial class TrackStatus : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackStatus']/field[@name='ABSENT']"
		[Register ("ABSENT")]
		public static global::Com.Otaliastudios.Transcoder.Common.TrackStatus Absent {
			get {
				const string __id = "ABSENT.Lcom/otaliastudios/transcoder/common/TrackStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackStatus']/field[@name='COMPRESSING']"
		[Register ("COMPRESSING")]
		public static global::Com.Otaliastudios.Transcoder.Common.TrackStatus Compressing {
			get {
				const string __id = "COMPRESSING.Lcom/otaliastudios/transcoder/common/TrackStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackStatus']/field[@name='PASS_THROUGH']"
		[Register ("PASS_THROUGH")]
		public static global::Com.Otaliastudios.Transcoder.Common.TrackStatus PassThrough {
			get {
				const string __id = "PASS_THROUGH.Lcom/otaliastudios/transcoder/common/TrackStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackStatus']/field[@name='REMOVING']"
		[Register ("REMOVING")]
		public static global::Com.Otaliastudios.Transcoder.Common.TrackStatus Removing {
			get {
				const string __id = "REMOVING.Lcom/otaliastudios/transcoder/common/TrackStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/common/TrackStatus", typeof (TrackStatus));

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

		internal TrackStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool IsTranscoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackStatus']/method[@name='isTranscoding' and count(parameter)=0]"
			[Register ("isTranscoding", "()Z", "")]
			get {
				const string __id = "isTranscoding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/otaliastudios/transcoder/common/TrackStatus;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Common.TrackStatus ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/otaliastudios/transcoder/common/TrackStatus;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/otaliastudios/transcoder/common/TrackStatus;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Common.TrackStatus[] Values ()
		{
			const string __id = "values.()[Lcom/otaliastudios/transcoder/common/TrackStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Otaliastudios.Transcoder.Common.TrackStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Otaliastudios.Transcoder.Common.TrackStatus));
			} finally {
			}
		}

	}
}
