using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Thumbnailer']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/Thumbnailer", DoNotGenerateAcw=true)]
	public sealed partial class Thumbnailer : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Thumbnailer.Companion']"
		[global::Android.Runtime.Register ("com/otaliastudios/transcoder/Thumbnailer$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/Thumbnailer$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Thumbnailer.Companion']/constructor[@name='Thumbnailer.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
			[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (_constructor_marker);
				}
			}

			public unsafe global::Com.Otaliastudios.Transcoder.Thumbnailer Instance {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Thumbnailer.Companion']/method[@name='getInstance' and count(parameter)=0]"
				[Register ("getInstance", "()Lcom/otaliastudios/transcoder/Thumbnailer;", "")]
				get {
					const string __id = "getInstance.()Lcom/otaliastudios/transcoder/Thumbnailer;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Thumbnailer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/Thumbnailer", typeof (Thumbnailer));

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

		internal Thumbnailer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Thumbnailer']/constructor[@name='Thumbnailer' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
		[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe Thumbnailer (global::Kotlin.Jvm.Internal.DefaultConstructorMarker _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (_constructor_marker);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Thumbnailer']/method[@name='thumbnails' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.ThumbnailerOptions']]"
		[Register ("thumbnails", "(Lcom/otaliastudios/transcoder/ThumbnailerOptions;)Ljava/util/concurrent/Future;", "")]
		public unsafe global::Java.Util.Concurrent.IFuture Thumbnails (global::Com.Otaliastudios.Transcoder.ThumbnailerOptions options)
		{
			const string __id = "thumbnails.(Lcom/otaliastudios/transcoder/ThumbnailerOptions;)Ljava/util/concurrent/Future;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (options);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Thumbnailer']/method[@name='thumbnails' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.otaliastudios.transcoder.ThumbnailerOptions.Builder, kotlin.Unit&gt;']]"
		[Register ("thumbnails", "(Lkotlin/jvm/functions/Function1;)Ljava/util/concurrent/Future;", "")]
		public unsafe global::Java.Util.Concurrent.IFuture Thumbnails (global::Kotlin.Jvm.Functions.IFunction1 builder)
		{
			const string __id = "thumbnails.(Lkotlin/jvm/functions/Function1;)Ljava/util/concurrent/Future;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

	}
}
