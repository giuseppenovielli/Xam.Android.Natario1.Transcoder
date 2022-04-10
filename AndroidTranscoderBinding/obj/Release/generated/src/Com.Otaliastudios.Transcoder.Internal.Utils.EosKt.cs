using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='EosKt']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/utils/EosKt", DoNotGenerateAcw=true)]
	public sealed partial class EosKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/utils/EosKt", typeof (EosKt));

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

		internal EosKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='EosKt']/method[@name='forcingEos' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource'] and parameter[2][@type='kotlin.jvm.functions.Function0&lt;java.lang.Boolean&gt;']]"
		[Register ("forcingEos", "(Lcom/otaliastudios/transcoder/source/DataSource;Lkotlin/jvm/functions/Function0;)Lcom/otaliastudios/transcoder/source/DataSource;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Source.IDataSource ForcingEos (global::Com.Otaliastudios.Transcoder.Source.IDataSource obj, global::Kotlin.Jvm.Functions.IFunction0 force)
		{
			const string __id = "forcingEos.(Lcom/otaliastudios/transcoder/source/DataSource;Lkotlin/jvm/functions/Function0;)Lcom/otaliastudios/transcoder/source/DataSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue ((force == null) ? IntPtr.Zero : ((global::Java.Lang.Object) force).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (force);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='EosKt']/method[@name='ignoringEos' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.sink.DataSink'] and parameter[2][@type='kotlin.jvm.functions.Function0&lt;java.lang.Boolean&gt;']]"
		[Register ("ignoringEos", "(Lcom/otaliastudios/transcoder/sink/DataSink;Lkotlin/jvm/functions/Function0;)Lcom/otaliastudios/transcoder/sink/DataSink;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Sink.IDataSink IgnoringEos (global::Com.Otaliastudios.Transcoder.Sink.IDataSink obj, global::Kotlin.Jvm.Functions.IFunction0 ignore)
		{
			const string __id = "ignoringEos.(Lcom/otaliastudios/transcoder/sink/DataSink;Lkotlin/jvm/functions/Function0;)Lcom/otaliastudios/transcoder/sink/DataSink;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue ((ignore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ignore).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.IDataSink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (ignore);
			}
		}

	}
}
