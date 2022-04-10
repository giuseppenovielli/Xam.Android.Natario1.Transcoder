using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Strategy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategies']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/strategy/DefaultVideoStrategies", DoNotGenerateAcw=true)]
	public partial class DefaultVideoStrategies : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/strategy/DefaultVideoStrategies", typeof (DefaultVideoStrategies));

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

		protected DefaultVideoStrategies (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategies']/method[@name='for360x480' and count(parameter)=0]"
		[Register ("for360x480", "()Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy For360x480 ()
		{
			const string __id = "for360x480.()Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategies']/method[@name='for720x1280' and count(parameter)=0]"
		[Register ("for720x1280", "()Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy For720x1280 ()
		{
			const string __id = "for720x1280.()Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
